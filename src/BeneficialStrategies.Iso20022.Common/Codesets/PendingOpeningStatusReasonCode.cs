// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a pending account opening status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9mMHkGCJEeabZtzjEVWYCQ")]
[Description(@"Specifies the reason for a pending account opening status.")]
[Derivations(typeof(PendingOpeningStatusReason1Code))]
public enum PendingOpeningStatusReasonCode
{
    /// <summary>
    /// Know Your Customer (KYC) document is missing.
    /// Encoded/decoded by serializers as &quot;KYCM&quot;.
    /// </summary>
    [EnumMember(Value = "KYCM")]
    [IsoId("_Qr7pYGCKEeabZtzjEVWYCQ")]
    [Description(@"Know Your Customer (KYC) document is missing.")]
    KnowYourCustomerDocumentMissing,
    
    /// <summary>
    /// FATCA reporting date is missing.
    /// Encoded/decoded by serializers as &quot;FRDM&quot;.
    /// </summary>
    [EnumMember(Value = "FRDM")]
    [IsoId("_WX-mMGCKEeabZtzjEVWYCQ")]
    [Description(@"FATCA reporting date is missing.")]
    FATCAReportingDateMissing,
    
    /// <summary>
    /// Rights holder information is missing.
    /// Encoded/decoded by serializers as &quot;RIGH&quot;.
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_Y_DWIGCKEeabZtzjEVWYCQ")]
    [Description(@"Rights holder information is missing.")]
    RightsHolderMissing,
    
    /// <summary>
    /// Authorisation is required.
    /// Encoded/decoded by serializers as &quot;ATHR&quot;.
    /// </summary>
    [EnumMember(Value = "ATHR")]
    [IsoId("_b7QokGCKEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is required.")]
    Authorisation,
    
    /// <summary>
    /// Authorisation is provided but account opening is still pending.
    /// Encoded/decoded by serializers as &quot;ATHP&quot;.
    /// </summary>
    [EnumMember(Value = "ATHP")]
    [IsoId("_ej9wMGCKEeabZtzjEVWYCQ")]
    [Description(@"Authorisation is provided but account opening is still pending.")]
    AuthorisedButPending,
    
    /// <summary>
    /// Account is not yet open, even for partial use.
    /// Encoded/decoded by serializers as &quot;NOTO&quot;.
    /// </summary>
    [EnumMember(Value = "NOTO")]
    [IsoId("_h9epsGCKEeabZtzjEVWYCQ")]
    [Description(@"Account is not yet open, even for partial use.")]
    NotOpened,
    
    /// <summary>
    /// Account will be opened when restrictions are addressed.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_mxl48GCKEeabZtzjEVWYCQ")]
    [Description(@"Account will be opened when restrictions are addressed.")]
    Restrictions,
    
}
