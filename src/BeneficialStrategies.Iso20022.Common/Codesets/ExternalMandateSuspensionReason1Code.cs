// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_z3ff4YPDEeahmOIR_zFG6A")]
[Description(
    @"Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMandateSuspensionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalMandateSuspensionReason1Code>))]
#endif
public enum ExternalMandateSuspensionReason1Code
{
    /// <summary>
    /// Mandate suspended due to amendment of the contract.
    /// Encoded/decoded by serializers as &quot;CTAM&quot;.
    /// </summary>
    [EnumMember(Value = "CTAM")]
    [IsoId("_uY0ytfRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended due to amendment of the contract.")]
    ContractAmended = ExternalMandateSuspensionReasonCode.ContractAmended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate suspended due to cancellation of the contract, requested by the debtor.
    /// Encoded/decoded by serializers as &quot;CTCA&quot;.
    /// </summary>
    [EnumMember(Value = "CTCA")]
    [IsoId("_uY98ovRYEeuLhpyIdtJzwg")]
    [Description(
        @"Mandate suspended due to cancellation of the contract, requested by the debtor."
    )]
    ContractCancellationInitiatedByDebtor =
        ExternalMandateSuspensionReasonCode.ContractCancellationInitiatedByDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate suspended due to the contract that expired.
    /// Encoded/decoded by serializers as &quot;CTEX&quot;.
    /// </summary>
    [EnumMember(Value = "CTEX")]
    [IsoId("_uY98pfRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended due to the contract that expired.")]
    ContractExpired = ExternalMandateSuspensionReasonCode.ContractExpired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate suspended as final collection took place.
    /// Encoded/decoded by serializers as &quot;MCFC&quot;.
    /// </summary>
    [EnumMember(Value = "MCFC")]
    [IsoId("_uY98qPRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended as final collection took place.")]
    MandateSuspendedFinalCollection =
        ExternalMandateSuspensionReasonCode.MandateSuspendedFinalCollection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate suspended as the once off collection took place.
    /// Encoded/decoded by serializers as &quot;MCOC&quot;.
    /// </summary>
    [EnumMember(Value = "MCOC")]
    [IsoId("_uY98q_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended as the once off collection took place.")]
    MandateSuspendedOnceOffCollection =
        ExternalMandateSuspensionReasonCode.MandateSuspendedOnceOffCollection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate suspended after 7 consecutive unsuccessful collections.
    /// Encoded/decoded by serializers as &quot;MSUC&quot;.
    /// </summary>
    [EnumMember(Value = "MSUC")]
    [IsoId("_uY98rvRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended after 7 consecutive unsuccessful collections.")]
    MandateSuspended7ConsecutiveUnsuccessfulCollections =
        ExternalMandateSuspensionReasonCode.MandateSuspended7ConsecutiveUnsuccessfulCollections, // same ordinal as derivation source for type conversions
}
