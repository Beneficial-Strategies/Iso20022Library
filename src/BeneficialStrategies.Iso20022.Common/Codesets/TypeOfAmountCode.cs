// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQDwEcEeCQm6a_G2yO_w_-259543426")]
[Description(@"Identification or qualification of the type of amount.")]
[Derivations(typeof(TypeOfAmount11Code),typeof(TypeOfAmount7Code),typeof(TypeOfAmount19Code),typeof(TypeOfAmount6Code),typeof(TypeOfAmount10Code),typeof(TypeOfAmount3Code),typeof(TypeOfAmount4Code),typeof(TypeOfAmount5Code),typeof(TypeOfAmount20Code),typeof(TypeOfAmount18Code),typeof(TypeOfAmount1Code),typeof(TypeOfAmount21Code),typeof(TypeOfAmount22Code),typeof(TypeOfAmount17Code),typeof(TypeOfAmount8Code),typeof(TypeOfAmount9Code),typeof(TypeOfAmount2Code),typeof(TypeOfAmount12Code))]
public enum TypeOfAmountCode
{
    /// <summary>
    /// Cash-back amount.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_TVfZ8AEcEeCQm6a_G2yO_w_-1930184107")]
    [Description(@"Cash-back amount.")]
    Cashback,
    
    /// <summary>
    /// Gratuity amount.
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_TVfZ8QEcEeCQm6a_G2yO_w_-1180517731")]
    [Description(@"Gratuity amount.")]
    Gratuity,
    
    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_TVfZ8gEcEeCQm6a_G2yO_w_343727554")]
    [Description(@"Fees.")]
    Fees,
    
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;RBTS&quot;.
    /// </summary>
    [EnumMember(Value = "RBTS")]
    [IsoId("_TVfZ8wEcEeCQm6a_G2yO_w_1690439733")]
    [Description(@"Global rebate of the transaction. This amount is counted as a negative amount.")]
    Rebates,
    
    /// <summary>
    /// Value added tax amount.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_TVfZ9AEcEeCQm6a_G2yO_w_2144527002")]
    [Description(@"Value added tax amount.")]
    ValueAddedTax,
    
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_TVfZ9QEcEeCQm6a_G2yO_w_540972543")]
    [Description(@"Actual amount.")]
    Actual,
    
    /// <summary>
    /// Replacement amount.
    /// Encoded/decoded by serializers as &quot;RPLT&quot;.
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_TVfZ9gEcEeCQm6a_G2yO_w_-2108727318")]
    [Description(@"Replacement amount.")]
    Replacement,
    
    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_TVfZ9wEcEeCQm6a_G2yO_w_-569938876")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum,
    
    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_TVfZ-AEcEeCQm6a_G2yO_w_-1745129901")]
    [Description(@"Default amount.")]
    Default,
    
    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_TVfZ-QEcEeCQm6a_G2yO_w_1844722780")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated,
    
    /// <summary>
    /// Original amount authorised during the real-time authorisation process.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_Y_ZH8PwLEeGHDMP28rpT3g_1300091733")]
    [Description(@"Original amount authorised during the real-time authorisation process.")]
    Original,
    
    /// <summary>
    /// Extra fee for a purchase or a withdrawal.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_Y_ZH8fwLEeGHDMP28rpT3g_481138052")]
    [Description(@"Extra fee for a purchase or a withdrawal.")]
    Surcharge,
    
    /// <summary>
    /// Service fee.
    /// Encoded/decoded by serializers as &quot;SRVF&quot;.
    /// </summary>
    [EnumMember(Value = "SRVF")]
    [IsoId("_Y_ZH8vwLEeGHDMP28rpT3g_894022134")]
    [Description(@"Service fee.")]
    ServiceFee,
    
    /// <summary>
    /// Interchange fee.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_Y_ZH8_wLEeGHDMP28rpT3g_-221556024")]
    [Description(@"Interchange fee.")]
    InterchangeFee,
    
