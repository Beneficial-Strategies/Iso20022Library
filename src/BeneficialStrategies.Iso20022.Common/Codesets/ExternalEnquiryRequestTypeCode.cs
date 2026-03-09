// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lY1lkZIgEeect698_YsnIA")]
[Description(@"Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalEnquiryRequestType1Code))]
public enum ExternalEnquiryRequestTypeCode
{
    /// <summary>
    /// Type is an enquiry on the bank&apos;s position.
    /// Encoded/decoded by serializers as &quot;RT11&quot;.
    /// </summary>
    [EnumMember(Value = "RT11")]
    [IsoId("_ud444PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on the bank's position.")]
    BankPositionEnquiry,
    
    /// <summary>
    /// Type is an enquiry on a specific transaction.
    /// Encoded/decoded by serializers as &quot;RT12&quot;.
    /// </summary>
    [EnumMember(Value = "RT12")]
    [IsoId("_ud444_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a specific transaction.")]
    SpecificTransactionEnquiry,
    
    /// <summary>
    /// Type is an enquiry on a queued transaction.
    /// Encoded/decoded by serializers as &quot;RT13&quot;.
    /// </summary>
    [EnumMember(Value = "RT13")]
    [IsoId("_ueCp4PRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a queued transaction.")]
    QueuedTransactionEnquiry,
    
    /// <summary>
    /// Type is an enquiry on a suspicious transaction.
    /// Encoded/decoded by serializers as &quot;RT14&quot;.
    /// </summary>
    [EnumMember(Value = "RT14")]
    [IsoId("_ueCp4_RYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on a suspicious transaction.")]
    SuspiciousTransactionEnquiry,
    
    /// <summary>
    /// Type is an enquiry on the system date and/or time.
    /// Encoded/decoded by serializers as &quot;RT16&quot;.
    /// </summary>
    [EnumMember(Value = "RT16")]
    [IsoId("_ueCp5vRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on the system date and/or time.")]
    SytemTimeEnquiry,
    
    /// <summary>
    /// Type is an enquiry on pending inward credits.
    /// Encoded/decoded by serializers as &quot;RT15&quot;.
    /// </summary>
    [EnumMember(Value = "RT15")]
    [IsoId("_ueCp6fRYEeuLhpyIdtJzwg")]
    [Description(@"Type is an enquiry on pending inward credits.")]
    PendingInwardCreditsEnquiry,
    
}
