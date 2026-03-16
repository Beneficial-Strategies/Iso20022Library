// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxlM09p-Ed-ak6NoX_4Aeg_1795335735")]
[Description(@"Information about partial settlement.")]
[Derivations(typeof(PartialSettlement1Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum PartialSettlementCode
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_ZxlM1Np-Ed-ak6NoX_4Aeg_2123185009")]
    [Description(
        @"Confirmation is for partial settlement. Part of the transaction remains unsettled."
    )]
    PartialSettlement,

    /// <summary>
    /// Confirmation is for the remaining part of an instruction that was previously partially confirmed.
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_ZxlM1dp-Ed-ak6NoX_4Aeg_-1731260987")]
    [Description(
        @"Confirmation is for the remaining part of an instruction that was previously partially confirmed."
    )]
    PreviouslyPartialConfirmed,
}
