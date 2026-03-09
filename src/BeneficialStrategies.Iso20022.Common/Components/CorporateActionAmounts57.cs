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
[IsoId("_-lv4rwVSEeqjd8n6wD9JVw")]
[DisplayName("Corporate Action Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAmounts57
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionAmounts57 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionAmounts57( RestrictedFINActiveCurrencyAndAmount reqPostingAmount )
    {
        PostingAmount = reqPostingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_-lv4swVSEeqjd8n6wD9JVw")]
    [DisplayName("Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngAmt")]
    #endif
    [IsoXmlTag("PstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount PostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_-lv4uwVSEeqjd8n6wD9JVw")]
    [DisplayName("Gross Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssCshAmt")]
    #endif
    [IsoXmlTag("GrssCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_-lv4wwVSEeqjd8n6wD9JVw")]
    [DisplayName("Net Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshAmt")]
    #endif
    [IsoXmlTag("NetCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_-lv4ywVSEeqjd8n6wD9JVw")]
    [DisplayName("Solicitation Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnFees")]
    #endif
    [IsoXmlTag("SlctnFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_-lv40wVSEeqjd8n6wD9JVw")]
    [DisplayName("Cash In Lieu Of Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShr")]
    #endif
    [IsoXmlTag("CshInLieuOfShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_-lv42wVSEeqjd8n6wD9JVw")]
    [DisplayName("Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGn")]
    #endif
    [IsoXmlTag("CptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_-lv44wVSEeqjd8n6wD9JVw")]
    [DisplayName("Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAmt")]
    #endif
    [IsoXmlTag("IntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_-lv46wVSEeqjd8n6wD9JVw")]
    [DisplayName("Market Claim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmAmt")]
    #endif
    [IsoXmlTag("MktClmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_-lv48wVSEeqjd8n6wD9JVw")]
    [DisplayName("Indemnity Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndmntyAmt")]
    #endif
    [IsoXmlTag("IndmntyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_-lv4-wVSEeqjd8n6wD9JVw")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrdDvddPmtAmt")]
    #endif
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_-lv4_QVSEeqjd8n6wD9JVw")]
    [DisplayName("Reinvestment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtAmt")]
    #endif
    [IsoXmlTag("RinvstmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_-lv5BQVSEeqjd8n6wD9JVw")]
    [DisplayName("Fully Franked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullyFrnkdAmt")]
    #endif
    [IsoXmlTag("FullyFrnkdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_-lv5DQVSEeqjd8n6wD9JVw")]
    [DisplayName("Unfranked Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfrnkdAmt")]
    #endif
    [IsoXmlTag("UfrnkdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_-lv5FQVSEeqjd8n6wD9JVw")]
    [DisplayName("Sundry Or Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndryOrOthrAmt")]
    #endif
    [IsoXmlTag("SndryOrOthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_-lv5HQVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax Free Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeAmt")]
    #endif
    [IsoXmlTag("TaxFreeAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_-lv5JQVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax Deferred Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDfrrdAmt")]
    #endif
    [IsoXmlTag("TaxDfrrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_-lv5LQVSEeqjd8n6wD9JVw")]
    [DisplayName("Value Added Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTaxAmt")]
    #endif
    [IsoXmlTag("ValAddedTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_-lv5NQVSEeqjd8n6wD9JVw")]
    [DisplayName("Stamp Duty Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyAmt")]
    #endif
    [IsoXmlTag("StmpDtyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_-lv5PQVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax Reclaim Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRclmAmt")]
    #endif
    [IsoXmlTag("TaxRclmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_-lv5RQVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtAmt")]
    #endif
    [IsoXmlTag("TaxCdtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_-lv5TQVSEeqjd8n6wD9JVw")]
    [DisplayName("Additional Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTaxAmt")]
    #endif
    [IsoXmlTag("AddtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_-lv5VQVSEeqjd8n6wD9JVw")]
    [DisplayName("Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxAmt")]
    #endif
    [IsoXmlTag("WhldgTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_-lv5XQVSEeqjd8n6wD9JVw")]
    [DisplayName("Second Level Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLvlTaxAmt")]
    #endif
    [IsoXmlTag("ScndLvlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_-lv5XwVSEeqjd8n6wD9JVw")]
    [DisplayName("Fiscal Stamp Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclStmpAmt")]
    #endif
    [IsoXmlTag("FsclStmpAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_-lv5ZwVSEeqjd8n6wD9JVw")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_-lv5bwVSEeqjd8n6wD9JVw")]
    [DisplayName("Paying Agent Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgtComssnAmt")]
    #endif
    [IsoXmlTag("PngAgtComssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_-lv5dwVSEeqjd8n6wD9JVw")]
    [DisplayName("Local Broker Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssnAmt")]
    #endif
    [IsoXmlTag("LclBrkrComssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_-lv5fwVSEeqjd8n6wD9JVw")]
    [DisplayName("Regulatory Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryFeesAmt")]
    #endif
    [IsoXmlTag("RgltryFeesAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_-lv5hwVSEeqjd8n6wD9JVw")]
    [DisplayName("Shipping Fees Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgFeesAmt")]
    #endif
    [IsoXmlTag("ShppgFeesAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_-lv5jwVSEeqjd8n6wD9JVw")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [IsoId("_-lv5lwVSEeqjd8n6wD9JVw")]
    [DisplayName("Cash Amount Brought Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtBrghtFwd")]
    #endif
    [IsoXmlTag("CshAmtBrghtFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [IsoId("_-lv5nwVSEeqjd8n6wD9JVw")]
    [DisplayName("Cash Amount Carried Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtCrrdFwd")]
    #endif
    [IsoXmlTag("CshAmtCrrdFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [IsoId("_-lv5pwVSEeqjd8n6wD9JVw")]
    [DisplayName("Notional Dividend Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlDvddPyblAmt")]
    #endif
    [IsoXmlTag("NtnlDvddPyblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [IsoId("_-lv5rwVSEeqjd8n6wD9JVw")]
    [DisplayName("Notional Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlTaxAmt")]
    #endif
    [IsoXmlTag("NtnlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid by the tax authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [IsoId("_-lv5twVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax Arrears Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxArrearsAmt")]
    #endif
    [IsoXmlTag("TaxArrearsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_-lv5vwVSEeqjd8n6wD9JVw")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_-lv5xwVSEeqjd8n6wD9JVw")]
    [DisplayName("Principal Or Corpus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplOrCrps")]
    #endif
    [IsoXmlTag("PrncplOrCrps")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_-lv5zwVSEeqjd8n6wD9JVw")]
    [DisplayName("Redemption Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPrmAmt")]
    #endif
    [IsoXmlTag("RedPrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_-lv51wVSEeqjd8n6wD9JVw")]
    [DisplayName("Income Portion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPrtn")]
    #endif
    [IsoXmlTag("IncmPrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_-lv53wVSEeqjd8n6wD9JVw")]
    [DisplayName("Stock Exchange Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTax")]
    #endif
    [IsoXmlTag("StockXchgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_-lv55wVSEeqjd8n6wD9JVw")]
    [DisplayName("EU Tax Retention Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUTaxRtntnAmt")]
    #endif
    [IsoXmlTag("EUTaxRtntnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_-lv57wVSEeqjd8n6wD9JVw")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_-lv59wVSEeqjd8n6wD9JVw")]
    [DisplayName("Equalisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnAmt")]
    #endif
    [IsoXmlTag("EqulstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_-lv5-QVSEeqjd8n6wD9JVw")]
    [DisplayName("FATCA Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FATCATaxAmt")]
    #endif
    [IsoXmlTag("FATCATaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_-lv5-wVSEeqjd8n6wD9JVw")]
    [DisplayName("NRA Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NRATaxAmt")]
    #endif
    [IsoXmlTag("NRATaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_-lv5_QVSEeqjd8n6wD9JVw")]
    [DisplayName("Back Up Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckUpWhldgTaxAmt")]
    #endif
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_-lv5_wVSEeqjd8n6wD9JVw")]
    [DisplayName("Tax On Income Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxOnIncmAmt")]
    #endif
    [IsoXmlTag("TaxOnIncmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_-lv6AQVSEeqjd8n6wD9JVw")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_-lv6AwVSEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdAmt")]
    #endif
    [IsoXmlTag("DmdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount relating to a foreign income such as a conduit foreign income.
    /// </summary>
    [IsoId("_-lv6BQVSEeqjd8n6wD9JVw")]
    [DisplayName("Foreign Income Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnIncmAmt")]
    #endif
    [IsoXmlTag("FrgnIncmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ForeignIncomeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ForeignIncomeAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ForeignIncomeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Deemed amount resulting from the difference between the rate of dividend proceeds attributed to the security holder for the taxable year and the rate of dividend proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_-lv6BwVSEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Dividend Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdDvddAmt")]
    #endif
    [IsoXmlTag("DmdDvddAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? DeemedDividendAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? DeemedDividendAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? DeemedDividendAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Deemed amount resulting from the difference between the rate of the proceeds components comprising a fund payment attributed to the security holder for the taxable year and the rate of the fund proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_-lv6CQVSEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Fund Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdFndAmt")]
    #endif
    [IsoXmlTag("DmdFndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? DeemedFundAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? DeemedFundAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? DeemedFundAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Deemed amount resulting from the difference between the rate of interest proceeds attributed to the security holder for the taxable year and the rate of interest proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_-lv6CwVSEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdIntrstAmt")]
    #endif
    [IsoXmlTag("DmdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? DeemedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? DeemedInterestAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? DeemedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Deemed amount resulting from the difference between the rate of royalty proceeds attributed to the security holder for the taxable year and the rate of royalty proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_-lv6DQVSEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Royalties Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmdRyltsAmt")]
    #endif
    [IsoXmlTag("DmdRyltsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money debited or credited to adjust for the difference between the estimated and the final subscription rate for Rights Exercise events.
    /// </summary>
    [IsoId("_-lv6DwVSEeqjd8n6wD9JVw")]
    [DisplayName("Adjusted Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdSbcptAmt")]
    #endif
    [IsoXmlTag("AdjstdSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money refunded from the original subscription cost for a Rights Exercise event.  This occurs when the event is prorated and the subscription cost relating to the unaffected (unaccepted) balance is returned to the holder.
    /// </summary>
    [IsoId("_-lv6EQVSEeqjd8n6wD9JVw")]
    [DisplayName("Refunded Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfnddSbcptAmt")]
    #endif
    [IsoXmlTag("RfnddSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
