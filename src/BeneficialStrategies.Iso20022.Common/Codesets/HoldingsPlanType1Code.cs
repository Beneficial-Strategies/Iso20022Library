// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the holdings plan of the assets to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_15H24PuzEeC3VvXpH76gow")]
[Description(@"Specifies the holdings plan of the assets to transfer.")]
[DerivedFrom(typeof(HoldingsPlanTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<HoldingsPlanType1Code>))]
#endif
public enum HoldingsPlanType1Code
{
    /// <summary>
    /// Holding to be transferred belongs to an investment plan.
    /// Encoded/decoded by serializers as &quot;INVP&quot;.
    /// </summary>
    [EnumMember(Value = "INVP")]
    [IsoId("_HrnWjv81EeC-e_lDNJKWcg")]
    [Description(@"Holding to be transferred belongs to an investment plan.")]
    InvestmentPlan = HoldingsPlanTypeCode.InvestmentPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding to be transferred belongs to a switch plan.
    /// Encoded/decoded by serializers as &quot;SWIP&quot;.
    /// </summary>
    [EnumMember(Value = "SWIP")]
    [IsoId("_H1dPBv81EeC-e_lDNJKWcg")]
    [Description(@"Holding to be transferred belongs to a switch plan.")]
    SwitchPlan = HoldingsPlanTypeCode.SwitchPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding to be transferred belongs to a withdrawal plan.
    /// Encoded/decoded by serializers as &quot;PLAR&quot;.
    /// </summary>
    [EnumMember(Value = "PLAR")]
    [IsoId("_H5LRbv81EeC-e_lDNJKWcg")]
    [Description(@"Holding to be transferred belongs to a withdrawal plan.")]
    WithdrawalPlan = HoldingsPlanTypeCode.WithdrawalPlan, // same ordinal as derivation source for type conversions
}
