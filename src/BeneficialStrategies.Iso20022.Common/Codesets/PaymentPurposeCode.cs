// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in a payment initiation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z5yGktp-Ed-ak6NoX_4Aeg_1855256934")]
[Description(@"Specifies the type of transaction that resulted in a payment initiation.")]
[Derivations(typeof(PaymentPurpose1Code))]
public enum PaymentPurposeCode
{
    /// <summary>
    /// Transaction is the payment of salaries.
    /// Encoded/decoded by serializers as &quot;SALA&quot;.
    /// </summary>
    [EnumMember(Value = "SALA")]
    [IsoId("_Z5yGk9p-Ed-ak6NoX_4Aeg_1855256994")]
    [Description(@"Transaction is the payment of salaries.")]
    SalaryPayment,
    
    /// <summary>
    /// Transaction is related to treasury operations.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_Z5yGlNp-Ed-ak6NoX_4Aeg_1855257012")]
    [Description(@"Transaction is related to treasury operations.")]
    TreasuryPayment,
    
    /// <summary>
    /// Transaction is an advance payment.
    /// Encoded/decoded by serializers as &quot;ADVA&quot;.
    /// </summary>
    [EnumMember(Value = "ADVA")]
    [IsoId("_Z5yGldp-Ed-ak6NoX_4Aeg_1855257013")]
    [Description(@"Transaction is an advance payment.")]
    AdvancePayment,
    
    /// <summary>
    /// Transaction is related to the agricultural domain.
    /// Encoded/decoded by serializers as &quot;AGRT&quot;.
    /// </summary>
    [EnumMember(Value = "AGRT")]
    [IsoId("_Z5yGltp-Ed-ak6NoX_4Aeg_1855257014")]
    [Description(@"Transaction is related to the agricultural domain.")]
    AgriculturalTransfer,
    
    /// <summary>
    /// Transaction is the payment of alimony.
    /// Encoded/decoded by serializers as &quot;ALMY&quot;.
    /// </summary>
    [EnumMember(Value = "ALMY")]
    [IsoId("_Z5yGl9p-Ed-ak6NoX_4Aeg_1855257029")]
    [Description(@"Transaction is the payment of alimony.")]
    AlimonyPayment,
    
    /// <summary>
    /// Transaction is related to a payment made to assist parent/guardian to maintain child.
    /// Encoded/decoded by serializers as &quot;BECH&quot;.
    /// </summary>
    [EnumMember(Value = "BECH")]
    [IsoId("_Z5yGmNp-Ed-ak6NoX_4Aeg_1855257038")]
    [Description(@"Transaction is related to a payment made to assist parent/guardian to maintain child.")]
    ChildBenefit,
    
    /// <summary>
    /// Transaction is related to a payment to a person who is unemployed/disabled.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_Z57QgNp-Ed-ak6NoX_4Aeg_1855257039")]
    [Description(@"Transaction is related to a payment to a person who is unemployed/disabled.")]
    UnemploymentDisabilityBenefit,
    
    /// <summary>
    /// Transaction is related to payment of a bonus.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_Z57Qgdp-Ed-ak6NoX_4Aeg_1855257047")]
    [Description(@"Transaction is related to payment of a bonus.")]
    BonusPayment,
    
    /// <summary>
    /// Transaction is a general cash management instruction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z57Qgtp-Ed-ak6NoX_4Aeg_1855257055")]
    [Description(@"Transaction is a general cash management instruction.")]
    CashManagementTransfer,
    
    /// <summary>
    /// Transaction is related to capital building fringe fortune, ie capital building for retirement.
    /// Encoded/decoded by serializers as &quot;CBFF&quot;.
    /// </summary>
    [EnumMember(Value = "CBFF")]
    [IsoId("_Z57Qg9p-Ed-ak6NoX_4Aeg_1855257056")]
    [Description(@"Transaction is related to capital building fringe fortune, ie capital building for retirement.")]
    CapitalBuilding,
    
    /// <summary>
    /// Transaction is a payment for charity reasons.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Z57QhNp-Ed-ak6NoX_4Aeg_1855257072")]
    [Description(@"Transaction is a payment for charity reasons.")]
    CharityPayment,
    
    /// <summary>
    /// Transaction is a collection of funds initiated via a credit transfer or direct debit.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_Z57Qhdp-Ed-ak6NoX_4Aeg_1855257073")]
    [Description(@"Transaction is a collection of funds initiated via a credit transfer or direct debit.")]
    CollectionPayment,
    