    /// <summary>
    /// Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_-GjvoHs0EeSTS7uHCe8FPQ")]
    [Description(@"Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.")]
    Discount,
    
    /// <summary>
    /// Commission that the issuer will charge to the cardholder, which should be shown and accepted by the cardholder before the money is disbursed.
    /// Encoded/decoded by serializers as &quot;ATMF&quot;.
    /// </summary>
    [EnumMember(Value = "ATMF")]
    [IsoId("_i2oIsHs2EeSTS7uHCe8FPQ")]
    [Description(@"Commission that the issuer will charge to the cardholder, which should be shown and accepted by the cardholder before the money is disbursed.")]
    ATMCommissionFee,
    
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_lu4IMHs2EeSTS7uHCe8FPQ")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount,
    
    /// <summary>
    /// Remaining allowed amount for this type of transaction with this card, after the transaction, until the end of the card limit period.
    /// Encoded/decoded by serializers as &quot;CRDB&quot;.
    /// </summary>
    [EnumMember(Value = "CRDB")]
    [IsoId("_ovI0MHs2EeSTS7uHCe8FPQ")]
    [Description(@"Remaining allowed amount for this type of transaction with this card, after the transaction, until the end of the card limit period.")]
    CardRemainingBalance,
    
    /// <summary>
    /// Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTX&quot;.
    /// </summary>
    [EnumMember(Value = "AMTX")]
    [IsoId("_xRU3sHs2EeSTS7uHCe8FPQ")]
    [Description(@"Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined.")]
    MaximumAllowedAmount,
    
    /// <summary>
    /// Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTN&quot;.
    /// </summary>
    [EnumMember(Value = "AMTN")]
    [IsoId("_J1ctwHs3EeSTS7uHCe8FPQ")]
    [Description(@"Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined.")]
    MinimumAllowedAmount,
    
    /// <summary>
    /// Transaction amount that has been requested to be authorised.
    /// Encoded/decoded by serializers as &quot;AMTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AMTQ")]
    [IsoId("_PQuqsHs3EeSTS7uHCe8FPQ")]
    [Description(@"Transaction amount that has been requested to be authorised.")]
    RequestedAmount,
    
    /// <summary>
    /// Fees amount from the card issuer.
    /// Encoded/decoded by serializers as &quot;FEEI&quot;.
    /// </summary>
    [EnumMember(Value = "FEEI")]
    [IsoId("_V4YFgIN5EeSNofOeou9G3A")]
    [Description(@"Fees amount from the card issuer.")]
    IssuerFees,
    
    /// <summary>
    /// Commission from the card issuer.
    /// Encoded/decoded by serializers as &quot;COMI&quot;.
    /// </summary>
    [EnumMember(Value = "COMI")]
    [IsoId("_FlIEAIN6EeSNofOeou9G3A")]
    [Description(@"Commission from the card issuer.")]
    IssuerCommission,
    
    /// <summary>
    /// Interchange fees.
    /// Encoded/decoded by serializers as &quot;FEEH&quot;.
    /// </summary>
    [EnumMember(Value = "FEEH")]
    [IsoId("_bHvUEIN-EeSNofOeou9G3A")]
    [Description(@"Interchange fees.")]
    InterchangeFees,
    
    /// <summary>
    /// Processing fees.
    /// Encoded/decoded by serializers as &quot;FEEP&quot;.
    /// </summary>
    [EnumMember(Value = "FEEP")]
    [IsoId("_hkLzEIN-EeSNofOeou9G3A")]
    [Description(@"Processing fees.")]
    ProcessingFees,
    
    /// <summary>
    /// Currency conversion fees.
    /// Encoded/decoded by serializers as &quot;FEEC&quot;.
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_oS7jAIN-EeSNofOeou9G3A")]
    [Description(@"Currency conversion fees.")]
    CurrencyConversionFees,
    
