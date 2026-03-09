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
[IsoId("_TbE9xNp-Ed-ak6NoX_4Aeg_1962942197")]
[DisplayName("Corporate Action Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionAmounts2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionAmounts2( ActiveCurrencyAndAmount reqPostingAmount )
    {
        PostingAmount = reqPostingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_TbE9xdp-Ed-ak6NoX_4Aeg_1108420119")]
    [DisplayName("Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngAmt")]
    #endif
    [IsoXmlTag("PstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PostingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount PostingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_TbE9xtp-Ed-ak6NoX_4Aeg_1962942228")]
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
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_TbE9x9p-Ed-ak6NoX_4Aeg_1962942289")]
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
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_TbE9yNp-Ed-ak6NoX_4Aeg_1962942381")]
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
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_TbE9ydp-Ed-ak6NoX_4Aeg_1962942442")]
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
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_TbOuwNp-Ed-ak6NoX_4Aeg_1962942473")]
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
    [IsoId("_TbOuwdp-Ed-ak6NoX_4Aeg_1962942720")]
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
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_TbOuwtp-Ed-ak6NoX_4Aeg_-1488722281")]
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
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_TbOuw9p-Ed-ak6NoX_4Aeg_1962942751")]
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
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender.
    /// </summary>
    [IsoId("_TbOuxNp-Ed-ak6NoX_4Aeg_1962942783")]
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
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_TbOuxdp-Ed-ak6NoX_4Aeg_1962942843")]
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
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_TbOuxtp-Ed-ak6NoX_4Aeg_1962942896")]
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
    [IsoId("_TbOux9p-Ed-ak6NoX_4Aeg_1962943175")]
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
    [IsoId("_TbOuyNp-Ed-ak6NoX_4Aeg_1962943205")]
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
    /// Cash premium made available if the securities holder consents or participates to an event, for example, consent fees or solicitation fees.
    /// </summary>
    [IsoId("_TbYfwNp-Ed-ak6NoX_4Aeg_1962943267")]
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
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_TbYfwdp-Ed-ak6NoX_4Aeg_1962943328")]
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
    [IsoId("_TbYfwtp-Ed-ak6NoX_4Aeg_1962943358")]
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
    /// Tax on value added.
    /// </summary>
    [IsoId("_TbYfw9p-Ed-ak6NoX_4Aeg_1962943790")]
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
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_TbYfxNp-Ed-ak6NoX_4Aeg_1962944184")]
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
    [IsoId("_TbYfxdp-Ed-ak6NoX_4Aeg_1962944215")]
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
    [IsoId("_TbYfxtp-Ed-ak6NoX_4Aeg_1962944245")]
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
    [IsoId("_TbYfx9p-Ed-ak6NoX_4Aeg_1962944276")]
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
    [IsoId("_TbYfyNp-Ed-ak6NoX_4Aeg_1962944306")]
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
    [IsoId("_TbYfydp-Ed-ak6NoX_4Aeg_1962944307")]
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
    [IsoId("_TbhpsNp-Ed-ak6NoX_4Aeg_1962944337")]
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
    [IsoId("_Tbhpsdp-Ed-ak6NoX_4Aeg_1962944368")]
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
    [IsoId("_Tbhpstp-Ed-ak6NoX_4Aeg_1962944398")]
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
    [IsoId("_Tbhps9p-Ed-ak6NoX_4Aeg_1962944646")]
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
    [IsoId("_TbhptNp-Ed-ak6NoX_4Aeg_1962944677")]
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
    [IsoId("_Tbhptdp-Ed-ak6NoX_4Aeg_1962944707")]
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
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_Tbhpttp-Ed-ak6NoX_4Aeg_1962944708")]
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
    [IsoId("_Tbhpt9p-Ed-ak6NoX_4Aeg_1962944738")]
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
    [IsoId("_TbhpuNp-Ed-ak6NoX_4Aeg_1962944768")]
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
    
    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [IsoId("_Tbhpudp-Ed-ak6NoX_4Aeg_-775765962")]
    [DisplayName("Cash Amount Brought Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtBrghtFwd")]
    #endif
    [IsoXmlTag("CshAmtBrghtFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [IsoId("_TbrasNp-Ed-ak6NoX_4Aeg_-729586515")]
    [DisplayName("Cash Amount Carried Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtCrrdFwd")]
    #endif
    [IsoXmlTag("CshAmtCrrdFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [IsoId("_Tbrasdp-Ed-ak6NoX_4Aeg_-698187232")]
    [DisplayName("Notional Dividend Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlDvddPyblAmt")]
    #endif
    [IsoXmlTag("NtnlDvddPyblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [IsoId("_Tbrastp-Ed-ak6NoX_4Aeg_-670482695")]
    [DisplayName("Notional Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlTaxAmt")]
    #endif
    [IsoXmlTag("NtnlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NotionalTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NotionalTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid by the Tax Authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [IsoId("_Tbras9p-Ed-ak6NoX_4Aeg_-641853945")]
    [DisplayName("Tax Arrears Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxArrearsAmt")]
    #endif
    [IsoXmlTag("TaxArrearsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TaxArrearsAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TaxArrearsAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_TbratNp-Ed-ak6NoX_4Aeg_-538670593")]
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
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_Tbratdp-Ed-ak6NoX_4Aeg_-119130577")]
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
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_Tbrattp-Ed-ak6NoX_4Aeg_-119130002")]
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
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_Tbrat9p-Ed-ak6NoX_4Aeg_-118209598")]
    [DisplayName("Income Portion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPrtn")]
    #endif
    [IsoXmlTag("IncmPrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IncomePortion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IncomePortion { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IncomePortion { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_TbrauNp-Ed-ak6NoX_4Aeg_-118209348")]
    [DisplayName("Stock Exchange Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTax")]
    #endif
    [IsoXmlTag("StockXchgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StockExchangeTax { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StockExchangeTax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_Tbraudp-Ed-ak6NoX_4Aeg_-118208608")]
    [DisplayName("EU Tax Retention Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUTaxRtntnAmt")]
    #endif
    [IsoXmlTag("EUTaxRtntnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_Tb1LsNp-Ed-ak6NoX_4Aeg_120805304")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