    /// <summary>
    /// Transaction is payment of commodities.
    /// Encoded/decoded by serializers as &quot;CMDT&quot;.
    /// </summary>
    [EnumMember(Value = "CMDT")]
    [IsoId("_Z57Qhtp-Ed-ak6NoX_4Aeg_1855257074")]
    [Description(@"Transaction is payment of commodities.")]
    CommodityTransfer,
    
    /// <summary>
    /// Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit).
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_Z57Qh9p-Ed-ak6NoX_4Aeg_1855257089")]
    [Description(@"Transaction is related to a payment of commercial credit or debit. (formerly CommercialCredit).")]
    CommercialPayment,
    
    /// <summary>
    /// Transaction is payment of commission.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_Z57QiNp-Ed-ak6NoX_4Aeg_1855257090")]
    [Description(@"Transaction is payment of commission.")]
    Commission,
    
    /// <summary>
    /// Transaction is related to payment of costs.
    /// Encoded/decoded by serializers as &quot;COST&quot;.
    /// </summary>
    [EnumMember(Value = "COST")]
    [IsoId("_Z57Qidp-Ed-ak6NoX_4Aeg_1855257091")]
    [Description(@"Transaction is related to payment of costs.")]
    Costs,
    
    /// <summary>
    /// Transaction is payment of copyright.
    /// Encoded/decoded by serializers as &quot;CPYR&quot;.
    /// </summary>
    [EnumMember(Value = "CPYR")]
    [IsoId("_Z6FBgNp-Ed-ak6NoX_4Aeg_1855257355")]
    [Description(@"Transaction is payment of copyright.")]
    Copyright,
    
    /// <summary>
    /// Transaction is payment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_Z6FBgdp-Ed-ak6NoX_4Aeg_1855257356")]
    [Description(@"Transaction is payment of dividends.")]
    Dividend,
    
    /// <summary>
    /// Transaction is related to a foreign exchange operation.
    /// Encoded/decoded by serializers as &quot;FREX&quot;.
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_Z6FBgtp-Ed-ak6NoX_4Aeg_1855257357")]
    [Description(@"Transaction is related to a foreign exchange operation.")]
    ForeignExchange,
    
    /// <summary>
    /// Transaction is related to purchase and sale of goods.
    /// Encoded/decoded by serializers as &quot;GDDS&quot;.
    /// </summary>
    [EnumMember(Value = "GDDS")]
    [IsoId("_Z6FBg9p-Ed-ak6NoX_4Aeg_1855257380")]
    [Description(@"Transaction is related to purchase and sale of goods.")]
    PurchaseSaleOfGoods,
    
    /// <summary>
    /// Transaction is a payment to or from a government department.
    /// Encoded/decoded by serializers as &quot;GOVT&quot;.
    /// </summary>
    [EnumMember(Value = "GOVT")]
    [IsoId("_Z6FBhNp-Ed-ak6NoX_4Aeg_1855257381")]
    [Description(@"Transaction is a payment to or from a government department.")]
    GovernmentPayment,
    
    /// <summary>
    /// Transaction is payment for an installment/hire-purchase agreement.
    /// Encoded/decoded by serializers as &quot;IHRP&quot;.
    /// </summary>
    [EnumMember(Value = "IHRP")]
    [IsoId("_Z6FBhdp-Ed-ak6NoX_4Aeg_1855257382")]
    [Description(@"Transaction is payment for an installment/hire-purchase agreement.")]
    InstalmentHirePurchaseAgreement,
    
    /// <summary>
    /// Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_Z6FBhtp-Ed-ak6NoX_4Aeg_1855257383")]
    [Description(@"Transaction is an intra-company payment, ie, a payment between two companies belonging to the same group.")]
    IntraCompanyPayment,
    
    /// <summary>
    /// Transaction is payment of an insurance premium.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_Z6FBh9p-Ed-ak6NoX_4Aeg_1855257397")]
    [Description(@"Transaction is payment of an insurance premium.")]
    InsurancePremium,
    
    /// <summary>
    /// Transaction is payment of interest.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Z6FBiNp-Ed-ak6NoX_4Aeg_1855257432")]
    [Description(@"Transaction is payment of interest.")]
    Interest,
    
