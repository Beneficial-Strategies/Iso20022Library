// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Service provided by a card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWPA4QEcEeCQm6a_G2yO_w_1358541194")]
[Description(@"Service provided by a card payment transaction.")]
[Derivations(
    typeof(CardPaymentServiceType5Code),
    typeof(CardPaymentServiceType1Code),
    typeof(CardPaymentServiceType10Code),
    typeof(CardPaymentServiceType7Code),
    typeof(CardPaymentServiceType2Code),
    typeof(CardPaymentServiceType12Code),
    typeof(CardPaymentServiceType4Code),
    typeof(CardPaymentServiceType14Code),
    typeof(CardPaymentServiceType6Code),
    typeof(CardPaymentServiceType13Code),
    typeof(CardPaymentServiceType3Code),
    typeof(CardPaymentServiceType9Code),
    typeof(CardPaymentServiceType8Code)
)]
public enum CardPaymentServiceTypeCode
{
    /// <summary>
    /// Transfer of funds to and/or from a card account.
    /// Encoded/decoded by serializers as &quot;CAFT&quot;.
    /// </summary>
    [EnumMember(Value = "CAFT")]
    [IsoId("_TWYx0AEcEeCQm6a_G2yO_w_-888323146")]
    [Description(@"Transfer of funds to and/or from a card account.")]
    CardsFundTransfer,

    /// <summary>
    /// Original credit.
    /// Encoded/decoded by serializers as &quot;ORCR&quot;.
    /// </summary>
    [EnumMember(Value = "ORCR")]
    [IsoId("_TWYx0QEcEeCQm6a_G2yO_w_1808582617")]
    [Description(@"Original credit.")]
    OriginalCredit,

    /// <summary>
    /// Card payment.
    /// Encoded/decoded by serializers as &quot;CRDP&quot;.
    /// </summary>
    [EnumMember(Value = "CRDP")]
    [IsoId("_TWYx0gEcEeCQm6a_G2yO_w_-1097928526")]
    [Description(@"Card payment.")]
    CardPayment,

    /// <summary>
    /// Card payment with cash-back.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_TWYx0wEcEeCQm6a_G2yO_w_364096312")]
    [Description(@"Card payment with cash-back.")]
    CashBack,

    /// <summary>
    /// Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter.
    /// Encoded/decoded by serializers as &quot;CSHW&quot;.
    /// </summary>
    [EnumMember(Value = "CSHW")]
    [IsoId("_TWYx1AEcEeCQm6a_G2yO_w_-117301862")]
    [Description(
        @"Cash advance or withdrawals on a POI (Point Of Interaction), or at a bank counter."
    )]
    CashAdvance,

    /// <summary>
    /// Cash deposit.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_TWYx1QEcEeCQm6a_G2yO_w_329601214")]
    [Description(@"Cash deposit.")]
    CashDeposit,

    /// <summary>
    /// Deferred payment.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_TWYx1gEcEeCQm6a_G2yO_w_-851262795")]
    [Description(@"Deferred payment.")]
    DeferredPayment,

    /// <summary>
    /// Reservation (pre-authorisation).
    /// Encoded/decoded by serializers as &quot;RESA&quot;.
    /// </summary>
    [EnumMember(Value = "RESA")]
    [IsoId("_TWYx1wEcEeCQm6a_G2yO_w_-586534932")]
    [Description(@"Reservation (pre-authorisation).")]
    Reservation,

    /// <summary>
    /// Loading or reloading non-financial account.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_TWYx2AEcEeCQm6a_G2yO_w_837530432")]
    [Description(@"Loading or reloading non-financial account.")]
    Loading,

    /// <summary>
    /// Refund transaction.
    /// Encoded/decoded by serializers as &quot;RFND&quot;.
    /// </summary>
    [EnumMember(Value = "RFND")]
    [IsoId("_TWYx2QEcEeCQm6a_G2yO_w_80673725")]
    [Description(@"Refund transaction.")]
    Refund,

    /// <summary>
    /// Quasi-cash.
    /// Encoded/decoded by serializers as &quot;QUCH&quot;.
    /// </summary>
    [EnumMember(Value = "QUCH")]
    [IsoId("_TWYx2gEcEeCQm6a_G2yO_w_-288278122")]
    [Description(@"Quasi-cash.")]
    QuasiCash,

    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_TWYx2wEcEeCQm6a_G2yO_w_914954047")]
    [Description(@"Balance enquiry.")]
    Balance,

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_TWYx3AEcEeCQm6a_G2yO_w_1953662775")]
    [Description(@"Card activation.")]
    CardActivation,