    /// <summary>
    /// International service assessment fees.
    /// Encoded/decoded by serializers as &quot;FEEA&quot;.
    /// </summary>
    [EnumMember(Value = "FEEA")]
    [IsoId("_yhTbgIN-EeSNofOeou9G3A")]
    [Description(@"International service assessment fees.")]
    InternationalServiceAssessmentFees,
    
    /// <summary>
    /// Commission, for example for DCC (Dynamic Currency Conversion) transactions.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_06w68NPHEeSFn54OzS96Iw")]
    [Description(@"Commission, for example for DCC (Dynamic Currency Conversion) transactions.")]
    Commission,
    
    /// <summary>
    /// Donation amount.
    /// Encoded/decoded by serializers as &quot;DONN&quot;.
    /// </summary>
    [EnumMember(Value = "DONN")]
    [IsoId("_PwDnsC70EeWc7f-D6ByqMg")]
    [Description(@"Donation amount.")]
    Donation,
    
    /// <summary>
    /// Taxes applicable to the transaction.
    /// Encoded/decoded by serializers as &quot;TAXT&quot;.
    /// </summary>
    [EnumMember(Value = "TAXT")]
    [IsoId("_UwZ8IC70EeWc7f-D6ByqMg")]
    [Description(@"Taxes applicable to the transaction.")]
    Tax,
    
    /// <summary>
    /// Incremental amount for reservation.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_qnZCIK1zEeawR4FMacHsRQ")]
    [Description(@"Incremental amount for reservation.")]
    Incremental,
    
    /// <summary>
    /// Decremental amount for reservation.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_yI654K1zEeawR4FMacHsRQ")]
    [Description(@"Decremental amount for reservation.")]
    Decremental,
    
    /// <summary>
    /// Reserved or updated reserved amount for reservation.
    /// Encoded/decoded by serializers as &quot;RESD&quot;.
    /// </summary>
    [EnumMember(Value = "RESD")]
    [IsoId("_2wFSQK1zEeawR4FMacHsRQ")]
    [Description(@"Reserved or updated reserved amount for reservation.")]
    Reserved,
    
    /// <summary>
    /// Actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_McjMMqHjEeagRbKvRt3LnA")]
    [Description(@"Actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.")]
    ConfirmedAmount,
    
    /// <summary>
    /// Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_McjMM6HjEeagRbKvRt3LnA")]
    [Description(@"Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.|Usage: This amount has to be transported unchanged through the transaction chain.")]
    InstructedAmount,
    
    /// <summary>
    /// Fee for giving access to an ATM.
    /// Encoded/decoded by serializers as &quot;ATAF&quot;.
    /// </summary>
    [EnumMember(Value = "ATAF")]
    [IsoId("_FyM2EnyMEemHsOqJOzMVfg")]
    [Description(@"Fee for giving access to an ATM.")]
    ATMAccessFee,
    
    /// <summary>
    /// Fee related to a cardholder billing.
    /// Encoded/decoded by serializers as &quot;CHBF&quot;.
    /// </summary>
    [EnumMember(Value = "CHBF")]
    [IsoId("_FyM2E3yMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a cardholder billing.")]
    CardholderBillingFee,
    
    /// <summary>
    /// Fee related to a clearing transaction.
    /// Encoded/decoded by serializers as &quot;CLFE&quot;.
    /// </summary>
    [EnumMember(Value = "CLFE")]
    [IsoId("_FyM2FHyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a clearing transaction.")]
    ClearingFee,
    
    /// <summary>
    /// Fee related to a credit transaction.
    /// Encoded/decoded by serializers as &quot;CRTF&quot;.
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_FyM2FXyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a credit transaction.")]
    CreditTransactionFee,
    
