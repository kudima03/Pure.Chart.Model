# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet format --verify-no-changes                # check code style (CI enforces this)
dotnet format && csharpier format .              # auto-fix code style
dotnet test --no-build --verbosity normal        # run xUnit tests
dotnet stryker --mutation-level Complete --break-at 98   # mutation testing (CI threshold: 98%)
dotnet pack --configuration Release -p:Version=<version> --output .
```

CI additionally passes `-p:AssemblyVersion` (pinned to the major) and `-p:FileVersion`; see `.github/workflows/publish-nuget.yml`.

## Architecture

This is a **concrete implementation NuGet library** — sealed records implementing the chart domain contracts defined in `Pure.Chart.Model.Abstractions`.

**Types:**
- `Chart` — root aggregate; holds `IString` title and description, an `IChartType`, two `IAxis` instances (X and Y), and `IEnumerable<IChartSeries>`
- `Axis` — single axis with an `IString` legend
- `ChartSeries` — data series with `IString` legend, `XAxisSource`, `YAxisSource`, and `LineType`
- `ChartType` — named chart type with an arbitrary `IString` name
- `LineChartType`, `BarChartType`, `AreaChartType`, `ScatterChartType`, `StepChartType` — predefined, parameterless chart types with fixed lowercase names (`line`, `bar`, `area`, `scatter`, `step`)
- `SolidLineType`, `DashedLineType`, `DottedLineType` — predefined, parameterless `IString` line types for `ChartSeries.LineType` with fixed lowercase values (`solid`, `dashed`, `dotted`); like the `Pure.Primitives` constant strings, they throw `NotSupportedException` from `GetHashCode` and `ToString`

**Dependency chain:**

```
Pure.Chart.Model
  ├── Pure.Chart.Model.Abstractions   (IChart, IAxis, IChartSeries, IChartType)
  │     └── Pure.Primitives.Abstractions  (IString)
  └── Pure.Primitives                  (String and Char, for the predefined type names and line types)
```

All string-valued properties use `IString` from `Pure.Primitives.Abstractions`; there are no raw `string` properties anywhere in this package.

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. All types must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.2.0.0`. Breaking API changes fail the build.

**Tests:** xUnit project at `./src/Tests/Pure.Chart.Model.Tests`, targeting net10.0. CI enforces ≥98% line coverage and ≥98% mutation score (Stryker, Complete level).

**Publishing:** triggered by pushing a semver tag (`*.*.*`). The tag name becomes the `PackageVersion`.

## Code Style

Enforced via `.editorconfig`, `dotnet format`, and CSharpier:

- No `var` — always use explicit types
- Nullable reference types enabled (`<Nullable>enable</Nullable>`)
- Implicit usings enabled

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
