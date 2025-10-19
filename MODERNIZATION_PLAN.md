# TypedMath Modernization Plan

**Status**: Draft
**Target Version**: v3.0.0
**Created**: 2025-01-18

## Overview

TypedMath was created for .NET Framework and has since migrated to .NET 8. This plan identifies redundant methods (now covered by LINQ/modern .NET) and proposes new fluent methods that enhance the core value proposition: **readable, explicit math operations**.

---

## 🗑️ Phase 1: Deprecation Analysis

### Methods to Deprecate (Redundant with LINQ)

All array extension methods listed below are **redundant with LINQ** and should be deprecated in v3.0.0, removed in v4.0.0.

#### **Array Operations - Redundant with LINQ**

| Method | LINQ/Built-in Equivalent | Reason |
|--------|--------------------------|--------|
| `GetAverage()` | `.Average()` | Direct LINQ equivalent |
| `GetHighestValue()` | `.Max()` | Direct LINQ equivalent |
| `GetLowestValue()` | `.Min()` | Direct LINQ equivalent |
| `GetFirstValue()` | `[0]` or `.First()` | Direct access or LINQ |
| `GetLastValue()` | `[^1]` or `.Last()` | C# 8+ index or LINQ |
| `GetMiddleValue()` | `[arr.Length / 2]` | Simple indexing |
| `SumAllValues()` | `.Sum()` | Direct LINQ equivalent |
| `SortArrayAsc()` | `.OrderBy(x => x)` | LINQ or `Array.Sort()` |
| `SortArrayDesc()` | `.OrderByDescending(x => x)` | LINQ or `Array.Sort()` with reverse |
| `GetValuesHigherThan(x)` | `.Where(v => v > x)` | LINQ filter |
| `GetValuesLowerThan(x)` | `.Where(v => v < x)` | LINQ filter |
| `ConvertArrayToInt()` | `.Select(x => (int)x)` | LINQ projection |

#### **Array Manipulation - Keep or Deprecate?**

These are more specialized and may still have value:

| Method | Status | Reason |
|--------|--------|--------|
| `GetFirstHalf()` | **DEPRECATE** | `.Take(arr.Length / 2)` |
| `GetMiddle()` | **DEPRECATE** | `.Skip(1).Take(arr.Length - 2)` |
| `GetLastHalf()` | **DEPRECATE** | `.Skip(arr.Length / 2)` |
| `RotateLeft()` | **KEEP** | Non-trivial, useful for algorithms |
| `RotateRight()` | **KEEP** | Non-trivial, useful for algorithms |
| `IncreaseAllValuesWith(x)` | **DEPRECATE** | `.Select(v => v + x)` |
| `DecreaseAllValuesWith(x)` | **DEPRECATE** | `.Select(v => v - x)` |
| `SetNewArraySize(x)` | **DEPRECATE** | `Array.Resize()` |

**Recommendation**: Deprecate 10+ array methods, keep only `RotateLeft()` and `RotateRight()`.

---

## ✅ Phase 2: Core Value Proposition

**What TypedMath Does Best** (keep and enhance):

### **Arithmetic Operations** ✅ Keep
- `Add()`, `Subtract()`, `MultipliedWith()`, `DividedBy()`, `Modulus()`
- **Why**: Core value - explicit, readable math operations

### **Comparison Operations** ✅ Keep
- `GreaterThan()`, `LessThan()`, `IsEqualTo()`, `IsNotEqualTo()`
- `IsPositive()`, `IsNegative()`
- **Why**: Explicit intent, especially useful for dyscalculia

### **Bitwise Operations** ✅ Keep
- `And()`, `Or()`, `Xor()`, `Not()`, `ShiftLeft()`, `ShiftRight()`
- **Why**: Readable names for cryptic operators

### **Percentage Operations** ✅ Keep
- `PercentOf()`, `AddPercent()`, `SubtractPercent()`
- **Why**: Common business logic, very readable

### **Value Selection** ✅ Keep
- `ChooseIfHigher()`, `ChooseIfLower()`, `SwapWith()`
- **Why**: Readable alternatives to Math.Max/Min in fluent chains

### **Utilities** ✅ Keep
- `IsPrime()` - Specific utility, worth keeping
- `GetDifference()` - Absolute difference helper

---

## 🚀 Phase 3: New Fluent Methods

### **Priority 1: Core Math Operations**

Add to TypedMathGenerator template (applies to all numeric types):

```csharp
// Absolute value
public static T Absolute(this T value) => Math.Abs(value);

// Power operations
public static double RaisedToThePowerOf(this T value, T exponent)
    => Math.Pow(Convert.ToDouble(value), Convert.ToDouble(exponent));

public static T Squared(this T value) => value * value;

public static T Cubed(this T value) => value * value * value;

// Square root (returns double)
public static double SquareRoot(this T value)
    => Math.Sqrt(Convert.ToDouble(value));
```

