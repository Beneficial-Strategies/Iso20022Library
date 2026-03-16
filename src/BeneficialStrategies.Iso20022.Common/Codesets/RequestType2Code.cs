// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUOidtp-Ed-ak6NoX_4Aeg_-957935555")]
[Description(
    @"Specifies the request used to further detail the type of information that will be queried."
)]
[DerivedFrom(typeof(RequestTypeCode))]
public enum RequestType2Code
{
    /// <summary>
    /// Type is an enquiry on the bank&apos;s position.
    /// Encoded/decoded by serializers as &quot;RT11&quot;.
    /// </summary>
    [EnumMember(Value = "RT11")]
    [IsoId("_ZUOid9p-Ed-ak6NoX_4Aeg_-957935410")]
    [Description(@"Type is an enquiry on the bank's position.")]
    BankPositionEnquiry = RequestTypeCode.BankPositionEnquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is an enquiry on a specific transaction.
    /// Encoded/decoded by serializers as &quot;RT12&quot;.
    /// </summary>
    [EnumMember(Value = "RT12")]
    [IsoId("_ZUOieNp-Ed-ak6NoX_4Aeg_-957935409")]
    [Description(@"Type is an enquiry on a specific transaction.")]
    SpecificTransactionEnquiry = RequestTypeCode.SpecificTransactionEnquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is an enquiry on a queued transaction.
    /// Encoded/decoded by serializers as &quot;RT13&quot;.
    /// </summary>
    [EnumMember(Value = "RT13")]
    [IsoId("_ZUYTcNp-Ed-ak6NoX_4Aeg_-957935132")]
    [Description(@"Type is an enquiry on a queued transaction.")]
    QueuedTransactionEnquiry = RequestTypeCode.QueuedTransactionEnquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is an enquiry on a suspicious transaction.
    /// Encoded/decoded by serializers as &quot;RT14&quot;.
    /// </summary>
    [EnumMember(Value = "RT14")]
    [IsoId("_ZUYTcdp-Ed-ak6NoX_4Aeg_-957935131")]
    [Description(@"Type is an enquiry on a suspicious transaction.")]
    SuspiciousTransactionEnquiry = RequestTypeCode.SuspiciousTransactionEnquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type is an enquiry on pending inward credits.
    /// Encoded/decoded by serializers as &quot;RT15&quot;.
    /// </summary>
    [EnumMember(Value = "RT15")]
    [IsoId("_ZUYTctp-Ed-ak6NoX_4Aeg_-957935101")]
    [Description(@"Type is an enquiry on pending inward credits.")]
    PendingInwardCreditsEnquiry = RequestTypeCode.PendingInwardCreditsEnquiry, // same ordinal as derivation source for type conversions
}