    /// <summary>
    /// Contains the total amount of all authorisations related to the same cardholder purchase activities. Example: total of all incremental or splitted shipment authorisations for the same purchase.
    /// Encoded/decoded by serializers as &quot;CUAT&quot;.
    /// </summary>
    [EnumMember(Value = "CUAT")]
    [IsoId("_FyM2FnyMEemHsOqJOzMVfg")]
    [Description(@"Contains the total amount of all authorisations related to the same cardholder purchase activities. Example: total of all incremental or splitted shipment authorisations for the same purchase.")]
    Cumulative,
    
    /// <summary>
    /// Fee related to a debit transaction.
    /// Encoded/decoded by serializers as &quot;DBTF&quot;.
    /// </summary>
    [EnumMember(Value = "DBTF")]
    [IsoId("_FyM2F3yMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a debit transaction.")]
    DebitTransactionFee,
    
    /// <summary>
    /// Extra charges (for example,  minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_FyM2GHyMEemHsOqJOzMVfg")]
    [Description(@"Extra charges (for example,  minibar, etc.)")]
    Extra,
    
    /// <summary>
    /// Fee related to a foreign exchange transaction.
    /// Encoded/decoded by serializers as &quot;FXFE&quot;.
    /// </summary>
    [EnumMember(Value = "FXFE")]
    [IsoId("_FyM2GXyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a foreign exchange transaction.")]
    ForeignExchangeFee,
    
    /// <summary>
    /// Fee related to a funds transfer transaction
    /// Encoded/decoded by serializers as &quot;FDTF&quot;.
    /// </summary>
    [EnumMember(Value = "FDTF")]
    [IsoId("_FyM2GnyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a funds transfer transaction")]
    FundsTransfer,
    
    /// <summary>
    /// Fee related to an instant payment.
    /// Encoded/decoded by serializers as &quot;IPFE&quot;.
    /// </summary>
    [EnumMember(Value = "IPFE")]
    [IsoId("_FyM2G3yMEemHsOqJOzMVfg")]
    [Description(@"Fee related to an instant payment.")]
    InstantPaymentFee,
    
    /// <summary>
    /// Fee related to an instant transfer transaction.
    /// Encoded/decoded by serializers as &quot;ITFE&quot;.
    /// </summary>
    [EnumMember(Value = "ITFE")]
    [IsoId("_FyM2HHyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to an instant transfer transaction.")]
    InstantTransferFee,
    
    /// <summary>
    /// Fee applied by the card issuer to the cardholder.
    /// Encoded/decoded by serializers as &quot;ISCF&quot;.
    /// </summary>
    [EnumMember(Value = "ISCF")]
    [IsoId("_FyM2HXyMEemHsOqJOzMVfg")]
    [Description(@"Fee applied by the card issuer to the cardholder.")]
    IssuerCardholderFee,
    
