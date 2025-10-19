# Changelog

All notable changes to TypedMath will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.1.0] - 2025-10-19

### Added
- Support for modern .NET 8+ numeric types:
  - `nint` (native-sized integer)
  - `nuint` (native-sized unsigned integer)
  - `Half` (16-bit floating point)
  - `Int128` (128-bit signed integer)
  - `UInt128` (128-bit unsigned integer)
- New Collections namespaces for array extensions:
  - `MarcusMedinaPro.TypedMath.IntCollections`
  - `MarcusMedinaPro.TypedMath.DoubleCollections`
  - Plus 15 more for all numeric types
- `IsNegative()` - Check if value is less than zero
- `IsPositive()` - Check if value is greater than zero

### Changed
- **BREAKING**: Array extension methods moved to separate `*Collections` namespaces
  - Old namespace methods marked as `[Obsolete]` with migration path
  - Will be removed in v3.0.0
  - Example: Use `TypedMathIntCollections.GetAverage()` instead of `TypedMathIntExtension.GetAverage()`
- Improved code generation for better type safety
  - Fixed Half type arithmetic operations
  - Fixed integer promotion for small types (byte, sbyte, short, ushort, char)
  - Better LINQ integration for array methods

### Deprecated
- Array methods in Extension namespaces (moved to Collections, wrappers will be removed in v3.0.0):
  - Simple LINQ wrappers (prefer LINQ directly):
    - `GetAverage()` → Use LINQ `array.Average()`
    - `GetHighestValue()` → Use LINQ `array.Max()`
    - `GetLowestValue()` → Use LINQ `array.Min()`
    - `GetFirstValue()` → Use LINQ `array.First()` or `array[0]`
    - `SumAllValues()` → Use LINQ `array.Sum()`
    - `GetValuesHigherThan()`, `GetValuesLowerThan()` → Use LINQ `Where()`
    - `SortArrayAsc()`, `SortArrayDesc()` → Use LINQ `OrderBy()`/`OrderByDescending()`
    - `SetNewArraySize()` → Use `Array.Resize()`
  - Convenience methods (available in Collections namespaces with LINQ alternatives in remarks):
    - `DecreaseAllValuesWith()` - Simpler than `array.Select(x => x - dec).ToArray()`
    - `IncreaseAllValuesWith()` - Simpler than `array.Select(x => x + add).ToArray()`
    - `GetFirstHalf()` - Simpler than `array.Take(array.Length / 2).ToArray()`
    - `GetLastHalf()` - Simpler than `array.Skip(array.Length / 2).ToArray()`
    - `GetLastValue()` - Same as `array.Last()` or `array[^1]`
    - `GetMiddle()` - Simpler than `array.Skip(array.Length / 4).Take(array.Length / 2).ToArray()`
    - `GetMiddleValue()` - Same as `array[array.Length / 2]`
- Typo methods (already deprecated, will be removed in v3.0.0):
  - `Substract()` → Use `Subtract()`
  - `SubstractPercent()` → Use `SubtractPercent()`
  - `DiferenceFrom()` → Use `DifferenceFrom()`

### Fixed
- Half type comparison operators now properly cast literals
- Small integer types (byte, sbyte, short, ushort, char) properly handle arithmetic promotion
- Sum/Average operations work correctly for all numeric types including non-standard ones
- Collection methods use correct parameter types (e.g., SetNewArraySize uses `int` for size)

## [2.0.0] - 2025-10-08

### Changed
- **BREAKING**: Upgraded from .NET Framework 4.6.1 to .NET 8.0
- **BREAKING**: Changed license from GPL v3 to MIT
- Migrated to modern SDK-style project format
- Updated copyright year to 2019-2025
- Improved package description and metadata
- Enhanced README with modern formatting, badges, and comprehensive API documentation

### Added
- Comprehensive xUnit test suite with 100+ tests
- Test coverage for int, double, and array extension methods
- GitHub Actions CI/CD workflows (build, test, release)
- Automated security vulnerability scanning
- XML documentation generation
- CHANGELOG.md for version tracking
- Migration guide in README

### Fixed
- Project structure modernized for better maintainability
- Improved package icon handling (renamed to icon.ico/icon.png)

## [1.0.0.9] - 2020-04-06

### Added
- `GetDifference()` method to calculate difference between two numbers

## [1.0.0.x] - 2019-06-03

### Added
- Array handler methods for comprehensive array manipulation
- `GetAverage()`, `GetFirstValue()`, `GetLastValue()`, `GetMiddleValue()`
- `GetHighestValue()`, `GetLowestValue()`
- `GetValuesHigherThan()`, `GetValuesLowerThan()`
- `SortArrayAsc()`, `SortArrayDesc()`
- `SetNewArraySize()`, `SumAllValues()`
- `RotateLeft()`, `RotateRight()`
- `ConvertArrayToInt()`
- `IncreaseAllValuesWith()`, `DecreaseAllValuesWith()`
- `GetFirstHalf()`, `GetMiddle()`, `GetLastHalf()`

## [1.0.0.x] - 2019-05-29

### Fixed
- Corrected misspelling in `Subtract` method
- Added `[Obsolete]` tag to misspelled method for backward compatibility

### Changed
- Renamed `ChoseHighestValue` to `ChooseIfHigher`
- Renamed `ChoseLowestValue` to `ChooseIfLower`

## [1.0.0.x] - 2019-05-26

### Changed
- Renamed `ChoseHighestValue`/`ChoseLowestValue` to `ChoseHighestValueOf`/`ChoseLowestValueOf`
- `SwapWith()` now uses reference parameter for proper value swapping

### Added
- `SetHighestValueOf()` method
- `SetLowestValueOf()` method

## [1.0.0.x] - 2019-05-24

### Added
- `PercentOf()` method for percentage calculations
- `AddPercent()` method to add percentage to value
- `SubtractPercent()` method to subtract percentage from value
- `ChooseHighest()` method (later renamed)
- `ChooseLowest()` method (later renamed)
- `SwapWith()` method for swapping values

## [1.0.0] - 2019-XX-XX

### Added
- Initial release targeting .NET Framework 4.6.1
- Extension methods for all common numeric types:
  - `byte`, `char`, `decimal`, `double`, `float`, `int`, `long`, `sbyte`, `short`, `uint`, `ulong`, `ushort`
- Arithmetic operations: `Add()`, `Subtract()`, `MultipliedWith()`, `DividedBy()`, `Modulus()`
- Comparison operations: `GreaterThan()`, `LessThan()`, `IsEqualTo()`, `IsNotEqualTo()`
- Sign checking: `IsPositive()`, `IsNegative()`
- Bitwise operations: `And()`, `Or()`, `Xor()`, `Not()`, `ShiftLeft()`, `ShiftRight()`
- Type casting methods for all numeric conversions
- `IsPrime()` method for prime number detection
- GPL v3 license

---

[2.1.0]: https://github.com/MarcusMedina/TypedMath/compare/v2.0.0...v2.1.0
[2.0.0]: https://github.com/MarcusMedina/TypedMath/compare/v1.0.0.9...v2.0.0
[1.0.0.9]: https://github.com/MarcusMedina/TypedMath/releases/tag/v1.0.0.9