**Implementation**: 1-2 hours, add to template, regenerate all types.

---

### **Priority 2: Boundaries & Validation**

```csharp
// Clamping
public static T ClampedBetween(this T value, T min, T max)
    => Math.Clamp(value, min, max);

// Range checking
public static bool IsBetween(this T value, T min, T max)
    => value >= min && value <= max;

// Extended comparisons
public static bool IsGreaterThanOrEqualTo(this T value, T other)
    => value >= other;

public static bool IsLessThanOrEqualTo(this T value, T other)
    => value <= other;

public static bool IsZero(this T value) => value == 0;

public static bool IsOne(this T value) => value == 1;
```

**Implementation**: 1 hour, add to template.

---

### **Priority 3: Rounding (double/decimal only)**

Add flag to TypeInfo: `bool SupportsRounding`

```csharp
// Only for double, decimal, float
public static T RoundedTo(this T value, int decimals)
    => Math.Round(value, decimals);

public static T RoundedToNearestWhole(this T value)
    => Math.Round(value);

public static T FloorValue(this T value)
    => Math.Floor(value);

public static T CeilingValue(this T value)
    => Math.Ceiling(value);

public static T TruncatedValue(this T value)
    => Math.Truncate(value);
```

**Implementation**: 2 hours (requires type filtering in generator).

---

### **Priority 4: Integer Checks (int types only)**

Add flag to TypeInfo: `bool SupportsIntegerChecks`

```csharp
// Only for byte, int, long, short, sbyte, etc.
public static bool IsEven(this T value) => value % 2 == 0;

public static bool IsOdd(this T value) => value % 2 != 0;

public static bool IsMultipleOf(this T value, T divisor)
    => value % divisor == 0;

public static bool IsDivisibleBy(this T value, T divisor)
    => value % divisor == 0;
```

**Implementation**: 1 hour (requires type filtering).

---

### **Priority 5: Sign & Negation**

```csharp
public static int GetSign(this T value) => Math.Sign(value);

public static T Negated(this T value) => -value;

public static T WithOppositeSign(this T value) => -value;
```

**Implementation**: 30 minutes, add to template.

---

### **Priority 6: Percentage Enhancement**

```csharp
public static double AsPercentageOf(this T value, T total)
    => (Convert.ToDouble(value) / Convert.ToDouble(total)) * 100;
```

**Implementation**: 15 minutes, add to template.

---

### **Priority 7: Advanced Math (Optional - Low Priority)**

Add flag to TypeInfo: `bool SupportsAdvancedMath`

```csharp
// Trigonometry (double/float only)
public static double Sine(this T value) => Math.Sin(Convert.ToDouble(value));
public static double Cosine(this T value) => Math.Cos(Convert.ToDouble(value));
public static double Tangent(this T value) => Math.Tan(Convert.ToDouble(value));
public static double ToRadians(this T value)
    => Convert.ToDouble(value) * Math.PI / 180;
public static double ToDegrees(this T value)
    => Convert.ToDouble(value) * 180 / Math.PI;

// Logarithms (double/decimal only)
public static double NaturalLog(this T value)
    => Math.Log(Convert.ToDouble(value));
public static double Log10(this T value)
    => Math.Log10(Convert.ToDouble(value));
public static double LogBase(this T value, T baseValue)
    => Math.Log(Convert.ToDouble(value), Convert.ToDouble(baseValue));
public static double Exponential(this T value)
    => Math.Exp(Convert.ToDouble(value));
```

**Implementation**: 3 hours (requires careful type filtering).

---

## 📋 Implementation Roadmap

### **v2.1.0 - Deprecation Warnings** (Q1 2025)

**Goal**: Mark redundant methods as obsolete without breaking changes.

**Changes**:
```csharp
[Obsolete("Use LINQ .Average() instead. This method will be removed in v4.0.0")]
public static double GetAverage(this int[] array) => array.Average();
```

**Checklist**:
- [ ] Add `[Obsolete]` attributes to all redundant array methods
- [ ] Update README with deprecation notices
- [ ] Update CHANGELOG with deprecation list
- [ ] Publish v2.1.0 to NuGet

**Time Estimate**: 2 hours

---

### **v2.2.0 - Priority 1 Additions** (Q1 2025)

**Goal**: Add core math operations (Absolute, Squared, Cubed, Power, SquareRoot).

**Changes**:
1. Update TypedMathGenerator template (`TypedMathIntExtension.cs`)
2. Add new methods to template
3. Regenerate all type extensions
4. Add unit tests for new methods
5. Update README with examples

**Checklist**:
- [ ] Add Absolute() to template
- [ ] Add Squared(), Cubed() to template
- [ ] Add RaisedToThePowerOf() to template
- [ ] Add SquareRoot() to template
- [ ] Regenerate all extensions with TypedMathGenerator
- [ ] Add xUnit tests for all new methods
- [ ] Update README API reference
- [ ] Update CHANGELOG
- [ ] Publish v2.2.0 to NuGet

