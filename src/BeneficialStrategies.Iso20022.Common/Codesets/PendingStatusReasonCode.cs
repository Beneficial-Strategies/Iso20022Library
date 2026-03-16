// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fBiHsGBjEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for a pending status.")]
[Derivations(typeof(PendingStatusReason1Code))]
public enum PendingStatusReasonCode
{
    /// <summary>
    /// Know Your Customer (KYC) document is missing.
    /// Encoded/decoded by serializers as &quot;KYCM&quot;.
    /// </summary>
    [EnumMember(Value = "KYCM")]
    [IsoId("_kceGYGBjEeaR1OOiVxm3Gg")]
    [Description(@"Know Your Customer (KYC) document is missing.")]
    KnowYourCustomerDocumentMissing,

    /// <summary>
    /// FATCA reporting date is missing.
    /// Encoded/decoded by serializers as &quot;FRDM&quot;.
    /// </summary>
    [EnumMember(Value = "FRDM")]
    [IsoId("_kh1HgGBjEeaR1OOiVxm3Gg")]
    [Description(@"FATCA reporting date is missing.")]
    FATCAReportingDateMissing,

    /// <summary>
    /// Rights holder information is missing.
    /// Encoded/decoded by serializers as &quot;RIGH&quot;.
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_kmvcsGBjEeaR1OOiVxm3Gg")]
    [Description(@"Rights holder information is missing.")]
    RightsHolderMissing,

    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_CXskMGCJEeabZtzjEVWYCQ")]
    [Description(@"Modification to the account data is in process.")]
    ModificationInProcess,

    /// <summary>
    /// Authorisation is required.
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_GOhEwGCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is required.")]
    Authorisation,

    /// <summary>
    /// Authorisation is provided but the account change is still pending.
    /// Encoded/decoded by serializers as &quot;ATHP&quot;.
    /// </summary>
    [EnumMember(Value = "ATHP")]
    [IsoId("_IzzE8GCJEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is provided but the account change is still pending.")]
    AuthorisedButPending,
}
