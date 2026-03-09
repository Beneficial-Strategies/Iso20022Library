// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[IsoId("_TeEAUtp-Ed-ak6NoX_4Aeg_1803502106")]
[DisplayName("Corporate Action Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAmounts1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_TeEAU9p-Ed-ak6NoX_4Aeg_2143357834")]
    [DisplayName("Gross Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssCshAmt")]
    #endif
    [IsoXmlTag("GrssCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GrossCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, ie, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_TeEAVNp-Ed-ak6NoX_4Aeg_2143357865")]
    [DisplayName("Net Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshAmt")]
    #endif
    [IsoXmlTag("NetCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NetCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_TeEAVdp-Ed-ak6NoX_4Aeg_2143357888")]
    [DisplayName("Issue Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDscntAmt")]
    #endif
    [IsoXmlTag("IsseDscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IssueDiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IssueDiscountAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IssueDiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_TeEAVtp-Ed-ak6NoX_4Aeg_2143358167")]
    [DisplayName("Solicitation Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFees")]
    #endif
    [IsoXmlTag("SlctnFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SolicitationFees { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, eg, equity.
    /// </summary>
    [IsoId("_TeEAV9p-Ed-ak6NoX_4Aeg_2143358228")]
    [DisplayName("Cash In Lieu Of Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShr")]
    #endif
    [IsoXmlTag("CshInLieuOfShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_TeEAWNp-Ed-ak6NoX_4Aeg_695553989")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_TeNxUNp-Ed-ak6NoX_4Aeg_2143358259")]
    [DisplayName("Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGn")]
    #endif
    [IsoXmlTag("CptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_TeNxUdp-Ed-ak6NoX_4Aeg_2143358598")]
    [DisplayName("Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAmt")]
    #endif
    [IsoXmlTag("IntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? InterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_TeNxUtp-Ed-ak6NoX_4Aeg_2143358660")]
    [DisplayName("Indemnity Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndmntyAmt")]
    #endif
    [IsoXmlTag("IndmntyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IndemnityAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_TeNxU9p-Ed-ak6NoX_4Aeg_2143358690")]
    [DisplayName("Redemption Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPrmAmt")]
    #endif
    [IsoXmlTag("RedPrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender.
    /// </summary>
    [IsoId("_TeNxVNp-Ed-ak6NoX_4Aeg_2143358752")]
    [DisplayName("Manufactured Dividend Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrdDvddAmt")]
    #endif
    [IsoXmlTag("ManfctrdDvddAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ManufacturedDividendAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ManufacturedDividendAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ManufacturedDividendAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, eg, repayment of outstanding debt.
    /// </summary>
    [IsoId("_TeNxVdp-Ed-ak6NoX_4Aeg_2143358782")]
    [DisplayName("Principal Or Corpus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplOrCrps")]
    #endif
    [IsoXmlTag("PrncplOrCrps")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_TeNxVtp-Ed-ak6NoX_4Aeg_2143358843")]
    [DisplayName("Reinvestment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtAmt")]
    #endif
    [IsoXmlTag("RinvstmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_TeNxV9p-Ed-ak6NoX_4Aeg_2143359122")]
    [DisplayName("Market Claim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmAmt")]
    #endif
    [IsoXmlTag("MktClmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_TeNxWNp-Ed-ak6NoX_4Aeg_2143359152")]
    [DisplayName("Fully Franked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdAmt")]
    #endif
    [IsoXmlTag("FullyFrnkdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_TeNxWdp-Ed-ak6NoX_4Aeg_2144279208")]
    [DisplayName("Unfranked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfrnkdAmt")]
    #endif
    [IsoXmlTag("UfrnkdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_TeW7QNp-Ed-ak6NoX_4Aeg_2144279269")]
    [DisplayName("Sundry Or Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndryOrOthrAmt")]
    #endif
    [IsoXmlTag("SndryOrOthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_TeW7Qdp-Ed-ak6NoX_4Aeg_2144279331")]
    [DisplayName("Special Concession Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclCncssnAmt")]
    #endif
    [IsoXmlTag("SpclCncssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SpecialConcessionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SpecialConcessionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SpecialConcessionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_TeW7Qtp-Ed-ak6NoX_4Aeg_2144279392")]
    [DisplayName("Entitled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldAmt")]
    #endif
    [IsoXmlTag("EntitldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, e.g. consent fees.
    /// </summary>
    [IsoId("_TeW7Q9p-Ed-ak6NoX_4Aeg_2144279731")]
    [DisplayName("Cash Incentive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshIncntiv")]
    #endif
    [IsoXmlTag("CshIncntiv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashIncentive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashIncentive { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashIncentive { get; set; } 
    #endif
    
    /// <summary>
    /// Additional costs - coming on top of the subscription costs - which the subscriber should pay as per the subscription process. Not to be used for the subscription cost itself.
    /// </summary>
    [IsoId("_TeW7RNp-Ed-ak6NoX_4Aeg_2144279885")]
    [DisplayName("Additional Subscription Cost")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSbcptCost")]
    #endif
    [IsoXmlTag("AddtlSbcptCost")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AdditionalSubscriptionCost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AdditionalSubscriptionCost { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AdditionalSubscriptionCost { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_TeW7Rdp-Ed-ak6NoX_4Aeg_-1937354060")]
    [DisplayName("Tax Free Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeAmt")]
    #endif
    [IsoXmlTag("TaxFreeAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_TeW7Rtp-Ed-ak6NoX_4Aeg_-1937353750")]
    [DisplayName("Tax Deferred Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDfrrdAmt")]
    #endif
    [IsoXmlTag("TaxDfrrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// </summary>
    [IsoId("_TeW7R9p-Ed-ak6NoX_4Aeg_-1937353659")]
    [DisplayName("German Local Tax 1 Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax1Amt")]
    #endif
    [IsoXmlTag("GrmnLclTax1Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GermanLocalTax1Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GermanLocalTax1Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GermanLocalTax1Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (ZAS Pflichtige Zinsen) interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// </summary>
    [IsoId("_TeW7SNp-Ed-ak6NoX_4Aeg_-1937353567")]
    [DisplayName("German Local Tax 2 Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax2Amt")]
    #endif
    [IsoXmlTag("GrmnLclTax2Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GermanLocalTax2Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GermanLocalTax2Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GermanLocalTax2Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// </summary>
    [IsoId("_TeW7Sdp-Ed-ak6NoX_4Aeg_-1937353505")]
    [DisplayName("German Local Tax 3 Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax3Amt")]
    #endif
    [IsoXmlTag("GrmnLclTax3Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GermanLocalTax3Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GermanLocalTax3Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GermanLocalTax3Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// </summary>
    [IsoId("_TegsQNp-Ed-ak6NoX_4Aeg_-1937353227")]
    [DisplayName("German Local Tax 4 Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrmnLclTax4Amt")]
    #endif
    [IsoXmlTag("GrmnLclTax4Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GermanLocalTax4Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GermanLocalTax4Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GermanLocalTax4Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_TegsQdp-Ed-ak6NoX_4Aeg_-1937353143")]
    [DisplayName("Stock Exchange Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTaxAmt")]
    #endif
    [IsoXmlTag("StockXchgTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StockExchangeTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StockExchangeTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StockExchangeTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_TegsQtp-Ed-ak6NoX_4Aeg_-1937352803")]
    [DisplayName("Transfer Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTaxAmt")]
    #endif
    [IsoXmlTag("TrfTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TransferTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TransferTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TransferTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_TegsQ9p-Ed-ak6NoX_4Aeg_-1937352742")]
    [DisplayName("Transaction Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTaxAmt")]
    #endif
    [IsoXmlTag("TxTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TransactionTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TransactionTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TransactionTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_TegsRNp-Ed-ak6NoX_4Aeg_-1937352650")]
    [DisplayName("Value Added Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTaxAmt")]
    #endif
    [IsoXmlTag("ValAddedTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_TegsRdp-Ed-ak6NoX_4Aeg_-1937352589")]
    [DisplayName("EU Retention Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EURtntnTaxAmt")]
    #endif
    [IsoXmlTag("EURtntnTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? EURetentionTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? EURetentionTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? EURetentionTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_TegsRtp-Ed-ak6NoX_4Aeg_-1937352280")]
    [DisplayName("Local Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTaxAmt")]
    #endif
    [IsoXmlTag("LclTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LocalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LocalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LocalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Payment levy tax.
    /// </summary>
    [IsoId("_TegsR9p-Ed-ak6NoX_4Aeg_-1937352226")]
    [DisplayName("Payment Levy Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtLevyTaxAmt")]
    #endif
    [IsoXmlTag("PmtLevyTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PaymentLevyTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PaymentLevyTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PaymentLevyTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_TegsSNp-Ed-ak6NoX_4Aeg_-1937352134")]
    [DisplayName("Country National Federal Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryNtlFdrlTaxAmt")]
    #endif
    [IsoXmlTag("CtryNtlFdrlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CountryNationalFederalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CountryNationalFederalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CountryNationalFederalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_TegsSdp-Ed-ak6NoX_4Aeg_-1937351825")]
    [DisplayName("Stamp Duty Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyAmt")]
    #endif
    [IsoXmlTag("StmpDtyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StampDutyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_Tep2MNp-Ed-ak6NoX_4Aeg_-1937351733")]
    [DisplayName("Tax Reclaim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmAmt")]
    #endif
    [IsoXmlTag("TaxRclmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_Tep2Mdp-Ed-ak6NoX_4Aeg_-1937351641")]
    [DisplayName("Tax Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtAmt")]
    #endif
    [IsoXmlTag("TaxCdtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2Mtp-Ed-ak6NoX_4Aeg_-1937351580")]
    [DisplayName("Withholding Of Foreign Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfFrgnTaxAmt")]
    #endif
    [IsoXmlTag("WhldgOfFrgnTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2M9p-Ed-ak6NoX_4Aeg_-1937351271")]
    [DisplayName("Withholding Of Local Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgOfLclTaxAmt")]
    #endif
    [IsoXmlTag("WhldgOfLclTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_Tep2NNp-Ed-ak6NoX_4Aeg_-1936431208")]
    [DisplayName("Additional Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTaxAmt")]
    #endif
    [IsoXmlTag("AddtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Tep2Ndp-Ed-ak6NoX_4Aeg_-1936431123")]
    [DisplayName("Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxAmt")]
    #endif
    [IsoXmlTag("WhldgTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_Tep2Ntp-Ed-ak6NoX_4Aeg_-1936431031")]
    [DisplayName("Fiscal Stamp Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmpAmt")]
    #endif
    [IsoXmlTag("FsclStmpAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_Tep2N9p-Ed-ak6NoX_4Aeg_-1248405467")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_Tep2ONp-Ed-ak6NoX_4Aeg_-1248405158")]
    [DisplayName("Paying Agent Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgtComssnAmt")]
    #endif
    [IsoXmlTag("PngAgtComssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_Tep2Odp-Ed-ak6NoX_4Aeg_-1248405066")]
    [DisplayName("Local Broker Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssnAmt")]
    #endif
    [IsoXmlTag("LclBrkrComssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_TeznMNp-Ed-ak6NoX_4Aeg_-1248404974")]
    [DisplayName("Postage Fee Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstgFeeAmt")]
    #endif
    [IsoXmlTag("PstgFeeAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, eg, Securities and Exchange fees.
    /// </summary>
    [IsoId("_TeznMdp-Ed-ak6NoX_4Aeg_-1248404604")]
    [DisplayName("Regulatory Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryFeesAmt")]
    #endif
    [IsoXmlTag("RgltryFeesAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_TeznMtp-Ed-ak6NoX_4Aeg_-1247484541")]
    [DisplayName("Shipping Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgFeesAmt")]
    #endif
    [IsoXmlTag("ShppgFeesAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_TeznM9p-Ed-ak6NoX_4Aeg_-1247484449")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ChargesAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
