# Changelog

All notable changes to Pure.Chart.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

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