    /// <summary>
    /// Transaction is payment of a license fee.
    /// Encoded/decoded by serializers as &quot;LICF&quot;.
    /// </summary>
    [EnumMember(Value = "LICF")]
    [IsoId("_Z6FBidp-Ed-ak6NoX_4Aeg_1855257450")]
    [Description(@"Transaction is payment of a license fee.")]
    LicenseFee,
    
    /// <summary>
    /// Transaction is related to transfer of loan to borrower.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_Z6OygNp-Ed-ak6NoX_4Aeg_1855257458")]
    [Description(@"Transaction is related to transfer of loan to borrower.")]
    Loan,
    
    /// <summary>
    /// Transaction is related to repayment of loan to lender.
    /// Encoded/decoded by serializers as &quot;LOAR&quot;.
    /// </summary>
    [EnumMember(Value = "LOAR")]
    [IsoId("_Z6Oygdp-Ed-ak6NoX_4Aeg_1855257475")]
    [Description(@"Transaction is related to repayment of loan to lender.")]
    LoanRepayment,
    
    /// <summary>
    /// Transaction is related to a netting operation.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_Z6Oygtp-Ed-ak6NoX_4Aeg_1855257476")]
    [Description(@"Transaction is related to a netting operation.")]
    Netting,
    
    /// <summary>
    /// Transaction is related to the payment of payroll.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_Z6Oyg9p-Ed-ak6NoX_4Aeg_1855257477")]
    [Description(@"Transaction is related to the payment of payroll.")]
    Payroll,
    
    /// <summary>
    /// Transaction is the payment of pension.
    /// Encoded/decoded by serializers as &quot;PENS&quot;.
    /// </summary>
    [EnumMember(Value = "PENS")]
    [IsoId("_Z6OyhNp-Ed-ak6NoX_4Aeg_1855257492")]
    [Description(@"Transaction is the payment of pension.")]
    PensionPayment,
    
    /// <summary>
    /// Transaction is the payment of a refund.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_Z6Oyhdp-Ed-ak6NoX_4Aeg_1855257493")]
    [Description(@"Transaction is the payment of a refund.")]
    Refund,
    
    /// <summary>
    /// Transaction is the payment of rent.
    /// Encoded/decoded by serializers as &quot;RENT&quot;.
    /// </summary>
    [EnumMember(Value = "RENT")]
    [IsoId("_Z6Oyhtp-Ed-ak6NoX_4Aeg_1855257494")]
    [Description(@"Transaction is the payment of rent.")]
    Rent,
    
    /// <summary>
    /// Transaction is the payment of royalties.
    /// Encoded/decoded by serializers as &quot;ROYA&quot;.
    /// </summary>
    [EnumMember(Value = "ROYA")]
    [IsoId("_Z6Oyh9p-Ed-ak6NoX_4Aeg_1855257510")]
    [Description(@"Transaction is the payment of royalties.")]
    Royalties,
    
    /// <summary>
    /// Transaction is related to purchase and sale of services.
    /// Encoded/decoded by serializers as &quot;SCVE&quot;.
    /// </summary>
    [EnumMember(Value = "SCVE")]
    [IsoId("_Z6OyiNp-Ed-ak6NoX_4Aeg_1855257511")]
    [Description(@"Transaction is related to purchase and sale of services.")]
    PurchaseSaleOfServices,
    
    /// <summary>
    /// Transaction is the payment of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Z6Oyidp-Ed-ak6NoX_4Aeg_1855257512")]
    [Description(@"Transaction is the payment of securities.")]
    Securities,
    
    /// <summary>
    /// Transaction is a social security benefit, ie payment made by a government to support individuals.
    /// Encoded/decoded by serializers as &quot;SSBE&quot;.
    /// </summary>
    [EnumMember(Value = "SSBE")]
    [IsoId("_Z6X8cNp-Ed-ak6NoX_4Aeg_1855257535")]
    [Description(@"Transaction is a social security benefit, ie payment made by a government to support individuals.")]
    SocialSecurityBenefit,
    
    /// <summary>
    /// Transaction is related to a payment of information or entertainment services either in printed or electronic form.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_Z6X8cdp-Ed-ak6NoX_4Aeg_1855257536")]
    [Description(@"Transaction is related to a payment of information or entertainment services either in printed or electronic form.")]
    Subscription,
    
