// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a pending account opening status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uBUPAGCKEeabZtzjEVWYCQ")]
[Description(@"Specifies the reason for a pending account opening status.")]
[DerivedFrom(typeof(PendingOpeningStatusReasonCode))]
public enum PendingOpeningStatusReason1Code
{
    /// <summary>
    /// Authorisation is required.
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_vgrwAWCKEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is required.")]
    Authorisation = PendingOpeningStatusReasonCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authorisation is provided but account opening is still pending.
    /// Encoded/decoded by serializers as &quot;ATHP&quot;.
    /// </summary>
    [EnumMember(Value = "ATHP")]
    [IsoId("_vqNfcWCKEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is provided but account opening is still pending.")]
    AuthorisedButPending = PendingOpeningStatusReasonCode.AuthorisedButPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FATCA reporting date is missing.
    /// Encoded/decoded by serializers as &quot;FRDM&quot;.
    /// </summary>
    [EnumMember(Value = "FRDM")]
    [IsoId("_vz4Y0WCKEeabZtzjEVWYCQ")]
    [Description(@"FATCA reporting date is missing.")]
    FATCAReportingDateMissing = PendingOpeningStatusReasonCode.FATCAReportingDateMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Know Your Customer (KYC) document is missing.
    /// Encoded/decoded by serializers as &quot;KYCM&quot;.
    /// </summary>
    [EnumMember(Value = "KYCM")]
    [IsoId("_v9PwMWCKEeabZtzjEVWYCQ")]
    [Description(@"Know Your Customer (KYC) document is missing.")]
    KnowYourCustomerDocumentMissing =
        PendingOpeningStatusReasonCode.KnowYourCustomerDocumentMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is not yet open, even for partial use.
    /// Encoded/decoded by serializers as &quot;NOTO&quot;.
    /// </summary>
    [EnumMember(Value = "NOTO")]
    [IsoId("_wG6pkWCKEeabZtzjEVWYCQ")]
    [Description(@"Account is not yet open, even for partial use.")]
    NotOpened = PendingOpeningStatusReasonCode.NotOpened, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account will be opened when restrictions are addressed.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_wQJeEWCKEeabZtzjEVWYCQ")]
    [Description(@"Account will be opened when restrictions are addressed.")]
    Restrictions = PendingOpeningStatusReasonCode.Restrictions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights holder information is missing.
    /// Encoded/decoded by serializers as &quot;RIGH&quot;.
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_wZ0XcWCKEeabZtzjEVWYCQ")]
    [Description(@"Rights holder information is missing.")]
    RightsHolderMissing = PendingOpeningStatusReasonCode.RightsHolderMissing, // same ordinal as derivation source for type conversions
}
