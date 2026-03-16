// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUYTc9p-Ed-ak6NoX_4Aeg_-165761302")]
[Description(
    @"Specifies the request used to further detail the type of information that will be queried."
)]
[Derivations(typeof(RequestType1Code), typeof(RequestType2Code))]
public enum RequestTypeCode
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as &quot;RT01&quot;.
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_ZUYTdNp-Ed-ak6NoX_4Aeg_175016931")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending,

    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as &quot;RT02&quot;.
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_ZUYTddp-Ed-ak6NoX_4Aeg_465003450")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal,

    /// <summary>
    /// Type is a request to cancellation a transaction.
    /// Encoded/decoded by serializers as &quot;RT03&quot;.
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_ZUYTdtp-Ed-ak6NoX_4Aeg_490859249")]
    [Description(@"Type is a request to cancellation a transaction.")]
    Cancellation,

    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as &quot;RT04&quot;.
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_ZUYTd9p-Ed-ak6NoX_4Aeg_506558891")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence,

    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as &quot;RT05&quot;.
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_ZUYTeNp-Ed-ak6NoX_4Aeg_524106406")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious,

    /// <summary>
    /// Type is an enquiry on the bank&apos;s position.
    /// Encoded/decoded by serializers as &quot;RT11&quot;.
    /// </summary>
    [EnumMember(Value = "RT11")]
    [IsoId("_ZUYTedp-Ed-ak6NoX_4Aeg_549966273")]
    [Description(@"Type is an enquiry on the bank's position.")]
    BankPositionEnquiry,

    /// <summary>
    /// Type is an enquiry on a specific transaction.
    /// Encoded/decoded by serializers as &quot;RT12&quot;.
    /// </summary>
    [EnumMember(Value = "RT12")]
    [IsoId("_ZUiEcNp-Ed-ak6NoX_4Aeg_579517204")]
    [Description(@"Type is an enquiry on a specific transaction.")]
    SpecificTransactionEnquiry,

    /// <summary>
    /// Type is an enquiry on a queued transaction.
    /// Encoded/decoded by serializers as &quot;RT13&quot;.
    /// </summary>
    [EnumMember(Value = "RT13")]
    [IsoId("_ZUiEcdp-Ed-ak6NoX_4Aeg_604453126")]
    [Description(@"Type is an enquiry on a queued transaction.")]
    QueuedTransactionEnquiry,

    /// <summary>
    /// Type is an enquiry on a suspicious transaction.
    /// Encoded/decoded by serializers as &quot;RT14&quot;.
    /// </summary>
    [EnumMember(Value = "RT14")]
    [IsoId("_ZUiEctp-Ed-ak6NoX_4Aeg_623847559")]
    [Description(@"Type is an enquiry on a suspicious transaction.")]
    SuspiciousTransactionEnquiry,

    /// <summary>
    /// Type is an enquiry on pending inward credits.
    /// Encoded/decoded by serializers as &quot;RT15&quot;.
    /// </summary>
    [EnumMember(Value = "RT15")]
    [IsoId("_ZUiEc9p-Ed-ak6NoX_4Aeg_650630277")]
    [Description(@"Type is an enquiry on pending inward credits.")]
    PendingInwardCreditsEnquiry,
}