    /// <summary>
    /// Transaction is the payment of taxes.
    /// Encoded/decoded by serializers as &quot;TAXS&quot;.
    /// </summary>
    [EnumMember(Value = "TAXS")]
    [IsoId("_Z6X8ctp-Ed-ak6NoX_4Aeg_1855257537")]
    [Description(@"Transaction is the payment of taxes.")]
    TaxPayment,
    
    /// <summary>
    /// Transaction is the payment of value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_Z6X8c9p-Ed-ak6NoX_4Aeg_1855257552")]
    [Description(@"Transaction is the payment of value added tax.")]
    ValueAddedTaxPayment,
    
    /// <summary>
    /// Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies.
    /// Encoded/decoded by serializers as &quot;COMT&quot;.
    /// </summary>
    [EnumMember(Value = "COMT")]
    [IsoId("_Z6X8dNp-Ed-ak6NoX_4Aeg_1855257553")]
    [Description(@"Transaction is a payment used by a third party who can collect funds to pay on behalf of consumers, ie credit counseling or bill payment companies.")]
    ConsumerThirdPartyConsolidatedPayment,
    
    /// <summary>
    /// Collection of funds initiated via a debit transfer.
    /// Encoded/decoded by serializers as &quot;DBTC&quot;.
    /// </summary>
    [EnumMember(Value = "DBTC")]
    [IsoId("_Z6X8ddp-Ed-ak6NoX_4Aeg_1855257554")]
    [Description(@"Collection of funds initiated via a debit transfer.")]
    DebitCollectionPayment,
    
    /// <summary>
    /// Transaction is related to a payment to a supplier.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_Z6X8dtp-Ed-ak6NoX_4Aeg_1855257555")]
    [Description(@"Transaction is related to a payment to a supplier.")]
    SupplierPayment,
    
    /// <summary>
    /// Transaction is related to a hedging operation.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_Z6X8d9p-Ed-ak6NoX_4Aeg_1855257570")]
    [Description(@"Transaction is related to a hedging operation.")]
    Hedging,
    
    /// <summary>
    /// Transaction is related to a payment for multiple service types.
    /// Encoded/decoded by serializers as &quot;MSVC&quot;.
    /// </summary>
    [EnumMember(Value = "MSVC")]
    [IsoId("_Z6X8eNp-Ed-ak6NoX_4Aeg_-1784475784")]
    [Description(@"Transaction is related to a payment for multiple service types.")]
    MultipleServiceTypes,
    
    /// <summary>
    /// Transaction is related to a payment for type of services not specified elsewhere.
    /// Encoded/decoded by serializers as &quot;NOWS&quot;.
    /// </summary>
    [EnumMember(Value = "NOWS")]
    [IsoId("_Z6X8edp-Ed-ak6NoX_4Aeg_-1784475458")]
    [Description(@"Transaction is related to a payment for type of services not specified elsewhere.")]
    NotOtherwiseSpecified,
    
    /// <summary>
    /// Transaction is related to a payment of credit card account.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_Z6htcNp-Ed-ak6NoX_4Aeg_-1784475381")]
    [Description(@"Transaction is related to a payment of credit card account.")]
    CardPayment,
    
    /// <summary>
    /// Transaction is related to a payment of credit card bill.
    /// Encoded/decoded by serializers as &quot;CDBL&quot;.
    /// </summary>
    [EnumMember(Value = "CDBL")]
    [IsoId("_Z6htcdp-Ed-ak6NoX_4Aeg_-1784475328")]
    [Description(@"Transaction is related to a payment of credit card bill.")]
    CreditCardBill,
    
    /// <summary>
    /// Transaction is a payment for ferry related business.
    /// Encoded/decoded by serializers as &quot;FERB&quot;.
    /// </summary>
    [EnumMember(Value = "FERB")]
    [IsoId("_Z6htctp-Ed-ak6NoX_4Aeg_-1784475243")]
    [Description(@"Transaction is a payment for ferry related business.")]
    Ferry,
    
    /// <summary>
    /// Transaction is a payment for air transport related business.
    /// Encoded/decoded by serializers as &quot;AIRB&quot;.
    /// </summary>
    [EnumMember(Value = "AIRB")]
    [IsoId("_Z6htc9p-Ed-ak6NoX_4Aeg_-1784474956")]
    [Description(@"Transaction is a payment for air transport related business.")]
    Air,
    
