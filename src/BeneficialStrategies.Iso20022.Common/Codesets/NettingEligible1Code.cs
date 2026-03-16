// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is eligible for netting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ0Iodp-Ed-ak6NoX_4Aeg_1300222937")]
[Description(@"Specifies whether the trade is eligible for netting.")]
[DerivedFrom(typeof(NettingEligibleCode))]
public enum NettingEligible1Code
{
    /// <summary>
    /// Indicates that the trade is not eligible for settlement netting.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YZ0Iotp-Ed-ak6NoX_4Aeg_1462352468")]
    [Description(@"Indicates that the trade is not eligible for settlement netting.")]
    Gross = NettingEligibleCode.Gross, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the trade is eligible for settlement netting.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_YZ0Io9p-Ed-ak6NoX_4Aeg_-895389655")]
    [Description(@"Indicates that the trade is eligible for settlement netting.")]
    Nett = NettingEligibleCode.Nett, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation.
    /// Encoded/decoded by serializers as &quot;AGFS&quot;.
    /// </summary>
    [EnumMember(Value = "AGFS")]
    [IsoId("_YZ0IpNp-Ed-ak6NoX_4Aeg_2048299494")]
    [Description(
        @"Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation."
    )]
    AggregationForSettlement = NettingEligibleCode.AggregationForSettlement, // same ordinal as derivation source for type conversions
}
