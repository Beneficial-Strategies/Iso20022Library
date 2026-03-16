// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is eligible for netting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ0Ipdp-Ed-ak6NoX_4Aeg_-1067297210")]
[Description(@"Specifies whether the trade is eligible for netting.")]
[Derivations(typeof(NettingEligible1Code))]
public enum NettingEligibleCode
{
    /// <summary>
    /// Indicates that the trade is not eligible for settlement netting.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YZ0Iptp-Ed-ak6NoX_4Aeg_-104590487")]
    [Description(@"Indicates that the trade is not eligible for settlement netting.")]
    Gross,

    /// <summary>
    /// Indicates that the trade is eligible for settlement netting.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_YZ0Ip9p-Ed-ak6NoX_4Aeg_2047176134")]
    [Description(@"Indicates that the trade is eligible for settlement netting.")]
    Nett,

    /// <summary>
    /// Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation.
    /// Encoded/decoded by serializers as &quot;AGFS&quot;.
    /// </summary>
    [EnumMember(Value = "AGFS")]
    [IsoId("_YZ0IqNp-Ed-ak6NoX_4Aeg_-674500416")]
    [Description(
        @"Grouping of receipts/purchases to create one settlement obligation, and the grouping of deliveries/sales to create one settlement obligation."
    )]
    AggregationForSettlement,
}