    /// <summary>
    /// Card verification.
    /// Encoded/decoded by serializers as &quot;CAVR&quot;.
    /// </summary>
    [EnumMember(Value = "CAVR")]
    [IsoId("_TWYx3QEcEeCQm6a_G2yO_w_-887894059")]
    [Description(@"Card verification.")]
    CardVerification,

    /// <summary>
    /// PIN (Personal Identification Number) change.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_TWYx3gEcEeCQm6a_G2yO_w_-1242928159")]
    [Description(@"PIN (Personal Identification Number) change.")]
    PINChange,

    /// <summary>
    /// Card validity check.
    /// Encoded/decoded by serializers as &quot;VALC&quot;.
    /// </summary>
    [EnumMember(Value = "VALC")]
    [IsoId("_TWYx3wEcEeCQm6a_G2yO_w_-636889787")]
    [Description(@"Card validity check.")]
    ValidityCheck,

    /// <summary>
    /// Aggregation of low payments.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_TWYx4AEcEeCQm6a_G2yO_w_-394975993")]
    [Description(@"Aggregation of low payments.")]
    Aggregation,

    /// <summary>
    /// Dynamic currency conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_TWYx4QEcEeCQm6a_G2yO_w_-940424024")]
    [Description(@"Dynamic currency conversion (DCC).")]
    DCC,

    /// <summary>
    /// Card payment with gratuity.
    /// Encoded/decoded by serializers as &quot;GRTT&quot;.
    /// </summary>
    [EnumMember(Value = "GRTT")]
    [IsoId("_TWYx4gEcEeCQm6a_G2yO_w_-1693648762")]
    [Description(@"Card payment with gratuity.")]
    Gratuity,

    /// <summary>
    /// Instalment payment.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_TWYx4wEcEeCQm6a_G2yO_w_-911345686")]
    [Description(@"Instalment payment.")]
    Instalment,

    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_TWYx5AEcEeCQm6a_G2yO_w_1729156144")]
    [Description(@"Loyalty services.")]
    Loyalty,

    /// <summary>
    /// No show after reservation.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_TWYx5QEcEeCQm6a_G2yO_w_-291899491")]
    [Description(@"No show after reservation.")]
    NoShow,

    /// <summary>
    /// Purchase and corporate data.
    /// Encoded/decoded by serializers as &quot;PUCO&quot;.
    /// </summary>
    [EnumMember(Value = "PUCO")]
    [IsoId("_TWYx5gEcEeCQm6a_G2yO_w_-279888274")]
    [Description(@"Purchase and corporate data.")]
    PurchaseCorporate,

    /// <summary>
    /// Recurring payment.
    /// Encoded/decoded by serializers as &quot;RECP&quot;.
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_TWii0AEcEeCQm6a_G2yO_w_1025583084")]
    [Description(@"Recurring payment.")]
    RecurringPayment,

    /// <summary>
    /// Solicited available funds.
    /// Encoded/decoded by serializers as &quot;SOAF&quot;.
    /// </summary>
    [EnumMember(Value = "SOAF")]
    [IsoId("_TWii0QEcEeCQm6a_G2yO_w_-892382859")]
    [Description(@"Solicited available funds.")]
    SolicitedAvailableFunds,

    /// <summary>
    /// Unsolicited available funds.
    /// Encoded/decoded by serializers as &quot;UNAF&quot;.
    /// </summary>
    [EnumMember(Value = "UNAF")]
    [IsoId("_TWii0gEcEeCQm6a_G2yO_w_-538526509")]
    [Description(@"Unsolicited available funds.")]
    UnsolicitedAvailableFunds,

    /// <summary>
    /// Voice authorisation.
    /// Encoded/decoded by serializers as &quot;VCAU&quot;.
    /// </summary>
    [EnumMember(Value = "VCAU")]
    [IsoId("_TWii0wEcEeCQm6a_G2yO_w_-840164018")]
    [Description(@"Voice authorisation.")]
    VoiceAuthorisation,

    /// <summary>
    /// Initial reservation.
    /// Encoded/decoded by serializers as &quot;IRES&quot;.
    /// </summary>
    [EnumMember(Value = "IRES")]
    [IsoId("_TWii1AEcEeCQm6a_G2yO_w_-1102290141")]
    [Description(@"Initial reservation.")]
    InitialReservation,

