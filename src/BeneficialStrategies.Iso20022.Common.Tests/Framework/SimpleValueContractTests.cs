// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Text.Json;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization;
using BeneficialStrategies.Iso20022.SimpleTypes;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022;

// ── Base contract ──────────────────────────────────────────────────────────────

/// <summary>
/// Abstract contract test for any <see cref="IIsoSimpleValue{T}"/> primitive struct.
/// Subclass once per concrete type; each subclass becomes its own isolated test class.
/// </summary>
/// <typeparam name="TStruct">The primitive struct under test.</typeparam>
/// <typeparam name="TValue">The underlying CLR value type (string, decimal, byte[], etc.).</typeparam>
public abstract class SimpleValueContractTests<TStruct, TValue>
    where TStruct : struct, IIsoSimpleValue<TValue>
{
    /// <summary>A value that satisfies the ISO format constraint.</summary>
    protected abstract TValue ValidSample { get; }

    /// <summary>A value that violates the ISO format constraint.</summary>
    protected abstract TValue InvalidSample { get; }

    // ── Construction ───────────────────────────────────────────────────────────

    [Fact]
    public void ValidConstruction_Succeeds()
    {
        var instance = Activator.CreateInstance(typeof(TStruct), ValidSample);
        Assert.NotNull(instance);
    }

    [Fact]
    public void InvalidConstruction_ThrowsIso20022FormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), InvalidSample));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    // ── TryCreate ──────────────────────────────────────────────────────────────

    [Fact]
    public void TryCreate_ValidValue_ReturnsTrueAndInstance()
    {
        var method = GetTryCreate();
        var args = new object?[] { ValidSample, null };
        var result = (bool)method.Invoke(null, args)!;
        Assert.True(result);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_InvalidValue_ReturnsFalse()
    {
        var method = GetTryCreate();
        var args = new object?[] { InvalidSample, null };
        var result = (bool)method.Invoke(null, args)!;
        Assert.False(result);
    }

    // ── Equality ───────────────────────────────────────────────────────────────

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        var b = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());

        // Invoke == and != via reflection — compiler cannot resolve operators on generic TStruct.
        var opEq = typeof(TStruct).GetMethod("op_Equality",
            BindingFlags.Public | BindingFlags.Static, [typeof(TStruct), typeof(TStruct)]);
        var opNe = typeof(TStruct).GetMethod("op_Inequality",
            BindingFlags.Public | BindingFlags.Static, [typeof(TStruct), typeof(TStruct)]);
        Assert.NotNull(opEq);
        Assert.NotNull(opNe);
        Assert.True((bool)opEq!.Invoke(null, [a, b])!);
        Assert.False((bool)opNe!.Invoke(null, [a, b])!);
    }

    // ── ToString ───────────────────────────────────────────────────────────────

    [Fact]
    public void ToString_ReturnsValidSample()
    {
        var instance = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        Assert.Equal(ValidSample!.ToString(), instance.ToString());
    }

    [Fact]
    public void Default_ToString_ReturnsEmptyString()
    {
        var instance = default(TStruct);
        Assert.Equal(string.Empty, instance.ToString());
    }

    // ── JSON ───────────────────────────────────────────────────────────────────

    [Fact]
    public void JsonRoundTrip_Succeeds()
    {
        var instance = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }

    [Fact]
    public void JsonDeserialize_InvalidValue_ThrowsJsonException()
    {
        var json = $"\"{InvalidSample}\"";
        Assert.Throws<JsonException>(
            () => JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default));
    }

    // ── Helpers ────────────────────────────────────────────────────────────────

    // Selects the TryCreate(TValue, out TStruct) overload specifically, handling types that
    // also expose TryCreate(byte, out TStruct) or other additional overloads.
    private static MethodInfo GetTryCreate() =>
        typeof(TStruct)
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(m =>
                m.Name == "TryCreate"
                && m.GetParameters() is [var p0, var p1]
                && p0.ParameterType == typeof(TValue)
                && p1.ParameterType == typeof(TStruct).MakeByRefType())
        ?? throw new InvalidOperationException(
            $"{typeof(TStruct).Name} is missing a TryCreate({typeof(TValue).Name}, out {typeof(TStruct).Name}) method.");
}

/// <summary>
/// Convenience base for the common case of <c>IIsoSimpleValue&lt;string&gt;</c> structs.
/// Also verifies struct-to-string and string-to-struct equality operators.
/// </summary>
public abstract class SimpleValueStringContractTests<TStruct>
    : SimpleValueContractTests<TStruct, string>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void StringEquality_StructEqualsString()
    {
        var instance = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        // Use object.Equals via reflection to avoid compile-time operator resolution issues
        var opEq = typeof(TStruct).GetMethod(
            "op_Equality",
            BindingFlags.Public | BindingFlags.Static,
            [typeof(TStruct), typeof(string)]);
        Assert.NotNull(opEq); // operator ==(TStruct, string?) must exist
        Assert.True((bool)opEq!.Invoke(null, [instance, ValidSample])!);
        Assert.False((bool)opEq.Invoke(null, [instance, InvalidSample])!);
    }

    [Fact]
    public void ImplicitConversion_StringToStruct_Succeeds()
    {
        var op = typeof(TStruct).GetMethod(
            "op_Implicit",
            BindingFlags.Public | BindingFlags.Static,
            [typeof(string)]);
        Assert.NotNull(op); // implicit operator TStruct(string) must exist
        var instance = op!.Invoke(null, [ValidSample]);
        Assert.NotNull(instance);
        Assert.Equal(ValidSample, ((IIsoSimpleValue<string>)instance!).Value);
    }

    [Fact]
    public void ImplicitConversion_StructToString_Succeeds()
    {
        var instance = (TStruct)Activator.CreateInstance(typeof(TStruct), ValidSample)!;
        // Filter by return type to disambiguate types with multiple op_Implicit overloads (e.g. Exact1HexBinaryText).
        var op = typeof(TStruct)
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(m =>
                m.Name == "op_Implicit"
                && m.ReturnType == typeof(string)
                && m.GetParameters() is [var p] && p.ParameterType == typeof(TStruct));
        Assert.NotNull(op); // implicit operator string(TStruct) must exist
        var str = (string)op!.Invoke(null, [instance])!;
        Assert.Equal(ValidSample, str);
    }
}

