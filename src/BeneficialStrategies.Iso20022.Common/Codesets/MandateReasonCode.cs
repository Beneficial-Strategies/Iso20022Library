// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the amendment or cancellation of a mandate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_af7gkNp-Ed-ak6NoX_4Aeg_-586944687")]
[Description(@"Specifies the reason for requesting the amendment or cancellation of a mandate.")]
[Derivations(typeof(MandateAmendmentReason1Code), typeof(MandateCancellationReason1Code))]
public enum MandateReasonCode
{
    /// <summary>
    /// Agent details are incorrect or have changed.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_af7gkdp-Ed-ak6NoX_4Aeg_-1939942868")]
    [Description(@"Agent details are incorrect or have changed.")]
    IncorrectAgent,

    /// <summary>
    /// Currency for the mandate is incorrect or has changed.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_af7gktp-Ed-ak6NoX_4Aeg_-1939942867")]
    [Description(@"Currency for the mandate is incorrect or has changed.")]
    IncorrectCurrency,

    /// <summary>
    /// Customer requested the change.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_af7gk9p-Ed-ak6NoX_4Aeg_-1939942838")]
    [Description(@"Customer requested the change.")]
    RequestedByCustomer,

    /// <summary>
    /// Insufficient or incoherent details about the debtor.
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_af7glNp-Ed-ak6NoX_4Aeg_-1939942807")]
    [Description(@"Insufficient or incoherent details about the debtor.")]
    InsufficientDebtorDetails,

    /// <summary>
    /// Insufficient or incoherent details about the creditor.
    /// Encoded/decoded by serializers as &quot;CDTR&quot;.
    /// </summary>
    [EnumMember(Value = "CDTR")]
    [IsoId("_af7gldp-Ed-ak6NoX_4Aeg_-1939942776")]
    [Description(@"Insufficient or incoherent details about the creditor.")]
    InsufficientCreditorDetails,

    /// <summary>
    /// Account details are not correct.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_af7gltp-Ed-ak6NoX_4Aeg_-2096018319")]
    [Description(@"Account details are not correct.")]
    IncorrectAccount,
}