    /// <summary>
    /// Update reservation.
    /// Encoded/decoded by serializers as &quot;URES&quot;.
    /// </summary>
    [EnumMember(Value = "URES")]
    [IsoId("_TWii1QEcEeCQm6a_G2yO_w_1673505606")]
    [Description(@"Update reservation.")]
    UpdateReservation,

    /// <summary>
    /// Payment after reservation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_TWii1gEcEeCQm6a_G2yO_w_-552324237")]
    [Description(@"Payment after reservation.")]
    PaymentReservation,

    /// <summary>
    /// Additional payment after reservation.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_TWii1wEcEeCQm6a_G2yO_w_424313901")]
    [Description(@"Additional payment after reservation.")]
    AdditionalPayment,

    /// <summary>
    /// Initial recurring payment.
    /// Encoded/decoded by serializers as &quot;FREC&quot;.
    /// </summary>
    [EnumMember(Value = "FREC")]
    [IsoId("_TWii2AEcEeCQm6a_G2yO_w_-1736718303")]
    [Description(@"Initial recurring payment.")]
    FirstRecurring,

    /// <summary>
    /// Repeat recurring payment.
    /// Encoded/decoded by serializers as &quot;RREC&quot;.
    /// </summary>
    [EnumMember(Value = "RREC")]
    [IsoId("_TWii2QEcEeCQm6a_G2yO_w_-156822480")]
    [Description(@"Repeat recurring payment.")]
    FollowingRecurring,

    /// <summary>
    /// Card payment transaction transfer from person to business.
    /// Encoded/decoded by serializers as &quot;TP2B&quot;.
    /// </summary>
    [EnumMember(Value = "TP2B")]
    [IsoId("_sQJJ8r4pEeKkGaJ0UrThyA_1968462400")]
    [Description(@"Card payment transaction transfer from person to business.")]
    PersonToBusiness,

    /// <summary>
    /// Card payment transaction transfer from person to person.
    /// Encoded/decoded by serializers as &quot;TP2P&quot;.
    /// </summary>
    [EnumMember(Value = "TP2P")]
    [IsoId("_sQS68L4pEeKkGaJ0UrThyA_433429517")]
    [Description(@"Card payment transaction transfer from person to person.")]
    PersonToPerson,

    /// <summary>
    /// Instalment payment transaction performed by the acceptor or the acquirer.
    /// Encoded/decoded by serializers as &quot;INSA&quot;.
    /// </summary>
    [EnumMember(Value = "INSA")]
    [IsoId("_NYeFgDAUEeOqioR9srQH1g")]
    [Description(@"Instalment payment transaction performed by the acceptor or the acquirer.")]
    AcceptorInstalment,

    /// <summary>
    /// Instalment payment transaction performed by the card issuer.
    /// Encoded/decoded by serializers as &quot;INSI&quot;.
    /// </summary>
    [EnumMember(Value = "INSI")]
    [IsoId("_SbmoMDAUEeOqioR9srQH1g")]
    [Description(@"Instalment payment transaction performed by the card issuer.")]
    IssuerInstalment,

    /// <summary>
    /// Unloading non-financial account.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_QuVv0DGuEeOAS49rwg4CIQ")]
    [Description(@"Unloading non-financial account.")]
    Unloading,

    /// <summary>
    /// Transfer of funds to a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFH&quot;.
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_W9K6MEuEEeOC3MFxIpMwug")]
    [Description(@"Transfer of funds to a card or an account.")]
    CardsFundTransferPush,

    /// <summary>
    /// Transfer of funds from a card or an account.
    /// Encoded/decoded by serializers as &quot;CAFL&quot;.
    /// </summary>
    [EnumMember(Value = "CAFL")]
    [IsoId("_pssUYEuEEeOC3MFxIpMwug")]
    [Description(@"Transfer of funds from a card or an account.")]
    CardsFundTransferPull,

    /// <summary>
    /// Withdrawal of cash on an ATM.
    /// Encoded/decoded by serializers as &quot;CHWD&quot;.
    /// </summary>
    [EnumMember(Value = "CHWD")]
    [IsoId("_GRJPoHsuEeSTS7uHCe8FPQ")]
    [Description(@"Withdrawal of cash on an ATM.")]
    CashWithdrawal,

