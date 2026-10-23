# Changelog

All notable changes to Pure.Chart.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.1.0] — 2026-10-23

### Added

- Predefined line types — parameterless sealed records implementing
  `IString` with a fixed lowercase `TextValue`, giving consumers a
  closed set of known values for `ChartSeries.LineType`:
  - **`SolidLineType`** — `solid`.
  - **`DashedLineType`** — `dashed`.
  - **`DottedLineType`** — `dotted`.

## [0.1.0-preview.2.0.0] — 2026-10-23

### Added

- **`ChartSeries.LineType`** — `IString` line type of the series
  (e.g. `solid`, `dashed`, `dotted`), implementing the new
  `IChartSeries.LineType` member. No validation or default at this layer.

### Changed

- **`ChartSeries`** constructor takes a fourth `IString lineType`
  parameter after `yAxisSource` (breaking: the three-parameter
  constructor is removed).
- `Pure.Chart.Model.Abstractions` dependency bumped to
  `0.1.0-preview.2.0.0`.

## [0.1.0-preview.1.1.0] — 2026-10-23

### Added

- Predefined chart types — parameterless sealed records implementing
  `IChartType` with a fixed lowercase `Name`, giving consumers a
  closed set of known chart type names:
  - **`LineChartType`** — `line`.
  - **`BarChartType`** — `bar`.
  - **`AreaChartType`** — `area`.
  - **`ScatterChartType`** — `scatter`.
  - **`StepChartType`** — `step`.
- Dependency on `Pure.Primitives` `3.7.0` for the fixed names.
- `README.md` is now packed into the NuGet package.

### Changed

- The assembly version is now derived from the release tag's major
  version (`0.0.0.0` for `0.x` releases) instead of the SDK default
  `1.0.0.0`; the file version is the tag's numeric part.

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **`Series`** renamed to **`ChartSeries`**, implementing the renamed
  `IChartSeries` (from the updated `Pure.Chart.Model.Abstractions`
  dependency) instead of `ISeries`.
- **`Chart.Series`** type changed from `IEnumerable<ISeries>` to
  `IEnumerable<IChartSeries>`.
- Updated the `Pure.Chart.Model.Abstractions` dependency to
  `0.1.0-preview.1.0.0`.

### Removed

- **`Series`** type removed (replaced by `ChartSeries`, see Changed).

## [0.1.0-preview.0.1.0] — 2026-02-09

### Added

- **`Chart`** — root aggregate implementing `IChart`: `IString` title
  and description, an `IChartType`, an X and a Y `IAxis`, and
  `IEnumerable<ISeries>`.
- **`Axis`** — implements `IAxis` with an `IString` legend.
- **`Series`** — implements `ISeries` with `IString` legend,
  `XAxisSource`, and `YAxisSource`.
- **`ChartType`** — implements `IChartType` with an `IString` name.
- Initial dependency on `Pure.Chart.Model.Abstractions`.