// ── Exact-length any-character contract ───────────────────────────────────────

/// <summary>
/// Contract base for types that accept any Unicode character at an exact fixed length
/// (e.g. <c>Exact10Text</c>). Subclasses need only override <see cref="ExactLength"/>.
/// </summary>
public abstract class SimpleValueExactTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    protected abstract int ExactLength { get; }
    protected override int MinLength => ExactLength;
    protected override int MaxLength => ExactLength;
}

// ── Numeric-only contract ──────────────────────────────────────────────────────

/// <summary>
/// Contract base for ISO 20022 numeric-text types (<c>[0-9]{M,N}</c>).
/// Adds a test verifying that non-digit characters are rejected with
/// <see cref="Iso20022FormatViolation.InvalidCharacter"/>.
/// </summary>
public abstract class SimpleValueNumericTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    // Numeric types require digit pad characters for length tests.
    protected override char ValidPadChar => '1';

    [Fact]
    public void NonDigit_ThrowsInvalidCharacter()
    {
        // A string of valid length but containing letters — should reject with InvalidCharacter.
        var invalidChars = new string('A', MaxLength);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), invalidChars));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, fmt.Violation);
    }
}

// ── Alphanumeric-only contract ─────────────────────────────────────────────────

/// <summary>
/// Contract base for ISO 20022 alphanumeric-text types (<c>[a-zA-Z0-9]{M,N}</c>).
/// Adds a test verifying that special characters are rejected with
/// <see cref="Iso20022FormatViolation.InvalidCharacter"/>.
/// </summary>
public abstract class SimpleValueAlphaNumericTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void SpecialChar_ThrowsInvalidCharacter()
    {
        // A string of valid length but containing only special characters.
        var invalidChars = new string('!', MaxLength);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), invalidChars));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, fmt.Violation);
    }
}

// ── Max*Text length-constrained contract ──────────────────────────────────────

/// <summary>
/// Contract tests for ISO 20022 plain text types (Max*Text family): minLength and maxLength
/// enforced, any Unicode character permitted, no pattern restriction.
/// </summary>
/// <remarks>
/// Concrete subclasses need only override <see cref="MaxLength"/> (and <see cref="MinLength"/>
/// for the rare type where it differs from 1, e.g. <c>Max30Text</c> where minLength is 0).
/// <para>
/// Valid and invalid samples are derived automatically — no per-type boilerplate needed.
/// </para>
/// </remarks>
public abstract class SimpleValueMaxTextContractTests<TStruct>
    : SimpleValueStringContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    /// <summary>ISO 20022 minLength for this type. Override when it is not 1.</summary>
    protected virtual int MinLength => 1;

    /// <summary>ISO 20022 maxLength for this type.</summary>
    protected abstract int MaxLength { get; }

    /// <summary>
    /// A character that is always valid for this type, used to build pad strings in length tests.
    /// Override in restricted subtypes (e.g. numeric types should return '1', not 'A').
    /// </summary>
    protected virtual char ValidPadChar => 'A';

    // Base class samples are derived from the length constraints.
    protected override string ValidSample => new string(ValidPadChar, MinLength == 0 ? 1 : MinLength);
    protected override string InvalidSample => new string(ValidPadChar, MaxLength + 1);

    // ── Boundary tests ─────────────────────────────────────────────────────────

    [Fact]
    public virtual void ExactMaxLength_IsAccepted()
    {
        var value = new string(ValidPadChar, MaxLength);
        var instance = Activator.CreateInstance(typeof(TStruct), value);
        Assert.NotNull(instance);
    }

    [Fact]
    public virtual void OneOverMaxLength_ThrowsTooLong()
    {
        var over = new string(ValidPadChar, MaxLength + 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), over));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.TooLong, fmt.Violation);
    }

    [Fact]
    public void Null_ThrowsArgumentNullException()
    {
        // Use explicit constructor lookup to avoid AmbiguousMatchException on types with
        // multiple constructors (e.g. Exact1HexBinaryText has both (string) and (byte)).
        var ctor = typeof(TStruct).GetConstructor(new[] { typeof(string) })
            ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (string) constructor.");
        Assert.Throws<TargetInvocationException>(() => ctor.Invoke(new object?[] { null }));
    }

    [Fact]
    public void Empty_Behaviour_MatchesMinLength()
    {
        if (MinLength > 0)
        {
            // Empty is invalid — must throw TooShort.
            var ex = Assert.Throws<TargetInvocationException>(
                () => Activator.CreateInstance(typeof(TStruct), string.Empty));
            var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
            Assert.Equal(Iso20022FormatViolation.TooShort, fmt.Violation);
        }
        else
        {
            // minLength == 0: empty string is valid.
            var instance = Activator.CreateInstance(typeof(TStruct), string.Empty);
            Assert.NotNull(instance);
        }
    }

    [Fact]
    public void TooLong_ExceptionMessage_ContainsActualLength()
    {
        var over = new string(ValidPadChar, MaxLength + 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), over));
        Assert.Contains((MaxLength + 1).ToString(), ex.InnerException!.Message);
    }
}

