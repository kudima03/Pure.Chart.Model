# Pure.Chart.Model

Concrete implementations of the chart domain model for the **Pure** ecosystem — immutable, AOT-compatible records implementing the `Pure.Chart.Model.Abstractions` contracts.

[![.NET build & test](https://github.com/kudima03/Pure.Chart.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Chart.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Chart.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Chart.Model)](https://www.nuget.org/packages/Pure.Chart.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Chart.Model` provides sealed record implementations of the chart abstractions defined in [`Pure.Chart.Model.Abstractions`](https://github.com/kudima03/Pure.Chart.Model.Abstractions). Each type is immutable by construction, taking all values through its constructor, and depends on [`IString`](https://github.com/kudima03/Pure.Primitives.Abstractions) from `Pure.Primitives.Abstractions` for all string-valued properties.

## Types

| Type | Implements | Description |
|------|-----------|-------------|
| `Chart` | `IChart` | Root chart record — holds title, description, type, two axes, and a series collection |
| `Axis` | `IAxis` | Single axis with a legend label |
| `ChartSeries` | `IChartSeries` | A data series with a legend and source column names for each axis |
| `ChartType` | `IChartType` | Named chart type (e.g. bar, line, pie) |

All types reside in the `Pure.Chart.Model` namespace.

## Design Principles

- **Immutable** — all properties are init-only; values are set once in the constructor and never changed.
- **Composable** — `Chart` aggregates `IAxis`, `IChartType`, and `IEnumerable<IChartSeries>`, all of which are abstractions, so any implementation can be substituted.
- **AOT-compatible** — sealed records with no reflection or dynamic dispatch; the package is fully compatible with Native AOT.

## Dependencies

- [`Pure.Chart.Model.Abstractions`](https://github.com/kudima03/Pure.Chart.Model.Abstractions/tree/0.1.0-preview.1.0.0) — interfaces `IChart`, `IAxis`, `IChartSeries`, and `IChartType` that this package implements
- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions/tree/4.3.0) — base primitive interfaces; `IString` is used for all string-valued properties

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```shell
dotnet add package Pure.Chart.Model
```

## Usage

```csharp
using Pure.Chart.Model;
using Pure.Primitives.Abstractions.String;

// Assuming MyString : IString is provided by your primitives implementation
IString title       = new MyString("Sales 2024");
IString description = new MyString("Monthly revenue by region");
IString typeName    = new MyString("bar");
IString xLegend     = new MyString("Month");
IString yLegend     = new MyString("Revenue");
IString seriesName  = new MyString("EMEA");
IString xSource     = new MyString("month_col");
IString ySource     = new MyString("revenue_col");

var chart = new Chart(
    title,
    description,
    new ChartType(typeName),
    new Axis(xLegend),
    new Axis(yLegend),
    [new ChartSeries(seriesName, xSource, ySource)]
);
```
