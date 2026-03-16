// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category purpose, as published in an external category purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gyn2AIKWEeeCI5iKR7LsYQ")]
[Description(
    @"Specifies the category purpose, as published in an external category purpose code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCategoryPurpose1Code))]
public enum ExternalCategoryPurposeCode
{
    /// <summary>
    /// Transaction is the payment of a bonus.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_tjxaAPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of a bonus.")]
    BonusPayment,

    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_tjxaA_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer,

    /// <summary>
    /// A service that is settling money for a bulk of card transactions, while referring to a specific transaction file or other information like terminal ID, card acceptor ID or other transaction details.
    /// Encoded/decoded by serializers as &quot;CBLK&quot;.
    /// </summary>
    [EnumMember(Value = "CBLK")]
    [IsoId("_tjxaBvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A service that is settling money for a bulk of card transactions, while referring to a specific transaction file or other information like terminal ID, card acceptor ID or other transaction details."
    )]
    CardBulkClearing,

    /// <summary>
    /// Transaction is related to a payment of credit card.
    /// Encoded/decoded by serializers as &quot;CCRD&quot;.
    /// </summary>
    [EnumMember(Value = "CCRD")]
    [IsoId("_tjxaCfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of credit card.")]
    CreditCardPayment,

    /// <summary>
    /// Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_tjxaDPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to settlement of a trade, eg a foreign exchange deal or a securities transaction."
    )]
    TradeSettlementPayment,

    /// <summary>
    /// Transaction is related to a payment of debit card.
    /// Encoded/decoded by serializers as &quot;DCRD&quot;.
    /// </summary>
    [EnumMember(Value = "DCRD")]
    [IsoId("_tkEU8PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment of debit card.")]
    DebitCardPayment,

    /// <summary>
    /// Transaction is the payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_tkEU8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of dividends.")]
    Dividend,

    /// <summary>
    /// Code used to pre-advise the account servicer of a forthcoming deliver against payment instruction.
    /// Encoded/decoded by serializers as &quot;DVPM&quot;.
    /// </summary>
    [EnumMember(Value = "DVPM")]
    [IsoId("_tkEU9vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Code used to pre-advise the account servicer of a forthcoming deliver against payment instruction."
    )]
    DeliverAgainstPayment,

    /// <summary>
    /// Transaction is related to ePayment.
    /// Encoded/decoded by serializers as &quot;EPAY&quot;.
    /// </summary>
    [EnumMember(Value = "EPAY")]
    [IsoId("_tkOF8PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to ePayment.")]
    Epayment,

    /// <summary>
    /// Transaction is related to the payment of a fee and interest.
    /// Encoded/decoded by serializers as &quot;FCIN&quot;.
    /// </summary>
    [EnumMember(Value = "FCIN")]
    [IsoId("_tkOF8_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the payment of a fee and interest.")]
    FeeCollectionAndInterest,

    /// <summary>
    /// A service that is settling card transaction related fees between two parties.
    /// Encoded/decoded by serializers as &quot;FCOL&quot;.
    /// </summary>
    [EnumMember(Value = "FCOL")]
    [IsoId("_tkOF9vRYEeuLhpyIdtJzwg")]
    [Description(@"A service that is settling card transaction related fees between two parties.")]
    FeeCollection,

    /// <summary>
    /// General Person-to-Person Payment. Debtor and Creditor are natural persons.
    /// Encoded/decoded by serializers as &quot;GP2P&quot;.
    /// </summary>
    [EnumMember(Value = "GP2P")]
    [IsoId("_tkX28PRYEeuLhpyIdtJzwg")]
    [Description(@"General Person-to-Person Payment. Debtor and Creditor are natural persons.")]
    PersontoPersonPayment,

    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_tkX28_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment,

    /// <summary>
    /// Transaction is related to the payment of a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_tkX29vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the payment of a hedging operation.")]
    Hedging,

    /// <summary>
    /// Transaction is reimbursement of credit card payment.
    /// Encoded/decoded by serializers as &quot;ICCP&quot;.
    /// </summary>
    [EnumMember(Value = "ICCP")]
    [IsoId("_tkhA4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is reimbursement of credit card payment.")]
    IrrevocableCreditCardPayment,

    /// <summary>
    /// Transaction is reimbursement of debit card payment.
    /// Encoded/decoded by serializers as &quot;IDCP&quot;.
    /// </summary>
    [EnumMember(Value = "IDCP")]
    [IsoId("_tkhA4_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is reimbursement of debit card payment.")]
    IrrevocableDebitCardPayment,

    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_tkhA5vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group."
    )]
    IntraCompanyPayment,

    /// <summary>
    /// Transaction is the payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_tkhA6fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of interest.")]
    Interest,

    /// <summary>
    /// Transaction is related to identify cash handling via Night Safe or Lockbox by bank or vendor on behalf of a physical store.
    /// Encoded/decoded by serializers as &quot;LBOX&quot;.
    /// </summary>
    [EnumMember(Value = "LBOX")]
    [IsoId("_tkhA7PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to identify cash handling via Night Safe or Lockbox by bank or vendor on behalf of a physical store."
    )]
    LockboxTransactions,

    /// <summary>
    /// Transaction is related to the transfer of a loan to a borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_tkqx4PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the transfer of a loan to a borrower.")]
    Loan,

    /// <summary>
    /// Mobile P2B Payment
    /// Encoded/decoded by serializers as &quot;MP2B&quot;.
    /// </summary>
    [EnumMember(Value = "MP2B")]
    [IsoId("_tkqx4_RYEeuLhpyIdtJzwg")]
    [Description(@"Mobile P2B Payment")]
    Commercial,

    /// <summary>
    /// Mobile P2P Payment
    /// Encoded/decoded by serializers as &quot;MP2P&quot;.
    /// </summary>
    [EnumMember(Value = "MP2P")]
    [IsoId("_tkqx5vRYEeuLhpyIdtJzwg")]
    [Description(@"Mobile P2P Payment")]
    Consumer,

    /// <summary>
    /// Other payment purpose.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tk0i4PRYEeuLhpyIdtJzwg")]
    [Description(@"Other payment purpose.")]
    OtherPayment,

    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_tk0i4_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment,

    /// <summary>
    /// Collection used to re-present previously reversed or returned direct debit transactions.
    /// Encoded/decoded by serializers as &quot;RPRE&quot;.
    /// </summary>
    [EnumMember(Value = "RPRE")]
    [IsoId("_tk0i5vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Collection used to re-present previously reversed or returned direct debit transactions."
    )]
    Represented,

    /// <summary>
    /// Transaction is related to a reimbursement for commercial reasons of a correctly received credit transfer.
    /// Encoded/decoded by serializers as &quot;RRCT&quot;.
    /// </summary>
    [EnumMember(Value = "RRCT")]
    [IsoId("_tk0i6fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to a reimbursement for commercial reasons of a correctly received credit transfer."
    )]
    ReimbursementReceivedCreditTransfer,

    /// <summary>
    /// Code used to pre-advise the account servicer of a forthcoming receive against payment instruction.
    /// Encoded/decoded by serializers as &quot;RVPM&quot;.
    /// </summary>
    [EnumMember(Value = "RVPM")]
    [IsoId("_tk0i7PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Code used to pre-advise the account servicer of a forthcoming receive against payment instruction."
    )]
    ReceiveAgainstPayment,

    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_tk9s0PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment,

    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_tk9s0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of securities.")]
    Securities,

    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_tk9s1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is a social security benefit, ie payment made by a government to support individuals."
    )]
    SocialSecurityBenefit,

    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_tk9s2fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment,

    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_tlHd0PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment,

    /// <summary>
    /// Transaction is related to the payment of a trade finance transaction.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_tlHd0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is related to the payment of a trade finance transaction.")]
    Trade,

    /// <summary>
    /// Transaction is related to treasury operations.  E.g. financial contract settlement.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_tlHd1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Transaction is related to treasury operations.  E.g. financial contract settlement."
    )]
    TreasuryPayment,

    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_tlHd2fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment,

    /// <summary>
    /// Transaction is the payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHLD&quot;.
    /// </summary>
    [EnumMember(Value = "WHLD")]
    [IsoId("_tlQnwPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is the payment of withholding tax.")]
    WithHolding,

    /// <summary>
    /// Classification: Cash Management. Transaction relates to a cash management instruction, requesting a sweep of the account of the Debtor above an agreed floor amount, up to a target or zero balance.
    /// The purpose is to move the funds from multiple accounts to a single bank account. Funds can move domestically or across border and more than one bank can be used.
    /// Encoded/decoded by serializers as &quot;SWEP&quot;.
    /// </summary>
    [EnumMember(Value = "SWEP")]
    [IsoId("_ND97QFEoEey6cYDbEubNXg")]
    [Description(
        @"Classification: Cash Management. Transaction relates to a cash management instruction, requesting a sweep of the account of the Debtor above an agreed floor amount, up to a target or zero balance.|The purpose is to move the funds from multiple accounts to a single bank account. Funds can move domestically or across border and more than one bank can be used."
    )]
    CashManagementSweepAccount,

    /// <summary>
    /// Classification: Cash Management. Transaction relates to a cash management instruction, requesting to top the account of the Creditor above a certain floor amount, up to a target or zero balance.
    /// The floor amount, if not pre-agreed by the parties involved, may be specified.
    /// Encoded/decoded by serializers as &quot;TOPG&quot;.
    /// </summary>
    [EnumMember(Value = "TOPG")]
    [IsoId("_0Z0gQFEoEey6cYDbEubNXg")]
    [Description(
        @"Classification: Cash Management. Transaction relates to a cash management instruction, requesting to top the account of the Creditor above a certain floor amount, up to a target or zero balance. |The floor amount, if not pre-agreed by the parties involved, may be specified."
    )]
    CashManagementTopAccount,

    /// <summary>
    /// Transaction relates to a cash management instruction, requesting to zero balance the account of the Debtor.
    /// Zero Balance Accounts empty or fill the balances in accounts at the same bank, in the same country into or out of a main account each day.
    /// Encoded/decoded by serializers as &quot;ZABA&quot;.
    /// </summary>
    [EnumMember(Value = "ZABA")]
    [IsoId("_oFvDAFEpEey6cYDbEubNXg")]
    [Description(
        @"Transaction relates to a cash management instruction, requesting to zero balance the account of the Debtor.|Zero Balance Accounts empty or fill the balances in accounts at the same bank, in the same country into or out of a main account each day."
    )]
    CashManagementZeroBalanceAccount,

    /// <summary>
    /// Transaction to be processed as a domestic payment instruction originated from a foreign bank.
    /// Encoded/decoded by serializers as &quot;VOST&quot;.
    /// </summary>
    [EnumMember(Value = "VOST")]
    [IsoId("_CgcksCepEe2VkIu7jTuNaA")]
    [Description(
        @"Transaction to be processed as a domestic payment instruction originated from a foreign bank."
    )]
    CrossborderMIPayments,

    /// <summary>
    /// Foreign Currency Transaction that is processed between two domestic financial institutions.
    /// Encoded/decoded by serializers as &quot;FCDT&quot;.
    /// </summary>
    [EnumMember(Value = "FCDT")]
    [IsoId("_2MVrYGvbEe2F6NrIyOmXcA")]
    [Description(
        @"Foreign Currency Transaction that is processed between two domestic financial institutions."
    )]
    ForeignCurrencyDomesticTransfer,

    /// <summary>
    /// Transaction is a direct debit for a cash order of notes and/or coins.
    /// Encoded/decoded by serializers as &quot;CIPC&quot;.
    /// </summary>
    [EnumMember(Value = "CIPC")]
    [IsoId("_TiiT4GvdEe2F6NrIyOmXcA")]
    [Description(@"Transaction is a direct debit for a cash order of notes and/or coins.")]
    CashInPreCredit,

    /// <summary>
    /// Transaction is a direct debit for a cash order of notes and/or coins.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_fXXz4GvdEe2F6NrIyOmXcA")]
    [Description(@"Transaction is a direct debit for a cash order of notes and/or coins.")]
    CashOutNotesCoins,

    /// <summary>
    /// Transaction is a payment towards a Party for the collection of cash by the Cash in Transit company.
    /// Encoded/decoded by serializers as &quot;CGWV&quot;.
    /// </summary>
    [EnumMember(Value = "CGWV")]
    [IsoId("_rF1cANRdEe2vd-PLFk_9fA")]
    [Description(
        @"Transaction is a payment towards a Party for the collection of cash by the Cash in Transit company."
    )]
    CarrierGuardedWholesaleValuables,
}