// ── XSD numeric type contract ──────────────────────────────────────────────────

/// <summary>
/// Standalone contract base for W3C XSD numeric types (xs:int, xs:long, xs:positiveInteger, etc.).
/// Does NOT inherit from the string contract hierarchy because these types implement
/// <see cref="IIsoSimpleValue{TValue}"/> where TValue is a numeric type, not <c>string</c>.
/// Tests both the native-type and string-constructor paths.
/// </summary>
public abstract class SimpleValueXsdNumericContractTests<TStruct, TValue>
    where TStruct : struct, IIsoSimpleValue<TValue>
    where TValue : struct
{
    /// <summary>A valid native value (e.g. 42).</summary>
    protected abstract TValue ValidNativeSample { get; }

    /// <summary>A non-numeric string that must be rejected by the string constructor.</summary>
    protected virtual string InvalidStringSample => "not-a-number";

    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(TValue)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a ({typeof(TValue).Name}) constructor.");

    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (string) constructor.");

    [Fact]
    public void NativeConstruction_Succeeds()
        => Assert.NotNull(NativeCtor().Invoke([ValidNativeSample]));

    [Fact]
    public void StringConstruction_ValidString_Succeeds()
        => Assert.NotNull(StringCtor().Invoke([ValidNativeSample.ToString()]));

    [Fact]
    public void StringConstruction_InvalidString_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(
            () => StringCtor().Invoke([InvalidStringSample]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([ValidNativeSample])!;
        var b = (TStruct)NativeCtor().Invoke([ValidNativeSample])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void ToString_MatchesNativeToString()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample])!;
        Assert.Equal(ValidNativeSample.ToString(), instance.ToString());
    }

    [Fact]
    public void ImplicitFromNative_Works()
    {
        var op = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "op_Implicit"
                && m.ReturnType == typeof(TStruct)
                && m.GetParameters() is [var p] && p.ParameterType == typeof(TValue));
        var result = (TStruct)op.Invoke(null, [ValidNativeSample])!;
        Assert.Equal(ValidNativeSample, result.Value);
    }

    [Fact]
    public void ImplicitToNative_Works()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample])!;
        var op = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "op_Implicit"
                && m.ReturnType == typeof(TValue)
                && m.GetParameters() is [var p] && p.ParameterType == typeof(TStruct));
        Assert.Equal(ValidNativeSample, (TValue)op.Invoke(null, [instance])!);
    }

    [Fact]
    public void NativeEqualityOperator_Works()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample])!;
        var opEq = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "op_Equality"
                && m.GetParameters() is [var p0, var p1]
                && p0.ParameterType == typeof(TStruct) && p1.ParameterType == typeof(TValue));
        Assert.True((bool)opEq.Invoke(null, [instance, ValidNativeSample])!);
    }

    [Fact]
    public void TryCreate_ValidNative_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "TryCreate"
                && m.GetParameters() is [var p0, var p1]
                && p0.ParameterType == typeof(TValue)
                && p1.ParameterType == typeof(TStruct).MakeByRefType());
        var args = new object?[] { ValidNativeSample, null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }
}