    /// <summary>
    /// Transaction is a payment for bus transport related business.
    /// Encoded/decoded by serializers as &quot;BUSB&quot;.
    /// </summary>
    [EnumMember(Value = "BUSB")]
    [IsoId("_Z6htdNp-Ed-ak6NoX_4Aeg_-1784474870")]
    [Description(@"Transaction is a payment for bus transport related business.")]
    Bus,
    
    /// <summary>
    /// Transaction is a payment for railway transport related business.
    /// Encoded/decoded by serializers as &quot;RLWY&quot;.
    /// </summary>
    [EnumMember(Value = "RLWY")]
    [IsoId("_Z6htddp-Ed-ak6NoX_4Aeg_-1783554846")]
    [Description(@"Transaction is a payment for railway transport related business.")]
    Railway,
    
    /// <summary>
    /// Transaction is a payment for convalescence care facility services.
    /// Encoded/decoded by serializers as &quot;CVCF&quot;.
    /// </summary>
    [EnumMember(Value = "CVCF")]
    [IsoId("_Z6htdtp-Ed-ak6NoX_4Aeg_-1783554761")]
    [Description(@"Transaction is a payment for convalescence care facility services.")]
    ConvalescentCareFacility,
    
    /// <summary>
    /// Transaction is a payment for dental services.
    /// Encoded/decoded by serializers as &quot;DNTS&quot;.
    /// </summary>
    [EnumMember(Value = "DNTS")]
    [IsoId("_Z6htd9p-Ed-ak6NoX_4Aeg_-1783554691")]
    [Description(@"Transaction is a payment for dental services.")]
    DentalServices,
    
    /// <summary>
    /// Transaction is a payment for anesthesia services.
    /// Encoded/decoded by serializers as &quot;ANTS&quot;.
    /// </summary>
    [EnumMember(Value = "ANTS")]
    [IsoId("_Z6hteNp-Ed-ak6NoX_4Aeg_-1783554606")]
    [Description(@"Transaction is a payment for anesthesia services.")]
    AnesthesiaServices,
    
    /// <summary>
    /// Transaction is a payment for home health care services.
    /// Encoded/decoded by serializers as &quot;HLTC&quot;.
    /// </summary>
    [EnumMember(Value = "HLTC")]
    [IsoId("_Z6htedp-Ed-ak6NoX_4Aeg_-1783554319")]
    [Description(@"Transaction is a payment for home health care services.")]
    HomeHealthCare,
    
    /// <summary>
    /// Transaction is a payment for hospital care services.
    /// Encoded/decoded by serializers as &quot;HSPC&quot;.
    /// </summary>
    [EnumMember(Value = "HSPC")]
    [IsoId("_Z6recNp-Ed-ak6NoX_4Aeg_-1783554234")]
    [Description(@"Transaction is a payment for hospital care services.")]
    HospitalCare,
    
    /// <summary>
    /// Transaction is a payment for intermediate care facility services.
    /// Encoded/decoded by serializers as &quot;ICRF&quot;.
    /// </summary>
    [EnumMember(Value = "ICRF")]
    [IsoId("_Z6recdp-Ed-ak6NoX_4Aeg_-1783553916")]
    [Description(@"Transaction is a payment for intermediate care facility services.")]
    IntermediateCareFacility,
    
    /// <summary>
    /// Transaction is a payment for long-term care facility services.
    /// Encoded/decoded by serializers as &quot;LTCF&quot;.
    /// </summary>
    [EnumMember(Value = "LTCF")]
    [IsoId("_Z6rectp-Ed-ak6NoX_4Aeg_-1783553831")]
    [Description(@"Transaction is a payment for long-term care facility services.")]
    LongTermCareFacility,
    
    /// <summary>
    /// Transaction is a payment for medical care services.
    /// Encoded/decoded by serializers as &quot;MDCS&quot;.
    /// </summary>
    [EnumMember(Value = "MDCS")]
    [IsoId("_Z6rec9p-Ed-ak6NoX_4Aeg_-1783553736")]
    [Description(@"Transaction is a payment for medical care services.")]
    MedicalServices,
    
    /// <summary>
    /// Transaction is a payment for vision care services.
    /// Encoded/decoded by serializers as &quot;VIEW&quot;.
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_Z6redNp-Ed-ak6NoX_4Aeg_-1783553659")]
    [Description(@"Transaction is a payment for vision care services.")]
    VisionCare,
    
