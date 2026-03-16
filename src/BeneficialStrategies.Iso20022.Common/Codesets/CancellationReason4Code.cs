// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the request to cancel a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bYQPtNp-Ed-ak6NoX_4Aeg_-834209201")]
[Description(@"Specifies the reason for the request to cancel a payment instruction.")]
[DerivedFrom(typeof(CancellationReasonCode))]
public enum CancellationReason4Code
{
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_bYQPtdp-Ed-ak6NoX_4Aeg_-834209191")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = CancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bYQPttp-Ed-ak6NoX_4Aeg_-834209170")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = CancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_bYQPt9p-Ed-ak6NoX_4Aeg_-834209140")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = CancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bYQPuNp-Ed-ak6NoX_4Aeg_-834209109")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = CancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_bYQPudp-Ed-ak6NoX_4Aeg_-834209079")]
    [Description(@"Payment is not justified.")]
    UnduePayment = CancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as &quot;CUTA&quot;.
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_bYaAsNp-Ed-ak6NoX_4Aeg_1991989224")]
    [Description(
        @"Cancellation requested because an investigation request has been received and no remediation is possible."
    )]
    CancelUponUnableToApply = CancellationReasonCode.CancelUponUnableToApply, // same ordinal as derivation source for type conversions
}
