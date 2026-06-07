// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Text.Json;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization;
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

    private static MethodInfo GetTryCreate() =>
        typeof(TStruct).GetMethod("TryCreate", BindingFlags.Public | BindingFlags.Static)
        ?? throw new InvalidOperationException($"{typeof(TStruct).Name} is missing a public static TryCreate method.");
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
        var op = typeof(TStruct).GetMethod(
            "op_Implicit",
            BindingFlags.Public | BindingFlags.Static,
            [typeof(TStruct)]);
        Assert.NotNull(op); // implicit operator string(TStruct) must exist
        var str = (string)op!.Invoke(null, [instance])!;
        Assert.Equal(ValidSample, str);
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

    // Base class samples are derived from the length constraints.
    protected override string ValidSample   => new string('A', MinLength == 0 ? 1 : MinLength);
    protected override string InvalidSample => new string('X', MaxLength + 1);

    // ── Boundary tests ─────────────────────────────────────────────────────────

    [Fact]
    public void ExactMaxLength_IsAccepted()
    {
        var value = new string('Z', MaxLength);
        var instance = Activator.CreateInstance(typeof(TStruct), value);
        Assert.NotNull(instance);
    }

    [Fact]
    public void OneOverMaxLength_ThrowsTooLong()
    {
        var over = new string('Z', MaxLength + 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), over));
        var fmt = Assert.IsType<Iso20022FormatException>(ex.InnerException);
        Assert.Equal(Iso20022FormatViolation.TooLong, fmt.Violation);
    }

    [Fact]
    public void Null_ThrowsArgumentNullException()
    {
        Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), (string)null!));
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
        var over = new string('Z', MaxLength + 1);
        var ex = Assert.Throws<TargetInvocationException>(
            () => Activator.CreateInstance(typeof(TStruct), over));
        Assert.Contains((MaxLength + 1).ToString(), ex.InnerException!.Message);
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
    where TStruct : struct, IIsoExternalCode { }

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
        if (!t.IsValueType || t.IsEnum) return false;
        return t.GetInterfaces().Any(i =>
            i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IIsoSimpleValue<>));
    }

    // Walk the inheritance chain to find all TStruct type args used in concrete subclasses.
    private static IEnumerable<Type> GetSimpleValueContractBaseTypes(Type testClass)
    {
        if (testClass.IsAbstract) yield break;
        var b = testClass.BaseType;
        while (b is not null && b != typeof(object))
        {
            if (b.IsGenericType && b.GetGenericTypeDefinition() == typeof(SimpleValueContractTests<,>))
            {
                yield return b.GetGenericArguments()[0]; // TStruct
                yield break;
            }
            b = b.BaseType;
        }
    }
}
