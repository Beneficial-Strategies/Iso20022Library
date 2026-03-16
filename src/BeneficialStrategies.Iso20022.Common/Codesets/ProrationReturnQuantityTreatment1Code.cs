// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates how prorated instructions will be handled when the prorated entitlement results in less than the minimum denomination.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2bAEIHGzEe6S2Llv74R19w")]
[Description(
    @"Indicates how prorated instructions will be handled when the prorated entitlement results in less than the minimum denomination."
)]
[DerivedFrom(typeof(ProrationReturnQuantityTreatmentCode))]
public enum ProrationReturnQuantityTreatment1Code
{
    /// <summary>
    /// Prorated instructions which result in less than the minimum denominations will be accepted in full.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("")]
    [Description(
        @"Prorated instructions which result in less than the minimum denominations will be accepted in full."
    )]
    Accept = ProrationReturnQuantityTreatmentCode.Accept, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Prorated instructions which result in less than the minimum denominations will be adjusted up.
    /// Encoded/decoded by serializers as &quot;ADJT&quot;.
    /// </summary>
    [EnumMember(Value = "ADJT")]
    [IsoId("")]
    [Description(
        @"Prorated instructions which result in less than the minimum denominations will be adjusted up."
    )]
    Adjust = ProrationReturnQuantityTreatmentCode.Adjust, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Prorated instructions which result in less than the minimum denominations will be rejected in full.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("")]
    [Description(
        @"Prorated instructions which result in less than the minimum denominations will be rejected in full."
    )]
    Reject = ProrationReturnQuantityTreatmentCode.Reject, // same ordinal as derivation source for type conversions
}
