// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-oaa0ENHEeGHJ_bHJRPaIQ_1875185490")]
[Description(@"Information about partial settlement.")]
[Derivations(typeof(PartialSettlement2Code))]
public enum PartialSettlementV2Code
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_-oaa0UNHEeGHJ_bHJRPaIQ_1761346424")]
    [Description(
        @"Confirmation is for partial settlement. Part of the transaction remains unsettled."
    )]
    PartialSettlement,

    /// <summary>
    /// Confirmation is for partial settlement. No additional settlement will take place.
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_-oaa0kNHEeGHJ_bHJRPaIQ_1056231809")]
    [Description(
        @"Confirmation is for partial settlement. No additional settlement will take place."
    )]
    PartiallyConfirmed,
}