    /// <summary>
    /// Transaction is a payment is for use of durable medical equipment.
    /// Encoded/decoded by serializers as &quot;DMEQ&quot;.
    /// </summary>
    [EnumMember(Value = "DMEQ")]
    [IsoId("_Z6reddp-Ed-ak6NoX_4Aeg_-1783553364")]
    [Description(@"Transaction is a payment is for use of durable medical equipment.")]
    DurableMedicaleEquipment,
    
    /// <summary>
    /// Transaction is related to a payment of cable TV bill.
    /// Encoded/decoded by serializers as &quot;CBTV&quot;.
    /// </summary>
    [EnumMember(Value = "CBTV")]
    [IsoId("_Z6redtp-Ed-ak6NoX_4Aeg_-1783553269")]
    [Description(@"Transaction is related to a payment of cable TV bill.")]
    CableTVBill,
    
    /// <summary>
    /// Transaction is related to a payment of electricity bill.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_Z6red9p-Ed-ak6NoX_4Aeg_-1783552944")]
    [Description(@"Transaction is related to a payment of electricity bill.")]
    ElectricityBill,
    
    /// <summary>
    /// Transaction is related to a payment of gas bill.
    /// Encoded/decoded by serializers as &quot;GASB&quot;.
    /// </summary>
    [EnumMember(Value = "GASB")]
    [IsoId("_Z6reeNp-Ed-ak6NoX_4Aeg_-1783552849")]
    [Description(@"Transaction is related to a payment of gas bill.")]
    GasBill,
    
    /// <summary>
    /// Transaction is related to a payment of telephone bill.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_Z60oYNp-Ed-ak6NoX_4Aeg_-1783552771")]
    [Description(@"Transaction is related to a payment of telephone bill.")]
    TelephoneBill,
    
    /// <summary>
    /// Transaction is related to a payment of other telecom related bill.
    /// Encoded/decoded by serializers as &quot;OTLC&quot;.
    /// </summary>
    [EnumMember(Value = "OTLC")]
    [IsoId("_Z60oYdp-Ed-ak6NoX_4Aeg_-1783552676")]
    [Description(@"Transaction is related to a payment of other telecom related bill.")]
    OtherTelecomRelatedBill,
    
    /// <summary>
    /// Transaction is related to a payment of water bill.
    /// Encoded/decoded by serializers as &quot;WTER&quot;.
    /// </summary>
    [EnumMember(Value = "WTER")]
    [IsoId("_Z60oYtp-Ed-ak6NoX_4Aeg_-1783552373")]
    [Description(@"Transaction is related to a payment of water bill.")]
    WaterBill,
    
    /// <summary>
    /// Transaction is related to a payment of study/tuition costs.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_Z60oY9p-Ed-ak6NoX_4Aeg_-1783552278")]
    [Description(@"Transaction is related to a payment of study/tuition costs.")]
    Study,
    
    /// <summary>
    /// Transaction is related to a payment of a price.
    /// Encoded/decoded by serializers as &quot;PRCP&quot;.
    /// </summary>
    [EnumMember(Value = "PRCP")]
    [IsoId("_Z60oZNp-Ed-ak6NoX_4Aeg_-1783551953")]
    [Description(@"Transaction is related to a payment of a price.")]
    PricePayment,
    
    /// <summary>
    /// Transaction is related to a payment of an installment.
    /// Encoded/decoded by serializers as &quot;INSM&quot;.
    /// </summary>
    [EnumMember(Value = "INSM")]
    [IsoId("_Z60oZdp-Ed-ak6NoX_4Aeg_-1783551858")]
    [Description(@"Transaction is related to a payment of an installment.")]
    Installment,
    
    /// <summary>
    /// Transaction is related to a payment of a recurring installment made at regular intervals.
    /// Encoded/decoded by serializers as &quot;RINP&quot;.
    /// </summary>
    [EnumMember(Value = "RINP")]
    [IsoId("_Z60oZtp-Ed-ak6NoX_4Aeg_-1783551763")]
    [Description(@"Transaction is related to a payment of a recurring installment made at regular intervals.")]
    RecurringInstallmentPayment,
    
    /// <summary>
    /// Transaction is related to a payment of opening fee.
    /// Encoded/decoded by serializers as &quot;OFEE&quot;.
    /// </summary>
    [EnumMember(Value = "OFEE")]
    [IsoId("_Z60oZ9p-Ed-ak6NoX_4Aeg_-1783551443")]
    [Description(@"Transaction is related to a payment of opening fee.")]
    OpeningFee,
    
