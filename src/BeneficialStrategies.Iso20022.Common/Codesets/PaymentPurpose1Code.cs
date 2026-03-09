// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in a payment initiation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z5CfuNp-Ed-ak6NoX_4Aeg_148233450")]
[Description(@"Specifies the type of transaction that resulted in a payment initiation.")]
[DerivedFrom(typeof(PaymentPurposeCode))]
public enum PaymentPurpose1Code
{
    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_Z5Cfudp-Ed-ak6NoX_4Aeg_1037583707")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment = PaymentPurposeCode.SalaryPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to treasury operations.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_Z5LpoNp-Ed-ak6NoX_4Aeg_1037583732")]
    [Description(@"Transaction is related to treasury operations.")]
    TreasuryPayment = PaymentPurposeCode.TreasuryPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an advance payment.
    /// Encoded/decoded by serializers as &quot;ADVA&quot;.
    /// </summary>
    [EnumMember(Value = "ADVA")]
    [IsoId("_Z5Lpodp-Ed-ak6NoX_4Aeg_1037583904")]
    [Description(@"Transaction is an advance payment.")]
    AdvancePayment = PaymentPurposeCode.AdvancePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the agricultural domain.
    /// Encoded/decoded by serializers as &quot;AGRT&quot;.
    /// </summary>
    [EnumMember(Value = "AGRT")]
    [IsoId("_Z5Lpotp-Ed-ak6NoX_4Aeg_1037584139")]
    [Description(@"Transaction is related to the agricultural domain.")]
    AgriculturalTransfer = PaymentPurposeCode.AgriculturalTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of alimony.
    /// Encoded/decoded by serializers as &quot;ALMY&quot;.
    /// </summary>
    [EnumMember(Value = "ALMY")]
    [IsoId("_Z5Lpo9p-Ed-ak6NoX_4Aeg_1037584156")]
    [Description(@"Transaction is the payment of alimony.")]
    AlimonyPayment = PaymentPurposeCode.AlimonyPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a payment made to assist parent/guardian to maintain child.
    /// Encoded/decoded by serializers as &quot;BECH&quot;.
    /// </summary>
    [EnumMember(Value = "BECH")]
    [IsoId("_Z5LppNp-Ed-ak6NoX_4Aeg_1037584199")]
    [Description(@"Transaction is related to a payment made to assist parent/guardian to maintain child.")]
    ChildBenefit = PaymentPurposeCode.ChildBenefit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a payment to a person who is unemployed/disabled.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_Z5Lppdp-Ed-ak6NoX_4Aeg_1037584216")]
    [Description(@"Transaction is related to a payment to a person who is unemployed/disabled.")]
    UnemploymentDisabilityBenefit = PaymentPurposeCode.UnemploymentDisabilityBenefit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payment of a bonus.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_Z5Lpptp-Ed-ak6NoX_4Aeg_1038504248")]
    [Description(@"Transaction is related to payment of a bonus.")]
    BonusPayment = PaymentPurposeCode.BonusPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z5Lpp9p-Ed-ak6NoX_4Aeg_1038504265")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer = PaymentPurposeCode.CashManagementTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to capital building fringe fortune, ie capital building for retirement.
    /// Encoded/decoded by serializers as &quot;CBFF&quot;.
    /// </summary>
    [EnumMember(Value = "CBFF")]
    [IsoId("_Z5LpqNp-Ed-ak6NoX_4Aeg_1038504308")]
    [Description(@"Transaction is related to capital building fringe fortune, ie capital building for retirement.")]
    CapitalBuilding = PaymentPurposeCode.CapitalBuilding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a payment for charity reasons.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Z5Lpqdp-Ed-ak6NoX_4Aeg_1038504481")]
    [Description(@"Transaction is a payment for charity reasons.")]
    CharityPayment = PaymentPurposeCode.CharityPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a collection of funds initiated via a credit transfer or direct debit.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_Z5VaoNp-Ed-ak6NoX_4Aeg_-1075476839")]
    [Description(@"Transaction is a collection of funds initiated via a credit transfer or direct debit.")]
    CollectionPayment = PaymentPurposeCode.CollectionPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of commodities.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_Z5Vaodp-Ed-ak6NoX_4Aeg_1038504524")]
    [Description(@"Transaction is payment of commodities.")]
    CommodityTransfer = PaymentPurposeCode.CommodityTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit).
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_Z5Vaotp-Ed-ak6NoX_4Aeg_1038504776")]
    [Description(@"Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit).")]
    CommercialPayment = PaymentPurposeCode.CommercialPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of commission.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_Z5Vao9p-Ed-ak6NoX_4Aeg_1038504793")]
    [Description(@"Transaction is payment of commission.")]
    Commission = PaymentPurposeCode.Commission, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to payment of costs.
    /// Encoded/decoded by serializers as &quot;COST&quot;.
    /// </summary>
    [EnumMember(Value = "COST")]
    [IsoId("_Z5VapNp-Ed-ak6NoX_4Aeg_1038505274")]
    [Description(@"Transaction is related to payment of costs.")]
    Costs = PaymentPurposeCode.Costs, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of copyright.
    /// Encoded/decoded by serializers as &quot;CPYR&quot;.
    /// </summary>
    [EnumMember(Value = "CPYR")]
    [IsoId("_Z5Vapdp-Ed-ak6NoX_4Aeg_1038505316")]
    [Description(@"Transaction is payment of copyright.")]
    Copyright = PaymentPurposeCode.Copyright, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_Z5Vaptp-Ed-ak6NoX_4Aeg_1038505334")]
    [Description(@"Transaction is payment of dividends.")]
    Dividend = PaymentPurposeCode.Dividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a foreign exchange operation.
    /// Encoded/decoded by serializers as &quot;FREX&quot;.
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_Z5Vap9p-Ed-ak6NoX_4Aeg_1038505411")]
    [Description(@"Transaction is related to a foreign exchange operation.")]
    ForeignExchange = PaymentPurposeCode.ForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to purchase and sale of goods.
    /// Encoded/decoded by serializers as &quot;GDDS&quot;.
    /// </summary>
    [EnumMember(Value = "GDDS")]
    [IsoId("_Z5VaqNp-Ed-ak6NoX_4Aeg_1038505471")]
    [Description(@"Transaction is related to purchase and sale of goods.")]
    PurchaseSaleOfGoods = PaymentPurposeCode.PurchaseSaleOfGoods, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_Z5Vaqdp-Ed-ak6NoX_4Aeg_1038505506")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment = PaymentPurposeCode.GovernmentPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment for an installment/hire-purchase agreement.
    /// Encoded/decoded by serializers as &quot;IHRP&quot;.
    /// </summary>
    [EnumMember(Value = "IHRP")]
    [IsoId("_Z5fLoNp-Ed-ak6NoX_4Aeg_1038505801")]
    [Description(@"Transaction is payment for an installment/hire-purchase agreement.")]
    InstalmentHirePurchaseAgreement = PaymentPurposeCode.InstalmentHirePurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_Z5fLodp-Ed-ak6NoX_4Aeg_-1450054943")]
    [Description(@"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.")]
    IntraCompanyPayment = PaymentPurposeCode.IntraCompanyPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of an insurance premium.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_Z5fLotp-Ed-ak6NoX_4Aeg_1038505843")]
    [Description(@"Transaction is payment of an insurance premium.")]
    InsurancePremium = PaymentPurposeCode.InsurancePremium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Z5fLo9p-Ed-ak6NoX_4Aeg_1038505878")]
    [Description(@"Transaction is payment of interest.")]
    Interest = PaymentPurposeCode.Interest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is payment of a license fee.
    /// Encoded/decoded by serializers as &quot;LICF&quot;.
    /// </summary>
    [EnumMember(Value = "LICF")]
    [IsoId("_Z5fLpNp-Ed-ak6NoX_4Aeg_1038506169")]
    [Description(@"Transaction is payment of a license fee.")]
    LicenseFee = PaymentPurposeCode.LicenseFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to transfer of loan to borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_Z5fLpdp-Ed-ak6NoX_4Aeg_1038506229")]
    [Description(@"Transaction is related to transfer of loan to borrower.")]
    Loan = PaymentPurposeCode.Loan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to repayment of loan to lender.
    /// Encoded/decoded by serializers as &quot;LOAR&quot;.
    /// </summary>
    [EnumMember(Value = "LOAR")]
    [IsoId("_Z5fLptp-Ed-ak6NoX_4Aeg_1038506264")]
    [Description(@"Transaction is related to repayment of loan to lender.")]
    LoanRepayment = PaymentPurposeCode.LoanRepayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a netting operation.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_Z5fLp9p-Ed-ak6NoX_4Aeg_1038506341")]
    [Description(@"Transaction is related to a netting operation.")]
    Netting = PaymentPurposeCode.Netting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to the payment of payroll.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_Z5fLqNp-Ed-ak6NoX_4Aeg_685678686")]
    [Description(@"Transaction is related to the payment of payroll.")]
    Payroll = PaymentPurposeCode.Payroll, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_Z5fLqdp-Ed-ak6NoX_4Aeg_1038506384")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment = PaymentPurposeCode.PensionPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of a refund.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_Z5oVkNp-Ed-ak6NoX_4Aeg_1038506436")]
    [Description(@"Transaction is the payment of a refund.")]
    Refund = PaymentPurposeCode.Refund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of rent.
    /// Encoded/decoded by serializers as &quot;RENT&quot;.
    /// </summary>
    [EnumMember(Value = "RENT")]
    [IsoId("_Z5oVkdp-Ed-ak6NoX_4Aeg_1038506696")]
    [Description(@"Transaction is the payment of rent.")]
    Rent = PaymentPurposeCode.Rent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of royalties.
    /// Encoded/decoded by serializers as &quot;ROYA&quot;.
    /// </summary>
    [EnumMember(Value = "ROYA")]
    [IsoId("_Z5oVktp-Ed-ak6NoX_4Aeg_1038506731")]
    [Description(@"Transaction is the payment of royalties.")]
    Royalties = PaymentPurposeCode.Royalties, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to purchase and sale of services.
    /// Encoded/decoded by serializers as &quot;SCVE&quot;.
    /// </summary>
    [EnumMember(Value = "SCVE")]
    [IsoId("_Z5oVk9p-Ed-ak6NoX_4Aeg_1038506791")]
    [Description(@"Transaction is related to purchase and sale of services.")]
    PurchaseSaleOfServices = PaymentPurposeCode.PurchaseSaleOfServices, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Z5oVlNp-Ed-ak6NoX_4Aeg_1038507662")]
    [Description(@"Transaction is the payment of securities.")]
    Securities = PaymentPurposeCode.Securities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_Z5oVldp-Ed-ak6NoX_4Aeg_1038507757")]
    [Description(@"Transaction is a social security benefit, ie payment made by a government to support individuals.")]
    SocialSecurityBenefit = PaymentPurposeCode.SocialSecurityBenefit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a payment of information or entertainment services either in printed or electronic form.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_Z5oVltp-Ed-ak6NoX_4Aeg_1039427806")]
    [Description(@"Transaction is related to a payment of information or entertainment services either in printed or electronic form.")]
    Subscription = PaymentPurposeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_Z5oVl9p-Ed-ak6NoX_4Aeg_1039427848")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment = PaymentPurposeCode.TaxPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_Z5oVmNp-Ed-ak6NoX_4Aeg_1039427943")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment = PaymentPurposeCode.ValueAddedTaxPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies.
    /// Encoded/decoded by serializers as &quot;COMT&quot;.
    /// </summary>
    [EnumMember(Value = "COMT")]
    [IsoId("_Z5oVmdp-Ed-ak6NoX_4Aeg_-613715876")]
    [Description(@"Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies.")]
    ConsumerThirdPartyConsolidatedPayment = PaymentPurposeCode.ConsumerThirdPartyConsolidatedPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collection of funds initiated via a debit transfer.
    /// Encoded/decoded by serializers as &quot;DBTC&quot;.
    /// </summary>
    [EnumMember(Value = "DBTC")]
    [IsoId("_Z5oVmtp-Ed-ak6NoX_4Aeg_401232326")]
    [Description(@"Collection of funds initiated via a debit transfer.")]
    DebitCollectionPayment = PaymentPurposeCode.DebitCollectionPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_Z5yGkNp-Ed-ak6NoX_4Aeg_755866699")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment = PaymentPurposeCode.SupplierPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is related to a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_Z5yGkdp-Ed-ak6NoX_4Aeg_1603098882")]
    [Description(@"Transaction is related to a hedging operation.")]
    Hedging = PaymentPurposeCode.Hedging, // same ordinal as derivation source for type conversions
    
}