    /// <summary>
    /// Limit of amounts for the transaction.
    /// Encoded/decoded by serializers as &quot;LTAM&quot;.
    /// </summary>
    [EnumMember(Value = "LTAM")]
    [IsoId("_FyM2HnyMEemHsOqJOzMVfg")]
    [Description(@"Limit of amounts for the transaction.")]
    Limit,
    
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_FyM2H3yMEemHsOqJOzMVfg")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_FyM2IHyMEemHsOqJOzMVfg")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Fee related to a reconciliation transaction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_FyM2IXyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a reconciliation transaction.")]
    ReconciliationFee,
    
    /// <summary>
    /// Fee related to a settlement transaction.
    /// Encoded/decoded by serializers as &quot;STFE&quot;.
    /// </summary>
    [EnumMember(Value = "STFE")]
    [IsoId("_FyM2InyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a settlement transaction.")]
    SettlementFee,
    
    /// <summary>
    /// Fee related to a transaction.
    /// Encoded/decoded by serializers as &quot;TXFE&quot;.
    /// </summary>
    [EnumMember(Value = "TXFE")]
    [IsoId("_FyM2I3yMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a transaction.")]
    TransactionFee,
    
    /// <summary>
    /// Amount anticipated for the transaction
    /// Encoded/decoded by serializers as &quot;ANTA&quot;.
    /// </summary>
    [EnumMember(Value = "ANTA")]
    [IsoId("_VmvFz3yMEemHsOqJOzMVfg")]
    [Description(@"Amount anticipated for the transaction")]
    Anticipated,
    
    /// <summary>
    /// Baggage related fees
    /// Encoded/decoded by serializers as &quot;BAGG&quot;.
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_VmvF0HyMEemHsOqJOzMVfg")]
    [Description(@"Baggage related fees")]
    Baggage,
    
    /// <summary>
    /// Amount that has been charged to card account
    /// Encoded/decoded by serializers as &quot;CHTC&quot;.
    /// </summary>
    [EnumMember(Value = "CHTC")]
    [IsoId("_VmvF0XyMEemHsOqJOzMVfg")]
    [Description(@"Amount that has been charged to card account")]
    ChargedToCard,
    
    /// <summary>
    /// Fee related to a clearing transaction for a given priority.
    /// Encoded/decoded by serializers as &quot;CPFE&quot;.
    /// </summary>
    [EnumMember(Value = "CPFE")]
    [IsoId("_VmvF0nyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a clearing transaction for a given priority.")]
    ClearingPriorityFee,
    
    /// <summary>
    /// Amount qualified for dental prescriptions
    /// Encoded/decoded by serializers as &quot;DNTL&quot;.
    /// </summary>
    [EnumMember(Value = "DNTL")]
    [IsoId("_VmvF03yMEemHsOqJOzMVfg")]
    [Description(@"Amount qualified for dental prescriptions")]
    Dental,
    
    /// <summary>
    /// Deposit amount.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_VmvF1HyMEemHsOqJOzMVfg")]
    [Description(@"Deposit amount.")]
    Deposit,
    
    /// <summary>
    /// Fee related to a funds transfer.
    /// Encoded/decoded by serializers as &quot;FUFE&quot;.
    /// </summary>
    [EnumMember(Value = "FUFE")]
    [IsoId("_VmvF1XyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a funds transfer.")]
    FundsTransferFee,
    
    /// <summary>
    /// Amount qualified for other medical expenses
    /// Encoded/decoded by serializers as &quot;OQME&quot;.
    /// </summary>
    [EnumMember(Value = "OQME")]
    [IsoId("_VmvF1nyMEemHsOqJOzMVfg")]
    [Description(@"Amount qualified for other medical expenses")]
    OtherQualifiedMedical,
    
    /// <summary>
    /// Amount for medical prescription
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_VmvF13yMEemHsOqJOzMVfg")]
    [Description(@"Amount for medical prescription")]
    Prescription,
    
    /// <summary>
    /// Substitute for an amount to be authorised.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VmvF2HyMEemHsOqJOzMVfg")]
    [Description(@"Substitute for an amount to be authorised.")]
    Proxy,
    
    /// <summary>
    /// Requested cashback amount
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("_VmvF2XyMEemHsOqJOzMVfg")]
    [Description(@"Requested cashback amount")]
    RequestedCashback,
    
    /// <summary>
    /// Fee related to a settlement transaction for a given priority.
    /// Encoded/decoded by serializers as &quot;SPFE&quot;.
    /// </summary>
    [EnumMember(Value = "SPFE")]
    [IsoId("_VmvF2nyMEemHsOqJOzMVfg")]
    [Description(@"Fee related to a settlement transaction for a given priority.")]
    SettlementPriorityFee,
    
    /// <summary>
    /// Total healthcare amount
    /// Encoded/decoded by serializers as &quot;THTC&quot;.
    /// </summary>
    [EnumMember(Value = "THTC")]
    [IsoId("_VmvF23yMEemHsOqJOzMVfg")]
    [Description(@"Total healthcare amount")]
    TotalHealthcare,
    
    /// <summary>
    /// Amount in transit
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_VmvF3HyMEemHsOqJOzMVfg")]
    [Description(@"Amount in transit")]
    Transit,
    
    /// <summary>
    /// Amount qualified for medical vision expenses
    /// Encoded/decoded by serializers as &quot;VISN&quot;.
    /// </summary>
    [EnumMember(Value = "VISN")]
    [IsoId("_VmvF3XyMEemHsOqJOzMVfg")]
    [Description(@"Amount qualified for medical vision expenses")]
    Vision,
    
    /// <summary>
    /// Telephone connection-related charge
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_iJ8uvXyMEemHsOqJOzMVfg")]
    [Description(@"Telephone connection-related charge")]
    Connect,
    
    /// <summary>
    /// Data communication related charges
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_iJ8uvnyMEemHsOqJOzMVfg")]
    [Description(@"Data communication related charges")]
    Data,
    
    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTK&quot;.
    /// </summary>
    [EnumMember(Value = "EXTK")]
    [IsoId("_iJ8uv3yMEemHsOqJOzMVfg")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicket,
    
    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as &quot;EXTF&quot;.
    /// </summary>
    [EnumMember(Value = "EXTF")]
    [IsoId("_iJ8uwHyMEemHsOqJOzMVfg")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicketFee,
    
    /// <summary>
    /// Amount of fare
    /// Encoded/decoded by serializers as &quot;FARE&quot;.
    /// </summary>
    [EnumMember(Value = "FARE")]
    [IsoId("_iJ8uwXyMEemHsOqJOzMVfg")]
    [Description(@"Amount of fare")]
    Fare,
    
    /// <summary>
    /// Amount of food and beverages
    /// Encoded/decoded by serializers as &quot;FDBV&quot;.
    /// </summary>
    [EnumMember(Value = "FDBV")]
    [IsoId("_iJ8uwnyMEemHsOqJOzMVfg")]
    [Description(@"Amount of food and beverages")]
    FoodBeverage,
    
    /// <summary>
    /// Insurance charges 
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_iJ8uw3yMEemHsOqJOzMVfg")]
    [Description(@"Insurance charges ")]
    Insurance,
    
    /// <summary>
    /// Charges related to a long distance call. 
    /// Encoded/decoded by serializers as &quot;LNDS&quot;.
    /// </summary>
    [EnumMember(Value = "LNDS")]
    [IsoId("_iJ8uxHyMEemHsOqJOzMVfg")]
    [Description(@"Charges related to a long distance call. ")]
    LongDistance,
    
    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_iJ8uxXyMEemHsOqJOzMVfg")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous,
    
    /// <summary>
    /// Phone charges
    /// Encoded/decoded by serializers as &quot;PHNE&quot;.
    /// </summary>
    [EnumMember(Value = "PHNE")]
    [IsoId("_iJ8uxnyMEemHsOqJOzMVfg")]
    [Description(@"Phone charges")]
    Phone,
    
    /// <summary>
    /// Amount of prepayment
    /// Encoded/decoded by serializers as &quot;PRPY&quot;.
    /// </summary>
    [EnumMember(Value = "PRPY")]
    [IsoId("_iJ8ux3yMEemHsOqJOzMVfg")]
    [Description(@"Amount of prepayment")]
    Prepayment,
    
    /// <summary>
    /// Total amount of charges
    /// Encoded/decoded by serializers as &quot;TOTL&quot;.
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_iJ8uyHyMEemHsOqJOzMVfg")]
    [Description(@"Total amount of charges")]
    Total,
    
    /// <summary>
    /// Telephone usage-related charge
    /// Encoded/decoded by serializers as &quot;USGE&quot;.
    /// </summary>
    [EnumMember(Value = "USGE")]
    [IsoId("_iJ8uyXyMEemHsOqJOzMVfg")]
    [Description(@"Telephone usage-related charge")]
    Usage,
    
    /// <summary>
    /// Local amount before DCC (Dynamic Currency Conversion) was applied.
    /// Encoded/decoded by serializers as &quot;PDCC&quot;.
    /// </summary>
    [EnumMember(Value = "PDCC")]
    [IsoId("_c3dZUOkUEemeDPHh-U9b6w")]
    [Description(@"Local amount before DCC (Dynamic Currency Conversion) was applied.")]
    PreDCC,
    
    /// <summary>
    /// Amount for an upgrade.
    /// Encoded/decoded by serializers as &quot;UPGD&quot;.
    /// </summary>
    [EnumMember(Value = "UPGD")]
    [IsoId("_NjK40JJDEeuuktRxxQZoNQ")]
    [Description(@"Amount for an upgrade.")]
    Upgrade,
    
    /// <summary>
    /// Amount for club fee.
    /// Encoded/decoded by serializers as &quot;CLUB&quot;.
    /// </summary>
    [EnumMember(Value = "CLUB")]
    [IsoId("_ryiacJJDEeuuktRxxQZoNQ")]
    [Description(@"Amount for club fee.")]
    ClubFee,
    
    /// <summary>
    /// Cargo Amount.
    /// Encoded/decoded by serializers as &quot;CARG&quot;.
    /// </summary>
    [EnumMember(Value = "CARG")]
    [IsoId("_vkaJkJJDEeuuktRxxQZoNQ")]
    [Description(@"Cargo Amount.")]
    Cargo,
    
    /// <summary>
    /// Duty free amount
    /// Encoded/decoded by serializers as &quot;DUTY&quot;.
    /// </summary>
    [EnumMember(Value = "DUTY")]
    [IsoId("_DB9ucJJEEeuuktRxxQZoNQ")]
    [Description(@"Duty free amount")]
    DutyFree,
    
    /// <summary>
    /// Ticket delivery amount.
    /// Encoded/decoded by serializers as &quot;TKDL&quot;.
    /// </summary>
    [EnumMember(Value = "TKDL")]
    [IsoId("_JctkUJJEEeuuktRxxQZoNQ")]
    [Description(@"Ticket delivery amount.")]
    TicketDelivery,
    
    /// <summary>
    /// Pet carrier.
    /// Encoded/decoded by serializers as &quot;PETC&quot;.
    /// </summary>
    [EnumMember(Value = "PETC")]
    [IsoId("_PSsgQJJEEeuuktRxxQZoNQ")]
    [Description(@"Pet carrier.")]
    PetCarrier,
    
    /// <summary>
    /// Tour order amount.
    /// Encoded/decoded by serializers as &quot;TOUR&quot;.
    /// </summary>
    [EnumMember(Value = "TOUR")]
    [IsoId("_euW9AJJEEeuuktRxxQZoNQ")]
    [Description(@"Tour order amount.")]
    TourOrder,
    
    /// <summary>
    /// Minimum interchange fee applicable.
    /// Encoded/decoded by serializers as &quot;MNIF&quot;.
    /// </summary>
    [EnumMember(Value = "MNIF")]
    [IsoId("_iYjIYKH-EeuiuNcvKhXmNQ")]
    [Description(@"Minimum interchange fee applicable.")]
    MinimumInterchangeFee,
    
    /// <summary>
    /// Maximum applicable interchange fee.
    /// Encoded/decoded by serializers as &quot;MXIF&quot;.
    /// </summary>
    [EnumMember(Value = "MXIF")]
    [IsoId("_rJXdwKH-EeuiuNcvKhXmNQ")]
    [Description(@"Maximum applicable interchange fee.")]
    MaximumInterchangeFee,
    
    /// <summary>
    /// Interchange fee applicable to cash back amount.
    /// Encoded/decoded by serializers as &quot;CSIF&quot;.
    /// </summary>
    [EnumMember(Value = "CSIF")]
    [IsoId("_yhfh4KH-EeuiuNcvKhXmNQ")]
    [Description(@"Interchange fee applicable to cash back amount.")]
    CashBackInterchangeFee,
    
}