    /// <summary>
    /// Transaction is related to a payment of cancellation fee.
    /// Encoded/decoded by serializers as &quot;CFEE&quot;.
    /// </summary>
    [EnumMember(Value = "CFEE")]
    [IsoId("_Z60oaNp-Ed-ak6NoX_4Aeg_-1783551348")]
    [Description(@"Transaction is related to a payment of cancellation fee.")]
    CancellationFee,
    
    /// <summary>
    /// Transaction is related to a payment of government insurance.
    /// Encoded/decoded by serializers as &quot;GOVI&quot;.
    /// </summary>
    [EnumMember(Value = "GOVI")]
    [IsoId("_Z60oadp-Ed-ak6NoX_4Aeg_-1782631299")]
    [Description(@"Transaction is related to a payment of government insurance.")]
    GovernmentInsurance,
    
    /// <summary>
    /// Transaction is a payment of car insurance premium.
    /// Encoded/decoded by serializers as &quot;INPC&quot;.
    /// </summary>
    [EnumMember(Value = "INPC")]
    [IsoId("_Z6-ZYNp-Ed-ak6NoX_4Aeg_-1782631204")]
    [Description(@"Transaction is a payment of car insurance premium.")]
    InsurancePremiumCar,
    
    /// <summary>
    /// Transaction is a payment of labor insurance.
    /// Encoded/decoded by serializers as &quot;LBRI&quot;.
    /// </summary>
    [EnumMember(Value = "LBRI")]
    [IsoId("_Z6-ZYdp-Ed-ak6NoX_4Aeg_-1782631109")]
    [Description(@"Transaction is a payment of labor insurance.")]
    LaborInsurance,
    
    /// <summary>
    /// Transaction is a payment of life insurance.
    /// Encoded/decoded by serializers as &quot;LIFI&quot;.
    /// </summary>
    [EnumMember(Value = "LIFI")]
    [IsoId("_Z6-ZYtp-Ed-ak6NoX_4Aeg_-1782630797")]
    [Description(@"Transaction is a payment of life insurance.")]
    LifeInsurance,
    
    /// <summary>
    /// Transaction is a payment of property insurance.
    /// Encoded/decoded by serializers as &quot;PPTI&quot;.
    /// </summary>
    [EnumMember(Value = "PPTI")]
    [IsoId("_Z6-ZY9p-Ed-ak6NoX_4Aeg_-1782630695")]
    [Description(@"Transaction is a payment of property insurance.")]
    PropertyInsurance,
    
    /// <summary>
    /// Transaction is a payment of health insurance.
    /// Encoded/decoded by serializers as &quot;HLTI&quot;.
    /// </summary>
    [EnumMember(Value = "HLTI")]
    [IsoId("_Z6-ZZNp-Ed-ak6NoX_4Aeg_-1782630334")]
    [Description(@"Transaction is a payment of health insurance.")]
    HealthInsurance,
    
    /// <summary>
    /// Transaction is a payment of car loan principal payment.
    /// Encoded/decoded by serializers as &quot;CLPR&quot;.
    /// </summary>
    [EnumMember(Value = "CLPR")]
    [IsoId("_Z6-ZZdp-Ed-ak6NoX_4Aeg_-1782630239")]
    [Description(@"Transaction is a payment of car loan principal payment.")]
    CarLoanPrincipalRepayment,
    
    /// <summary>
    /// Transaction is related to a payment of housing loan.
    /// Encoded/decoded by serializers as &quot;HLRP&quot;.
    /// </summary>
    [EnumMember(Value = "HLRP")]
    [IsoId("_Z6-ZZtp-Ed-ak6NoX_4Aeg_-1782630136")]
    [Description(@"Transaction is related to a payment of housing loan.")]
    HousingLoanRepayment,
    
    /// <summary>
    /// Transaction is a payment by a company to a bank for financing social loans to employees.
    /// Encoded/decoded by serializers as &quot;CSLP&quot;.
    /// </summary>
    [EnumMember(Value = "CSLP")]
    [IsoId("_Z6-ZZ9p-Ed-ak6NoX_4Aeg_-1782629824")]
    [Description(@"Transaction is a payment by a company to a bank for financing social loans to employees.")]
    CompanySocialLoanPaymentToBank,
    
