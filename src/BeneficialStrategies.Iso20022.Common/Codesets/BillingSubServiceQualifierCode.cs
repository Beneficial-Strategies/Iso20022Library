// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the content of the subservice code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WqIoZqlEeGSON8vddiWzQ_-379883890")]
[Description(@"Qualifies the content of the subservice code.")]
[Derivations(typeof(BillingSubServiceQualifier1Code))]
public enum BillingSubServiceQualifierCode
{
    /// <summary>
    /// Subservice code contains a lockbox number which identifies the lockbox using the service.
    /// Encoded/decoded by serializers as &quot;LBOX&quot;.
    /// </summary>
    [EnumMember(Value = "LBOX")]
    [IsoId("_6WqIopqlEeGSON8vddiWzQ_1477365777")]
    [Description(@"Subservice code contains a lockbox number which identifies the lockbox using the service.")]
    Lockbox,
    
    /// <summary>
    /// Subservice code contains a store number which identifies the store using the service.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_6WqIo5qlEeGSON8vddiWzQ_999391067")]
    [Description(@"Subservice code contains a store number which identifies the store using the service.")]
    Store,
    
    /// <summary>
    /// Meaning of the subservice code is established by the trading partners.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_6WqIpJqlEeGSON8vddiWzQ_-769215275")]
    [Description(@"Meaning of the subservice code is established by the trading partners.")]
    BilaterallyAgreed,
    
    /// <summary>
    /// Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement.
    /// Encoded/decoded by serializers as &quot;SEQN&quot;.
    /// </summary>
    [EnumMember(Value = "SEQN")]
    [IsoId("_6WqIpZqlEeGSON8vddiWzQ_-436014445")]
    [Description(@"Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement.")]
    SequenceNumber,
    
    /// <summary>
    /// Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement.
    /// Encoded/decoded by serializers as &quot;MACT&quot;.
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_6WqIppqlEeGSON8vddiWzQ_1142554083")]
    [Description(@"Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement.")]
    MemberAccount,
    
}