    /// <summary>
    /// Unblock the cardholder PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_JT6dEHsuEeSTS7uHCe8FPQ")]
    [Description(@"Unblock the cardholder PIN.")]
    PINUnblock,

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CSWD&quot;.
    /// </summary>
    [EnumMember(Value = "CSWD")]
    [IsoId("_roVvkHsuEeSTS7uHCe8FPQ")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal,

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as &quot;AUWS&quot;.
    /// </summary>
    [EnumMember(Value = "AUWS")]
    [IsoId("_v-5gIHsuEeSTS7uHCe8FPQ")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel (amount could be absent)."
    )]
    PreAuthorisedWithdrawal,

    /// <summary>
    /// Amount and Notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PFWD&quot;.
    /// </summary>
    [EnumMember(Value = "PFWD")]
    [IsoId("_zCbikHsuEeSTS7uHCe8FPQ")]
    [Description(@"Amount and Notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal,

    /// <summary>
    /// Customer pressed a button associated with a withdrawal of unique amount and notes mix.
    /// Encoded/decoded by serializers as &quot;SDWD&quot;.
    /// </summary>
    [EnumMember(Value = "SDWD")]
    [IsoId("_5DLkEHsuEeSTS7uHCe8FPQ")]
    [Description(
        @"Customer pressed a button associated with a withdrawal of unique amount and notes mix."
    )]
    StandardWithdrawal,

    /// <summary>
    /// Transfer for payment of bills.
    /// Encoded/decoded by serializers as &quot;TFBL&quot;.
    /// </summary>
    [EnumMember(Value = "TFBL")]
    [IsoId("_PicNkIINEeSvPp7yXrNQIw")]
    [Description(@"Transfer for payment of bills.")]
    TransferCardBillPayment,

    /// <summary>
    /// Transfer from cash deposit.
    /// Encoded/decoded by serializers as &quot;TFCS&quot;.
    /// </summary>
    [EnumMember(Value = "TFCS")]
    [IsoId("_TOqnsIINEeSvPp7yXrNQIw")]
    [Description(@"Transfer from cash deposit.")]
    TransferFromCash,

    /// <summary>
    /// Transfer from cheque deposit.
    /// Encoded/decoded by serializers as &quot;TFCH&quot;.
    /// </summary>
    [EnumMember(Value = "TFCH")]
    [IsoId("_XkuB8IINEeSvPp7yXrNQIw")]
    [Description(@"Transfer from cheque deposit.")]
    TransferFromCheque,

    /// <summary>
    /// Transfer for general disbursement.
    /// Encoded/decoded by serializers as &quot;TFDB&quot;.
    /// </summary>
    [EnumMember(Value = "TFDB")]
    [IsoId("_adgM8IINEeSvPp7yXrNQIw")]
    [Description(@"Transfer for general disbursement.")]
    TransferFundsDisbursementGeneral,

    /// <summary>
    /// Transfer for government disbursement.
    /// Encoded/decoded by serializers as &quot;TFGD&quot;.
    /// </summary>
    [EnumMember(Value = "TFGD")]
    [IsoId("_dR9RkIINEeSvPp7yXrNQIw")]
    [Description(@"Transfer for government disbursement.")]
    TransferGovernmentDisbursement,

    /// <summary>
    /// Transfer for merchant disbursement.
    /// Encoded/decoded by serializers as &quot;TFMD&quot;.
    /// </summary>
    [EnumMember(Value = "TFMD")]
    [IsoId("_f4pnAIINEeSvPp7yXrNQIw")]
    [Description(@"Transfer for merchant disbursement.")]
    TransferMerchantDisbursement,

    /// <summary>
    /// Transfer for payroll pension disbursement.
    /// Encoded/decoded by serializers as &quot;TFPD&quot;.
    /// </summary>
    [EnumMember(Value = "TFPD")]
    [IsoId("_kLbDwIINEeSvPp7yXrNQIw")]
    [Description(@"Transfer for payroll pension disbursement.")]
    TransferPayrollPensionDisbursement,

    /// <summary>
    /// Payment of goods or services which are not refundable, for instance low cost airline tickets.
    /// Encoded/decoded by serializers as &quot;NRFD&quot;.
    /// </summary>
    [EnumMember(Value = "NRFD")]
    [IsoId("_LJjsUIIOEeSvPp7yXrNQIw")]
    [Description(
        @"Payment of goods or services which are not refundable, for instance low cost airline tickets."
    )]
    NonRefundable,

    /// <summary>
    /// Instant transaction.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_jRBRMC-JEeWfYucYWs4iQg")]
    [Description(@"Instant transaction.")]
    Instant,

    /// <summary>
    /// Credit adjustment to a previous transaction.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_IrHUIC-KEeWfYucYWs4iQg")]
    [Description(@"Credit adjustment to a previous transaction.")]
    CreditAdjustement,

    /// <summary>
    /// Debit adjustment to a previous transaction.
    /// Encoded/decoded by serializers as &quot;DADJ&quot;.
    /// </summary>
    [EnumMember(Value = "DADJ")]
    [IsoId("_c_fzUC-KEeWfYucYWs4iQg")]
    [Description(@"Debit adjustment to a previous transaction.")]
    DebitAdjustement,

    /// <summary>
    /// Creation of an X.509 certificate with the public key and the information of the owner of the asymmetric key provided by the requestor.
    /// Encoded/decoded by serializers as &quot;CRTC&quot;.
    /// </summary>
    [EnumMember(Value = "CRTC")]
    [IsoId("_R6J40I4MEeW6h7rGyYlyTg")]
    [Description(
        @"Creation of an X.509 certificate with the public key and the information of the owner of the asymmetric key provided by the requestor."
    )]
    CreateCertificate,

    /// <summary>
    /// Renewal of an X.509 certificate, protected by the certificate to renew.
    /// Encoded/decoded by serializers as &quot;CRTR&quot;.
    /// </summary>
    [EnumMember(Value = "CRTR")]
    [IsoId("_XsmYkI4MEeW6h7rGyYlyTg")]
    [Description(@"Renewal of an X.509 certificate, protected by the certificate to renew.")]
    RenewCerificate,

    /// <summary>
    /// Revocation of an active X.509 certificate.
    /// Encoded/decoded by serializers as &quot;CRTK&quot;.
    /// </summary>
    [EnumMember(Value = "CRTK")]
    [IsoId("_cOxjQI4MEeW6h7rGyYlyTg")]
    [Description(@"Revocation of an active X.509 certificate.")]
    RevokeCertificate,

    /// <summary>
    /// Add a POI in the white list of the terminal manager.
    /// Encoded/decoded by serializers as &quot;WLSA&quot;.
    /// </summary>
    [EnumMember(Value = "WLSA")]
    [IsoId("_fTQn8I4MEeW6h7rGyYlyTg")]
    [Description(@"Add a POI in the white list of the terminal manager.")]
    AddWhiteList,

    /// <summary>
    /// Remove a POI from the white list of the terminal manager.
    /// Encoded/decoded by serializers as &quot;WLSR&quot;.
    /// </summary>
    [EnumMember(Value = "WLSR")]
    [IsoId("_jDkQ0I4MEeW6h7rGyYlyTg")]
    [Description(@"Remove a POI from the white list of the terminal manager.")]
    RemoveWhiteList,

    /// <summary>
    /// Direct Debit initiated by Card.
    /// Encoded/decoded by serializers as &quot;CIDD&quot;.
    /// </summary>
    [EnumMember(Value = "CIDD")]
    [IsoId("_LK6ooNnIEeeN3v2fup_Shw")]
    [Description(@"Direct Debit initiated by Card.")]
    CardInitiatingDirectDebit,

    /// <summary>
    /// Acceptor claims for guarantee of payment.
    /// Encoded/decoded by serializers as &quot;GOPT&quot;.
    /// </summary>
    [EnumMember(Value = "GOPT")]
    [IsoId("_WWy7EE7DEeyGi9JAv6wq7Q")]
    [Description(@"Acceptor claims for guarantee of payment.")]
    GuaranteeOfPayment,

    /// <summary>
    /// DeferredClearing identifies transactions, like ones related to health care system, that allows a delay in clearing which ensure the payer to be refunded by a system, for example an insurance, before its bank account is debited.
    /// Encoded/decoded by serializers as &quot;DFCL&quot;.
    /// </summary>
    [EnumMember(Value = "DFCL")]
    [IsoId("")]
    [Description(
        @"DeferredClearing identifies transactions, like ones related to health care system, that allows a delay in clearing which ensure the payer to be refunded by a system, for example an insurance, before its bank account is debited."
    )]
    DeferredClearing,

    /// <summary>
    /// Used to inform the POI that it could select the payment instrument type to use.
    /// Encoded/decoded by serializers as &quot;PPMS&quot;.
    /// </summary>
    [EnumMember(Value = "PPMS")]
    [IsoId("")]
    [Description(
        @"Used to inform the POI that it could select the payment instrument type to use."
    )]
    POIPaymentMethodSelection,
}
