// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-8cBfwLEeGHDMP28rpT3g_-2028738047")]
[Description(
    @"Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately."
)]
[DerivedFrom(typeof(ExternalRePresentmentReasonCode))]
public enum ExternalRePresentmentReason1Code
{
    /// <summary>
    /// Amount corrected due to proof of transaction
    /// Encoded/decoded by serializers as &quot;AMCR&quot;.
    /// </summary>
    [EnumMember(Value = "AMCR")]
    [IsoId("_uOP6a_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount corrected due to proof of transaction")]
    AmountCorrected = ExternalRePresentmentReasonCode.AmountCorrected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Liability Shift to acquirer due to missing card authentication method denied
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_uOZEUvRYEeuLhpyIdtJzwg")]
    [Description(@"Liability Shift to acquirer due to missing card authentication method denied")]
    CardAuthenticationLiabilityShiftDenied =
        ExternalRePresentmentReasonCode.CardAuthenticationLiabilityShiftDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit previously issued
    /// Encoded/decoded by serializers as &quot;CRPI&quot;.
    /// </summary>
    [EnumMember(Value = "CRPI")]
    [IsoId("_uOZEVfRYEeuLhpyIdtJzwg")]
    [Description(@"Credit previously issued")]
    CreditPreviouslyIssued = ExternalRePresentmentReasonCode.CreditPreviouslyIssued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original transaction was valid
    /// Encoded/decoded by serializers as &quot;OTVA&quot;.
    /// </summary>
    [EnumMember(Value = "OTVA")]
    [IsoId("_uOZEWPRYEeuLhpyIdtJzwg")]
    [Description(@"Original transaction was valid")]
    OriginalTransactionValid = ExternalRePresentmentReasonCode.OriginalTransactionValid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Liability Shift to acquirer due to missing cardholder verification method denied
    /// Encoded/decoded by serializers as &quot;VLSD&quot;.
    /// </summary>
    [EnumMember(Value = "VLSD")]
    [IsoId("_uOZEW_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Liability Shift to acquirer due to missing cardholder verification method denied"
    )]
    VerificationLiabilityShiftDenied =
        ExternalRePresentmentReasonCode.VerificationLiabilityShiftDenied, // same ordinal as derivation source for type conversions
}
