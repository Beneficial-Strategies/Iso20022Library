// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y8sMONp-Ed-ak6NoX_4Aeg_2013656213")]
[Description(
    @"Indicates the status of a single payment transaction or of a group of payment transactions."
)]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum ValidationGroupStatus2Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Y81WINp-Ed-ak6NoX_4Aeg_2013656215")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation = PaymentStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Y81WIdp-Ed-ak6NoX_4Aeg_2013656244")]
    [Description(
        @"Preceding check of technical validation was successful. Customer profile check was also successful."
    )]
    AcceptedCustomerProfile = PaymentStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_Y81WItp-Ed-ak6NoX_4Aeg_2013656245")]
    [Description(
        @"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution."
    )]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_Y81WI9p-Ed-ak6NoX_4Aeg_2013656492")]
    [Description(
        @"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement"
    )]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_Y81WJNp-Ed-ak6NoX_4Aeg_2013656522")]
    [Description(
        @"Instruction is accepted but a change will be made, such as date or remittance not sent."
    )]
    AcceptedWithChange = PaymentStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Y81WJdp-Ed-ak6NoX_4Aeg_2013656553")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed."
    )]
    Pending = PaymentStatusCode.Pending, // same ordinal as derivation source for type conversions
}