/// <summary>
/// Contract base for range-constrained XSD integer types (xs:positiveInteger, etc.)
/// that additionally verify out-of-range native values are rejected.
/// </summary>
public abstract class SimpleValueXsdConstrainedLongContractTests<TStruct>
    : SimpleValueXsdNumericContractTests<TStruct, long>
    where TStruct : struct, IIsoSimpleValue<long>
{
    /// <summary>A long value that violates this type's range constraint.</summary>
    protected abstract long OutOfRangeNativeSample { get; }

    [Fact]
    public void OutOfRangeNative_ThrowsFormatException()
    {
        var ctor = typeof(TStruct).GetConstructor([typeof(long)])!;
        var ex = Assert.Throws<TargetInvocationException>(() => ctor.Invoke([OutOfRangeNativeSample]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}

// ── XSD boolean contract ───────────────────────────────────────────────────────

/// <summary>
/// Contract base for <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdBoolean"/> — the
/// lone <c>IIsoSimpleValue&lt;bool&gt;</c> primitive. Wire format is the lowercase
/// <c>"true"</c>/<c>"false"</c> canonical form (NOT .NET's <c>bool.ToString()</c> output of
/// <c>"True"</c>/<c>"False"</c>), so this does not reuse
/// <see cref="SimpleValueXsdNumericContractTests{TStruct,TValue}"/>.
/// </summary>
public abstract class SimpleValueXsdBooleanContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<bool>
{
    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(bool)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (bool) constructor.");

    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (string) constructor.");

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void NativeConstruction_Succeeds(bool value)
        => Assert.NotNull(NativeCtor().Invoke([value]));

    [Theory]
    [InlineData("true", true)]
    [InlineData("false", false)]
    [InlineData("1", true)]
    [InlineData("0", false)]
    public void StringConstruction_ValidLexicalForm_Succeeds(string text, bool expected)
    {
        var instance = (TStruct)StringCtor().Invoke([text])!;
        Assert.Equal(expected, instance.Value);
    }

    [Fact]
    public void StringConstruction_InvalidString_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke(["maybe"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Theory]
    [InlineData(true, "true")]
    [InlineData(false, "false")]
    public void ToString_UsesLowercaseCanonicalForm(bool value, string expected)
    {
        var instance = (TStruct)NativeCtor().Invoke([value])!;
        Assert.Equal(expected, instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([true])!;
        var b = (TStruct)NativeCtor().Invoke([true])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void TryCreate_Native_AlwaysSucceeds()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(bool), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { true, null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "true", null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "maybe", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([true])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal("\"true\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }

    [Fact]
    public void JsonDeserialize_InvalidValue_ThrowsJsonException()
    {
        const string json = "\"maybe\"";
        Assert.Throws<JsonException>(
            () => JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default));
    }
}

// ── XSD floating-point contract ────────────────────────────────────────────────

/// <summary>
/// Contract base for the XSD floating-point primitives
/// (<see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdFloat"/>,
/// <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdDouble"/>). Wire format for special
/// values is <c>"INF"</c>/<c>"-INF"</c>/<c>"NaN"</c> (NOT .NET's
/// <c>"Infinity"</c>/<c>"-Infinity"</c>), so this does not reuse
/// <see cref="SimpleValueXsdNumericContractTests{TStruct,TValue}"/>.
/// </summary>
public abstract class SimpleValueXsdFloatingPointContractTests<TStruct, TValue>
    where TStruct : struct, IIsoSimpleValue<TValue>
    where TValue : struct
{
    /// <summary>A finite native sample value (e.g. 42.5).</summary>
    protected abstract TValue FiniteSample { get; }

    /// <summary>The wire-format string for <see cref="FiniteSample"/> (e.g. "42.5").</summary>
    protected abstract string FiniteSampleWireText { get; }

    protected abstract TValue PositiveInfinitySample { get; }
    protected abstract TValue NegativeInfinitySample { get; }
    protected abstract TValue NaNSample { get; }

    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(TValue)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a ({typeof(TValue).Name}) constructor.");

    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (string) constructor.");

    [Fact]
    public void NativeConstruction_FiniteValue_Succeeds()
        => Assert.NotNull(NativeCtor().Invoke([FiniteSample]));

    [Fact]
    public void NativeConstruction_PositiveInfinity_Succeeds()
        => Assert.NotNull(NativeCtor().Invoke([PositiveInfinitySample]));

    [Fact]
    public void NativeConstruction_NegativeInfinity_Succeeds()
        => Assert.NotNull(NativeCtor().Invoke([NegativeInfinitySample]));

    [Fact]
    public void NativeConstruction_NaN_Succeeds()
        => Assert.NotNull(NativeCtor().Invoke([NaNSample]));

    [Fact]
    public void StringConstruction_FiniteValue_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke([FiniteSampleWireText])!;
        Assert.Equal(FiniteSample, instance.Value);
    }

    [Fact]
    public void StringConstruction_PositiveInfinity_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["INF"])!;
        Assert.Equal(PositiveInfinitySample, instance.Value);
    }

    [Fact]
    public void StringConstruction_NegativeInfinity_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["-INF"])!;
        Assert.Equal(NegativeInfinitySample, instance.Value);
    }

    [Fact]
    public void StringConstruction_NaN_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["NaN"])!;
        Assert.Equal("NaN", instance.ToString());
    }

    [Fact]
    public void StringConstruction_InvalidString_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke(["not-a-number"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void ToString_FiniteValue_MatchesWireText()
    {
        var instance = (TStruct)NativeCtor().Invoke([FiniteSample])!;
        Assert.Equal(FiniteSampleWireText, instance.ToString());
    }

    [Fact]
    public void ToString_PositiveInfinity_ReturnsINF()
    {
        var instance = (TStruct)NativeCtor().Invoke([PositiveInfinitySample])!;
        Assert.Equal("INF", instance.ToString());
    }

    [Fact]
    public void ToString_NegativeInfinity_ReturnsNegativeINF()
    {
        var instance = (TStruct)NativeCtor().Invoke([NegativeInfinitySample])!;
        Assert.Equal("-INF", instance.ToString());
    }

    [Fact]
    public void ToString_NaN_ReturnsNaN()
    {
        var instance = (TStruct)NativeCtor().Invoke([NaNSample])!;
        Assert.Equal("NaN", instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([FiniteSample])!;
        var b = (TStruct)NativeCtor().Invoke([FiniteSample])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void NaNInstances_AreEqual()
    {
        // Struct equality delegates to TValue.Equals (not the == operator), so NaN.Equals(NaN)
        // is true here — unlike IEEE 754 == semantics, where NaN == NaN is false.
        var a = (TStruct)NativeCtor().Invoke([NaNSample])!;
        var b = (TStruct)NativeCtor().Invoke([NaNSample])!;
        Assert.Equal(a, b);
    }

    [Fact]
    public void TryCreate_Native_AlwaysSucceeds()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(TValue), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { FiniteSample, null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { FiniteSampleWireText, null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "not-a-number", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_FiniteValue_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([FiniteSample])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal($"\"{FiniteSampleWireText}\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }

    [Fact]
    public void JsonRoundTrip_PositiveInfinity_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([PositiveInfinitySample])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal("\"INF\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }

    [Fact]
    public void JsonDeserialize_InvalidValue_ThrowsJsonException()
    {
        const string json = "\"not-a-number\"";
        Assert.Throws<JsonException>(
            () => JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default));
    }
}

// ── XSD timezone-qualified Gregorian scalar contract ───────────────────────────

/// <summary>
/// Contract base for the timezone-qualified XSD Gregorian scalar primitives
/// (<see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGYear"/>,
/// <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGMonth"/>,
/// <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGDay"/>). Each wraps a single native
/// numeric <c>Value</c> plus an optional
/// <see cref="IIsoTimezoneQualifiedValue.TimezoneOffset"/> that
/// <see cref="SimpleValueXsdNumericContractTests{TStruct,TValue}"/> has no concept of, so this
/// does not reuse it.
/// </summary>
public abstract class SimpleValueXsdGregorianScalarContractTests<TStruct, TValue>
    where TStruct : struct, IIsoSimpleValue<TValue>, IIsoTimezoneQualifiedValue
    where TValue : struct
{
    /// <summary>A valid native sample value (e.g. month 6).</summary>
    protected abstract TValue ValidNativeSample { get; }

    /// <summary>The wire-format core (no timezone) for <see cref="ValidNativeSample"/> (e.g. "--06").</summary>
    protected abstract string ValidNativeSampleWireCore { get; }

    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(TValue), typeof(TimeSpan?)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a ({typeof(TValue).Name}, TimeSpan?) constructor.");

    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (string) constructor.");

    [Fact]
    public void NativeConstruction_NoTimezone_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        Assert.Equal(ValidNativeSample, instance.Value);
        Assert.Null(instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_NoTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke([ValidNativeSampleWireCore])!;
        Assert.Equal(ValidNativeSample, instance.Value);
        Assert.Null(instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_UtcTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke([ValidNativeSampleWireCore + "Z"])!;
        Assert.Equal(TimeSpan.Zero, instance.TimezoneOffset);
    }

    [Theory]
    [InlineData("+05:00")]
    [InlineData("-05:00")]
    public void StringConstruction_OffsetTimezone_Succeeds(string tz)
    {
        var instance = (TStruct)StringCtor().Invoke([ValidNativeSampleWireCore + tz])!;
        var expected = tz[0] == '-' ? -new TimeSpan(5, 0, 0) : new TimeSpan(5, 0, 0);
        Assert.Equal(expected, instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_OutOfRangeTimezone_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke([ValidNativeSampleWireCore + "+15:00"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void StringConstruction_InvalidCore_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke(["not-a-value"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void ToString_NoTimezone_MatchesWireCore()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        Assert.Equal(ValidNativeSampleWireCore, instance.ToString());
    }

    [Fact]
    public void ToString_UtcTimezone_AppendsZ()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, TimeSpan.Zero])!;
        Assert.Equal(ValidNativeSampleWireCore + "Z", instance.ToString());
    }

    [Fact]
    public void ToString_OffsetTimezone_AppendsOffset()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, new TimeSpan(5, 30, 0)])!;
        Assert.Equal(ValidNativeSampleWireCore + "+05:30", instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        var b = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void DifferentTimezone_InstancesAreNotEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        var b = (TStruct)NativeCtor().Invoke([ValidNativeSample, TimeSpan.Zero])!;
        Assert.NotEqual(a, b);
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { ValidNativeSampleWireCore, null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "not-a-value", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_NoTimezone_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, null])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal($"\"{ValidNativeSampleWireCore}\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }

    [Fact]
    public void JsonRoundTrip_WithTimezone_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([ValidNativeSample, TimeSpan.Zero])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal($"\"{ValidNativeSampleWireCore}Z\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }
}

/// <summary>
/// Contract base for range-constrained timezone-qualified Gregorian scalars
/// (<see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGMonth"/>,
/// <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGDay"/>) that additionally verify
/// out-of-range native values are rejected. <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGYear"/>
/// is unconstrained (any <see cref="int"/> is a valid year) and uses the base directly.
/// </summary>
public abstract class SimpleValueXsdGregorianScalarRangeConstrainedContractTests<TStruct, TValue>
    : SimpleValueXsdGregorianScalarContractTests<TStruct, TValue>
    where TStruct : struct, IIsoSimpleValue<TValue>, IIsoTimezoneQualifiedValue
    where TValue : struct
{
    /// <summary>A native value that violates this type's range constraint.</summary>
    protected abstract TValue OutOfRangeNativeSample { get; }

    [Fact]
    public void OutOfRangeNative_ThrowsFormatException()
    {
        var ctor = typeof(TStruct).GetConstructor([typeof(TValue), typeof(TimeSpan?)])!;
        var ex = Assert.Throws<TargetInvocationException>(() => ctor.Invoke([OutOfRangeNativeSample, null]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}

// ── XSD timezone-qualified Gregorian composite contract ────────────────────────

/// <summary>
/// Contract base for <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGYearMonth"/> —
/// wire format <c>"YYYY-MM"</c>, optionally timezone-qualified.
/// </summary>
public abstract class SimpleValueXsdGYearMonthContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<(int Year, byte Month)>, IIsoTimezoneQualifiedValue
{
    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(int), typeof(byte), typeof(TimeSpan?)])!;
    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])!;

    [Fact]
    public void NativeConstruction_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([2026, (byte)8, null])!;
        Assert.Equal((2026, (byte)8), instance.Value);
    }

    [Fact]
    public void NativeConstruction_InvalidMonth_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => NativeCtor().Invoke([2026, (byte)13, null]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void StringConstruction_NoTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["2026-08"])!;
        Assert.Equal((2026, (byte)8), instance.Value);
        Assert.Null(instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_WithTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["2026-08Z"])!;
        Assert.Equal(TimeSpan.Zero, instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_NegativeYear_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["-0043-05"])!;
        Assert.Equal((-43, (byte)5), instance.Value);
    }

    [Fact]
    public void StringConstruction_Invalid_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke(["not-a-value"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void ToString_MatchesWireFormat()
    {
        var instance = (TStruct)NativeCtor().Invoke([2026, (byte)8, new TimeSpan(5, 30, 0)])!;
        Assert.Equal("2026-08+05:30", instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([2026, (byte)8, null])!;
        var b = (TStruct)NativeCtor().Invoke([2026, (byte)8, null])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "2026-08", null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "not-a-value", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([2026, (byte)8, TimeSpan.Zero])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal("\"2026-08Z\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }
}

/// <summary>
/// Contract base for <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdGMonthDay"/> —
/// wire format <c>"--MM-DD"</c>, optionally timezone-qualified.
/// </summary>
public abstract class SimpleValueXsdGMonthDayContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<(byte Month, byte Day)>, IIsoTimezoneQualifiedValue
{
    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(byte), typeof(byte), typeof(TimeSpan?)])!;
    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])!;

    [Fact]
    public void NativeConstruction_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([(byte)8, (byte)15, null])!;
        Assert.Equal(((byte)8, (byte)15), instance.Value);
    }

    [Fact]
    public void NativeConstruction_InvalidMonth_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => NativeCtor().Invoke([(byte)13, (byte)1, null]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void NativeConstruction_DayExceedsMonthMaximum_ThrowsFormatException()
    {
        // April has 30 days, even in a leap-year context.
        var ex = Assert.Throws<TargetInvocationException>(() => NativeCtor().Invoke([(byte)4, (byte)31, null]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void NativeConstruction_February29_Succeeds()
    {
        // Feb 29 is always valid for gMonthDay — it's a recurring date, not tied to a specific year.
        var instance = (TStruct)NativeCtor().Invoke([(byte)2, (byte)29, null])!;
        Assert.Equal(((byte)2, (byte)29), instance.Value);
    }

    [Fact]
    public void StringConstruction_NoTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["--08-15"])!;
        Assert.Equal(((byte)8, (byte)15), instance.Value);
        Assert.Null(instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_WithTimezone_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["--08-15Z"])!;
        Assert.Equal(TimeSpan.Zero, instance.TimezoneOffset);
    }

    [Fact]
    public void StringConstruction_Invalid_ThrowsFormatException()
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke(["not-a-value"]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void ToString_MatchesWireFormat()
    {
        var instance = (TStruct)NativeCtor().Invoke([(byte)8, (byte)15, new TimeSpan(5, 30, 0)])!;
        Assert.Equal("--08-15+05:30", instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)NativeCtor().Invoke([(byte)8, (byte)15, null])!;
        var b = (TStruct)NativeCtor().Invoke([(byte)8, (byte)15, null])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "--08-15", null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "not-a-value", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_Succeeds()
    {
        var instance = (TStruct)NativeCtor().Invoke([(byte)8, (byte)15, TimeSpan.Zero])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal("\"--08-15Z\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }
}

// ── XSD duration contract ───────────────────────────────────────────────────────

/// <summary>
/// Contract base for <see cref="BeneficialStrategies.Iso20022.SimpleTypes.XsdDuration"/> — wire
/// format <c>"-?PnYnMnDTnHnMnS"</c>. No timezone component (unlike the <c>xs:g*</c> types).
/// </summary>
public abstract class SimpleValueXsdDurationContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<XsdDurationValue>
{
    private static ConstructorInfo NativeCtor() =>
        typeof(TStruct).GetConstructor([typeof(XsdDurationValue)])!;
    private static ConstructorInfo StringCtor() =>
        typeof(TStruct).GetConstructor([typeof(string)])!;

    [Fact]
    public void NativeConstruction_Succeeds()
    {
        var value = new XsdDurationValue(false, 1, 2, 3, 4, 5, 6.5m);
        var instance = (TStruct)NativeCtor().Invoke([value])!;
        Assert.Equal(value, instance.Value);
    }

    [Fact]
    public void NativeConstruction_NegativeComponent_ThrowsFormatException()
    {
        var value = new XsdDurationValue(false, -1, 0, 0, 0, 0, 0);
        var ex = Assert.Throws<TargetInvocationException>(() => NativeCtor().Invoke([value]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Theory]
    [InlineData("P1Y2M3DT4H5M6.5S", false, 1, 2, 3, 4, 5, 6.5)]
    [InlineData("-P1Y", true, 1, 0, 0, 0, 0, 0)]
    [InlineData("PT1H", false, 0, 0, 0, 1, 0, 0)]
    [InlineData("P0D", false, 0, 0, 0, 0, 0, 0)]
    [InlineData("PT0S", false, 0, 0, 0, 0, 0, 0)]
    public void StringConstruction_ValidLexicalForm_Succeeds(
        string text, bool isNegative, int years, int months, int days, int hours, int minutes, double seconds)
    {
        var instance = (TStruct)StringCtor().Invoke([text])!;
        Assert.Equal(new XsdDurationValue(isNegative, years, months, days, hours, minutes, (decimal)seconds), instance.Value);
    }

    [Theory]
    [InlineData("P")]
    [InlineData("PT")]
    [InlineData("P1Y2M3D4H")] // missing 'T' before time components
    [InlineData("not-a-duration")]
    public void StringConstruction_InvalidLexicalForm_ThrowsFormatException(string text)
    {
        var ex = Assert.Throws<TargetInvocationException>(() => StringCtor().Invoke([text]));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void ToString_RoundTripsCanonicalForm()
    {
        var instance = (TStruct)StringCtor().Invoke(["P1Y2M3DT4H5M6.5S"])!;
        Assert.Equal("P1Y2M3DT4H5M6.5S", instance.ToString());
    }

    [Fact]
    public void ToString_ZeroDuration_ReturnsCanonicalP0D()
    {
        var instance = (TStruct)StringCtor().Invoke(["PT0S"])!;
        Assert.Equal("P0D", instance.ToString());
    }

    [Fact]
    public void EqualInstances_AreEqual()
    {
        var a = (TStruct)StringCtor().Invoke(["P1Y"])!;
        var b = (TStruct)StringCtor().Invoke(["P1Y"])!;
        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
    }

    [Fact]
    public void TryCreate_StringValid_ReturnsTrue()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "P1Y", null };
        Assert.True((bool)method.Invoke(null, args)!);
        Assert.NotNull(args[1]);
    }

    [Fact]
    public void TryCreate_StringInvalid_ReturnsFalse()
    {
        var method = typeof(TStruct).GetMethod(
            "TryCreate", BindingFlags.Public | BindingFlags.Static, [typeof(string), typeof(TStruct).MakeByRefType()])!;
        var args = new object?[] { "not-a-duration", null };
        Assert.False((bool)method.Invoke(null, args)!);
    }

    [Fact]
    public void JsonRoundTrip_Succeeds()
    {
        var instance = (TStruct)StringCtor().Invoke(["P1Y2M3DT4H5M6.5S"])!;
        var json = JsonSerializer.Serialize(instance, Iso20022JsonSerializerOptions.Default);
        Assert.Equal("\"P1Y2M3DT4H5M6.5S\"", json);
        var roundTripped = JsonSerializer.Deserialize<TStruct>(json, Iso20022JsonSerializerOptions.Default);
        Assert.Equal(instance, roundTripped);
    }
}

// ── Indicator (boolean true/false) contract ────────────────────────────────────

/// <summary>
/// Contract base for ISO 20022 Indicator types — boolean concepts serialized as the
/// strings <c>"true"</c> or <c>"false"</c> on the wire.
/// Adds tests for bool construction, implicit conversions, and bool equality operators.
/// </summary>
public abstract class SimpleValueIndicatorContractTests<TStruct>
    : SimpleValueStringContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    protected override string ValidSample => "true";
    protected override string InvalidSample => "maybe"; // not "true" or "false"

    // Activator.CreateInstance(Type, bool) matches the (Type, nonPublic) overload, not our
    // (bool value) constructor. Use explicit constructor lookup to avoid this trap.
    private static TStruct CreateFromBool(bool value)
    {
        var ctor = typeof(TStruct).GetConstructor([typeof(bool)])
            ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a (bool) constructor.");
        return (TStruct)ctor.Invoke([value])!;
    }

    [Fact]
    public void BoolTrue_IsAccepted()
    {
        var instance = CreateFromBool(true);
        Assert.Equal("true", instance.Value);
    }

    [Fact]
    public void BoolFalse_IsAccepted()
    {
        var instance = CreateFromBool(false);
        Assert.Equal("false", instance.Value);
    }

    [Fact]
    public void ImplicitFromBool_True_Succeeds()
    {
        var op = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "op_Implicit"
                && m.ReturnType == typeof(TStruct)
                && m.GetParameters() is [var p] && p.ParameterType == typeof(bool));
        var result = (TStruct)op.Invoke(null, [true])!;
        Assert.Equal("true", result.Value);
    }

    [Fact]
    public void ImplicitToBool_Works()
    {
        var instance = CreateFromBool(true);
        var op = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "op_Implicit"
                && m.ReturnType == typeof(bool)
                && m.GetParameters() is [var p] && p.ParameterType == typeof(TStruct));
        Assert.True((bool)op.Invoke(null, [instance])!);
    }

    [Fact]
    public void BoolEqualityOperator_Works()
    {
        var opEq = typeof(TStruct).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(m => m.Name == "op_Equality"
                && m.GetParameters() is [var p0, var p1]
                && p0.ParameterType == typeof(TStruct)
                && p1.ParameterType == typeof(bool));
        Assert.NotNull(opEq);
        var trueInstance = CreateFromBool(true);
        Assert.True((bool)opEq!.Invoke(null, [trueInstance, true])!);
        Assert.False((bool)opEq.Invoke(null, [trueInstance, false])!);
    }
}

// ── RestrictedFIN (any character, slash restriction) contract ─────────────────

/// <summary>
/// Contract base for ISO 20022 RestrictedFIN text types — any Unicode character is
/// permitted, but no leading slash, no trailing slash, and no double slash (<c>//</c>).
/// </summary>
public abstract class SimpleValueRestrictedFINSlashTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void LeadingSlash_ThrowsPatternMismatch()
    {
        var value = "/" + new string('A', MaxLength - 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void TrailingSlash_ThrowsPatternMismatch()
    {
        var value = new string('A', MaxLength - 1) + "/";
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void DoubleSlash_ThrowsPatternMismatch()
    {
        var value = "A//A" + new string('A', Math.Max(0, MaxLength - 4));
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}

// ── RestrictedFINZ (SWIFT character set Z) contract ───────────────────────────

/// <summary>
/// Contract base for ISO 20022 RestrictedFINZ text types — character set Z:
/// <c>0-9 a-z A-Z ! " % &amp; * ; &lt; &gt; SPACE . , ( ) \n \r / = ' + : ? @ # { - _</c>.
/// Adds a test verifying that characters outside set Z are rejected.
/// </summary>
public abstract class SimpleValueRestrictedFINZTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void NonZChar_ThrowsInvalidCharacter()
    {
        // '~' is outside character set Z and has valid length.
        var invalidChars = new string('~', MaxLength);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), invalidChars));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, fmt.Violation);
    }
}

// ── RestrictedFINX (SWIFT character set X) contracts ──────────────────────────

/// <summary>
/// Contract base for ISO 20022 RestrictedFINX text types — character set X:
/// <c>0-9 a-z A-Z / - ? : ( ) . , ' + SPACE</c> (some variants also permit \n \r).
/// Adds a test verifying that characters outside set X are rejected with
/// <see cref="Iso20022FormatViolation.InvalidCharacter"/>.
/// </summary>
public abstract class SimpleValueRestrictedFINXTextContractTests<TStruct>
    : SimpleValueMaxTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void NonXChar_ThrowsInvalidCharacter()
    {
        // '@' is outside character set X and has valid length.
        var invalidChars = new string('@', MaxLength);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), invalidChars));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.InvalidCharacter, fmt.Violation);
    }
}

/// <summary>
/// Contract base for RestrictedFINX types that additionally disallow a leading slash,
/// trailing slash, or double slash (<c>//</c>) within the value.
/// </summary>
public abstract class SimpleValueRestrictedFINXSlashTextContractTests<TStruct>
    : SimpleValueRestrictedFINXTextContractTests<TStruct>
    where TStruct : struct, IIsoSimpleValue<string>
{
    [Fact]
    public void LeadingSlash_ThrowsPatternMismatch()
    {
        var value = "/" + new string('A', MaxLength - 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void TrailingSlash_ThrowsPatternMismatch()
    {
        var value = new string('A', MaxLength - 1) + "/";
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void DoubleSlash_ThrowsPatternMismatch()
    {
        // "A//A..." — double slash anywhere in the value is rejected.
        var value = "A//A" + new string('A', Math.Max(0, MaxLength - 4));
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }
}

// ── External codeset contract ──────────────────────────────────────────────────

/// <summary>
/// Contract tests specific to <see cref="IIsoExternalCode"/> structs — ISO 20022 code sets
/// whose valid values are maintained in an external registry rather than the eRepository.
/// </summary>
/// <remarks>
/// Currently this level adds no test methods beyond those inherited from
/// <see cref="SimpleValueStringContractTests{TStruct}"/>. It exists as the correct seam
/// for future external-codeset-specific assertions, for example:
/// <list type="bullet">
///   <item>Verifying a constructed code appears in the live ISO 20022 external code list.</item>
///   <item>Enforcing character-set rules common to all external codes (e.g. uppercase-only)
///     that are not shared by other <c>IIsoSimpleValue&lt;string&gt;</c> types such as
///     free-text fields or identifier types.</item>
/// </list>
/// When those tests are needed, add them here rather than on individual concrete classes
/// or on the more general <see cref="SimpleValueStringContractTests{TStruct}"/>.
/// </remarks>
public abstract class ExternalCodesetContractTests<TStruct>
    : SimpleValueStringContractTests<TStruct>
    where TStruct : struct, IIsoExternalCode
{ }

// ── Meta-test: every IIsoSimpleValue<T> type must have a concrete test class ──

/// <summary>
/// Verifies that every <see cref="IIsoSimpleValue{T}"/> type in the production assembly
/// has a corresponding concrete subclass of <see cref="SimpleValueContractTests{TStruct,TValue}"/>
/// in this test assembly. Fails with the names of uncovered types.
/// </summary>
public class SimpleValueCoverageTests(ITestOutputHelper output)
{
    [Fact]
    public void AllSimpleValueTypes_HaveConcretContractTestClass()
    {
        var productionAssembly = typeof(BusinessMessagePriorityCode).Assembly;
        var testAssembly = typeof(SimpleValueCoverageTests).Assembly;

        var coveredTypes = testAssembly
            .GetTypes()
            .SelectMany(t => GetSimpleValueContractBaseTypes(t))
            .ToHashSet();

        var missing = productionAssembly
            .GetTypes()
            .Where(IsSimpleValueType)
            .Where(t => !coveredTypes.Contains(t))
            .OrderBy(t => t.FullName)
            .ToList();

        foreach (var t in missing)
            output.WriteLine(t.FullName ?? t.Name);

        Assert.True(missing.Count == 0,
            $"{missing.Count} IIsoSimpleValue<T> type(s) have no contract test class " +
            "(see output). Add a concrete subclass of SimpleValueContractTests<TStruct,TValue>.");
    }

    private static bool IsSimpleValueType(Type t)
    {
        if (!t.IsValueType || t.IsEnum)
            return false;
        return t.GetInterfaces().Any(i =>
            i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IIsoSimpleValue<>));
    }

    // Walk the inheritance chain to find all TStruct type args used in concrete subclasses.
    // Every contract-test base in this file — SimpleValueContractTests<,>,
    // SimpleValueXsdNumericContractTests<,>, SimpleValueXsdBooleanContractTests<>,
    // SimpleValueXsdFloatingPointContractTests<,>, etc. — puts the struct under test as its
    // first generic type argument by convention, so match on that rather than hard-coding one
    // specific base class (which previously left every non-string-backed contract base,
    // including the whole XSD numeric family, uncounted).
    private static IEnumerable<Type> GetSimpleValueContractBaseTypes(Type testClass)
    {
        if (testClass.IsAbstract)
            yield break;
        var b = testClass.BaseType;
        while (b is not null && b != typeof(object))
        {
            if (b.IsGenericType)
            {
                var typeArgs = b.GetGenericArguments();
                if (typeArgs.Length > 0 && IsSimpleValueType(typeArgs[0]))
                {
                    yield return typeArgs[0];
                    yield break;
                }
            }
            b = b.BaseType;
        }
    }
}