**Time Estimate**: 3-4 hours

---

### **v2.3.0 - Priority 2 Additions** (Q2 2025)

**Goal**: Add boundaries & validation methods.

**Checklist**:
- [ ] Add ClampedBetween(), IsBetween()
- [ ] Add IsGreaterThanOrEqualTo(), IsLessThanOrEqualTo()
- [ ] Add IsZero(), IsOne()
- [ ] Regenerate extensions
- [ ] Add tests
- [ ] Update docs
- [ ] Publish v2.3.0

**Time Estimate**: 2 hours

---

### **v2.4.0 - Priority 3 & 4 Additions** (Q2 2025)

**Goal**: Add rounding (double/decimal) and integer checks (int types).

**Changes**:
1. Add TypeInfo flags: `SupportsRounding`, `SupportsIntegerChecks`
2. Update generator to conditionally include methods based on flags
3. Add rounding methods for floating-point types
4. Add IsEven/IsOdd for integer types

**Checklist**:
- [ ] Update TypeInfo with new flags
- [ ] Update generator logic for conditional methods
- [ ] Add rounding methods (RoundedTo, Floor, Ceiling, Truncate)
- [ ] Add integer checks (IsEven, IsOdd, IsMultipleOf)
- [ ] Regenerate extensions
- [ ] Add comprehensive tests
- [ ] Update docs
- [ ] Publish v2.4.0

**Time Estimate**: 4-5 hours

---

### **v2.5.0 - Priority 5 & 6 Additions** (Q3 2025)

**Goal**: Add sign operations and percentage enhancements.

**Checklist**:
- [ ] Add GetSign(), Negated(), WithOppositeSign()
- [ ] Add AsPercentageOf()
- [ ] Regenerate extensions
- [ ] Add tests
- [ ] Update docs
- [ ] Publish v2.5.0

**Time Estimate**: 1-2 hours

---

### **v3.0.0 - Major Release** (Q3 2025)

**Goal**: Remove deprecated methods (breaking change).

**Breaking Changes**:
- Remove all array methods marked obsolete in v2.1.0
- Update major version to signal breaking change

**Migration Guide**:
- Provide LINQ equivalent for each removed method
- Code examples showing before/after

**Checklist**:
- [ ] Remove all obsolete methods from template
- [ ] Regenerate extensions
- [ ] Update README - remove deprecated API docs
- [ ] Create MIGRATION_GUIDE_v3.md
- [ ] Update CHANGELOG with breaking changes
- [ ] Publish v3.0.0 to NuGet

**Time Estimate**: 3 hours

---

### **v3.1.0 - Priority 7 (Optional)** (Q4 2025)

**Goal**: Add advanced math (trig, logarithms) if user feedback requests it.

**Checklist**:
- [ ] Add `SupportsAdvancedMath` flag
- [ ] Add trig methods (Sine, Cosine, Tangent, ToRadians, ToDegrees)
- [ ] Add log methods (NaturalLog, Log10, LogBase, Exponential)
- [ ] Regenerate extensions
- [ ] Add tests
- [ ] Update docs
- [ ] Publish v3.1.0

**Time Estimate**: 4-5 hours

---

## 📊 Summary

### **Total Methods to Deprecate**: 12-15 array methods
### **Total New Methods to Add**: 20-35 (depending on optional Phase 7)

### **Time Investment**:
- **Deprecation** (v2.1.0): 2 hours
- **Core additions** (v2.2-2.5): 10-12 hours
- **Breaking release** (v3.0.0): 3 hours
- **Optional advanced** (v3.1.0): 4-5 hours
- **Total**: ~20 hours spread over 6-9 months

### **Value Proposition After v3.0.0**:
- **Focused**: Removed LINQ-redundant bloat
- **Enhanced**: 20+ new fluent math methods
- **Modern**: Aligns with .NET 8+ best practices
- **Readable**: Core mission preserved and strengthened

---

## 🎯 Quick Start (Next Actions)

**To begin Phase 1 (Deprecation)**:
1. Open TypedMathGenerator template
2. Add `[Obsolete]` attributes to array methods
3. Regenerate all extensions
4. Update README with deprecation notice
5. Publish v2.1.0

**To begin Phase 2 (Core Additions)**:
1. Add Absolute(), Squared(), Cubed() to template
2. Add RaisedToThePowerOf(), SquareRoot()
3. Regenerate extensions
4. Write tests
5. Publish v2.2.0

---

**Questions? Concerns?**
- Should we keep `RotateLeft()`/`RotateRight()` or deprecate them too?
- Should Priority 7 (advanced math) be a separate package instead?
- Target timeline: aggressive (3 months) or relaxed (9 months)?

---

**Document Version**: 1.0
**Last Updated**: 2025-01-18
