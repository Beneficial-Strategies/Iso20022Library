// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.CompilerServices;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.SimpleTypes;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Metadata;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// <see cref="Iso.KindOf(Type)"/>: every model type has exactly one kind, and a type that is not a model type has none.
/// </summary>
public class IsoKindTests
{
    // Not model types: the decomposed value an XsdDuration holds.
    private static readonly Type[] SupportTypes = [typeof(XsdDurationValue)];

    private static readonly Type[] PrimitivesTypes = typeof(Max35Text)
        .Assembly.GetTypes()
        .Where(t => t.IsPublic && !Attribute.IsDefined(t, typeof(CompilerGeneratedAttribute)) && !SupportTypes.Contains(t))
        .ToArray();

    private static IEnumerable<Type> In(string ns) => PrimitivesTypes.Where(t => t.Namespace == ns);

    private static void AssertKinds(IEnumerable<Type> types, Func<Type, IsoKind?> expected)
    {
        var wrong = string.Join(
            Environment.NewLine,
            types.Where(t => Iso.KindOf(t) != expected(t)).Select(t => $"{t.FullName}: {Iso.KindOf(t)?.ToString() ?? "none"}")
        );
        Assert.True(wrong.Length == 0, "Types with another kind than expected:" + Environment.NewLine + wrong);
    }

    [Fact]
    public void SimpleTypes_AreSimpleTypes() => AssertKinds(In("BeneficialStrategies.Iso20022.SimpleTypes"), _ => IsoKind.SimpleType);

    [Fact]
    public void Codesets_AreCodeSetsOrExternalCodes() =>
        AssertKinds(In("BeneficialStrategies.Iso20022.Codesets"), t => t.IsEnum ? IsoKind.CodeSet : IsoKind.ExternalCode);

    [Fact]
    public void Amounts_AreAmounts() => AssertKinds(In("BeneficialStrategies.Iso20022.Amounts"), _ => IsoKind.Amount);

    [Fact]
    public void OpenContentMarkers_AreOpenContent() =>
        AssertKinds(
            In("BeneficialStrategies.Iso20022.ExternalSchema").Concat(In("BeneficialStrategies.Iso20022.UserDefined")),
            _ => IsoKind.OpenContent
        );

    [Fact]
    public void TheModelFoldersAreNotEmpty()
    {
        // guards against the namespace names above silently matching nothing
        Assert.True(In("BeneficialStrategies.Iso20022.SimpleTypes").Count() > 300);
        Assert.True(In("BeneficialStrategies.Iso20022.Codesets").Count() > 4000);
        Assert.True(In("BeneficialStrategies.Iso20022.Amounts").Count() == 17);
        Assert.Equal(14, In("BeneficialStrategies.Iso20022.ExternalSchema").Count() + In("BeneficialStrategies.Iso20022.UserDefined").Count());
    }

    [Theory]
    [InlineData(typeof(string))]
    [InlineData(typeof(DayOfWeek))] // an enum without an [IsoId] is not a code set
    [InlineData(typeof(Iso20022FormatException))]
    [InlineData(typeof(IsoIdAttribute))]
    public void ATypeThatIsNotAModelType_HasNoKind(Type type) => Assert.Null(Iso.KindOf(type));

    private sealed class AMessage : IOuterRecord { }

    private interface IAComponent : IIsoComponent { }

    private interface IAChoice : IIsoChoice { }

    private interface IAVariant : IAChoice, IIsoChoiceVariant { }

    private sealed class AVariantImplementation : IAVariant { }

    private sealed class AComponentImplementation : IAComponent { }

    [Fact]
    public void Markers_DecideTheKindOfMessagesComponentsAndChoices()
    {
        Assert.Equal(IsoKind.Message, Iso.KindOf<AMessage>());
        Assert.Equal(IsoKind.Component, Iso.KindOf<AComponentImplementation>());
        Assert.Equal(IsoKind.Component, Iso.KindOf<IAComponent>());
        Assert.Equal(IsoKind.Choice, Iso.KindOf<IAChoice>());
    }

    [Fact]
    public void AVariant_IsToldFromItsChoice()
    {
        // a variant interface derives from its choice's interface, so the narrower marker wins
        Assert.Equal(IsoKind.ChoiceVariant, Iso.KindOf<IAVariant>());
        Assert.Equal(IsoKind.ChoiceVariant, Iso.KindOf<AVariantImplementation>());
    }

    [Fact]
    public void AnExternalCode_IsNotReportedAsASimpleType()
    {
        Assert.True(typeof(IIsoSimpleType).IsAssignableFrom(typeof(ActiveCurrencyCode)));
        Assert.Equal(IsoKind.ExternalCode, Iso.KindOf<ActiveCurrencyCode>());
        Assert.Equal(IsoKind.SimpleType, Iso.KindOf<Max35Text>());
        Assert.Equal(IsoKind.Amount, Iso.KindOf<ActiveCurrencyAndAmount>());
    }
}
