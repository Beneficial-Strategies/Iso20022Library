// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxlM0Np-Ed-ak6NoX_4Aeg_1725602440")]
[Description(@"Information about partial settlement.")]
[DerivedFrom(typeof(PartialSettlementCode))]
public enum PartialSettlement1Code
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_ZxlM0dp-Ed-ak6NoX_4Aeg_-145694704")]
    [Description(
        @"Confirmation is for partial settlement. Part of the transaction remains unsettled."
    )]
    PartialSettlement = PartialSettlementCode.PartialSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation is for the remaining part of an instruction that was previously partially confirmed.
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_ZxlM0tp-Ed-ak6NoX_4Aeg_-145694679")]
    [Description(
        @"Confirmation is for the remaining part of an instruction that was previously partially confirmed."
    )]
    PreviouslyPartialConfirmed = PartialSettlementCode.PreviouslyPartialConfirmed, // same ordinal as derivation source for type conversions
}