    /// <summary>
    /// Transaction is related to a payment of estate tax.
    /// Encoded/decoded by serializers as &quot;ESTX&quot;.
    /// </summary>
    [EnumMember(Value = "ESTX")]
    [IsoId("_Z6-ZaNp-Ed-ak6NoX_4Aeg_-1782629721")]
    [Description(@"Transaction is related to a payment of estate tax.")]
    EstateTax,
    
    /// <summary>
    /// Transaction is related to a payment of housing tax.
    /// Encoded/decoded by serializers as &quot;HSTX&quot;.
    /// </summary>
    [EnumMember(Value = "HSTX")]
    [IsoId("_Z6-Zadp-Ed-ak6NoX_4Aeg_-1782629361")]
    [Description(@"Transaction is related to a payment of housing tax.")]
    HousingTax,
    
    /// <summary>
    /// Transaction is related to a payment of income tax.
    /// Encoded/decoded by serializers as &quot;INTX&quot;.
    /// </summary>
    [EnumMember(Value = "INTX")]
    [IsoId("_Z7HjUNp-Ed-ak6NoX_4Aeg_-1782629266")]
    [Description(@"Transaction is related to a payment of income tax.")]
    IncomeTax,
    
    /// <summary>
    /// Transaction is related to a payment of net income tax.
    /// Encoded/decoded by serializers as &quot;NITX&quot;.
    /// </summary>
    [EnumMember(Value = "NITX")]
    [IsoId("_Z7HjUdp-Ed-ak6NoX_4Aeg_-1782629163")]
    [Description(@"Transaction is related to a payment of net income tax.")]
    NetIncomeTax,
    
    /// <summary>
    /// Transaction is related to a payment of business expenses.
    /// Encoded/decoded by serializers as &quot;BEXP&quot;.
    /// </summary>
    [EnumMember(Value = "BEXP")]
    [IsoId("_Z7HjUtp-Ed-ak6NoX_4Aeg_-1782628834")]
    [Description(@"Transaction is related to a payment of business expenses.")]
    BusinessExpenses,
    
    /// <summary>
    /// Transaction is related to a payment of a trust fund.
    /// Encoded/decoded by serializers as &quot;TRFD&quot;.
    /// </summary>
    [EnumMember(Value = "TRFD")]
    [IsoId("_Z7HjU9p-Ed-ak6NoX_4Aeg_-1782628473")]
    [Description(@"Transaction is related to a payment of a trust fund.")]
    TrustFund,
    
    /// <summary>
    /// Transaction is related to a payment of network charges.
    /// Encoded/decoded by serializers as &quot;NWCH&quot;.
    /// </summary>
    [EnumMember(Value = "NWCH")]
    [IsoId("_Z7HjVNp-Ed-ak6NoX_4Aeg_-1782628258")]
    [Description(@"Transaction is related to a payment of network charges.")]
    NetworkCharge,
    
    /// <summary>
    /// Transaction is related to a payment of network communication.
    /// Encoded/decoded by serializers as &quot;NWCM&quot;.
    /// </summary>
    [EnumMember(Value = "NWCM")]
    [IsoId("_Z7HjVdp-Ed-ak6NoX_4Aeg_-1782627886")]
    [Description(@"Transaction is related to a payment of network communication.")]
    NetworkCommunication,
    
    /// <summary>
    /// Transaction is related to a payment of receipt.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_Z7HjVtp-Ed-ak6NoX_4Aeg_-1781707777")]
    [Description(@"Transaction is related to a payment of receipt.")]
    ReceiptPayment,
    
    /// <summary>
    /// Transaction is related to payment terms specifications.
    /// Encoded/decoded by serializers as &quot;PTSP&quot;.
    /// </summary>
    [EnumMember(Value = "PTSP")]
    [IsoId("_Z7HjV9p-Ed-ak6NoX_4Aeg_-1781707639")]
    [Description(@"Transaction is related to payment terms specifications.")]
    PaymentTerms,
    
    /// <summary>
    /// Other payment purpose.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Z7HjWNp-Ed-ak6NoX_4Aeg_-1781707544")]
    [Description(@"Other payment purpose.")]
    Other,
    
    /// <summary>
    /// Transaction is related to a payment of withholding tax.
    /// Encoded/decoded by serializers as &quot;WHLD&quot;.
    /// </summary>
    [EnumMember(Value = "WHLD")]
    [IsoId("_Z7HjWdp-Ed-ak6NoX_4Aeg_-1958265826")]
    [Description(@"Transaction is related to a payment of withholding tax.")]
    WithHolding,
    
}
