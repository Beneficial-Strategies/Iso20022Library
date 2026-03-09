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
/// Identifies other amounts pertaining to the transaction.
/// </summary>
[IsoId("_AkJEUNokEeC60axPepSq7g_-185304496")]
[DisplayName("Other Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherAmounts16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_AkJEUdokEeC60axPepSq7g_-1118097243")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ChargesFees { get; init; } 
    #else
    public AmountAndDirection29? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_AkJEUtokEeC60axPepSq7g_-416420599")]
    [DisplayName("Country National Federal Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryNtlFdrlTax")]
    #endif
    [IsoXmlTag("CtryNtlFdrlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? CountryNationalFederalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? CountryNationalFederalTax { get; init; } 
    #else
    public AmountAndDirection29? CountryNationalFederalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_AkJEU9okEeC60axPepSq7g_1770562925")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ExecutingBrokerAmount { get; init; } 
    #else
    public AmountAndDirection29? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_AkJEVNokEeC60axPepSq7g_951609244")]
    [DisplayName("Issue Discount Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDscntAllwnc")]
    #endif
    [IsoXmlTag("IsseDscntAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? IssueDiscountAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? IssueDiscountAllowance { get; init; } 
    #else
    public AmountAndDirection29? IssueDiscountAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_AkJEVdokEeC60axPepSq7g_-1106815068")]
    [DisplayName("Payment Levy Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtLevyTax")]
    #endif
    [IsoXmlTag("PmtLevyTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? PaymentLevyTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? PaymentLevyTax { get; init; } 
    #else
    public AmountAndDirection29? PaymentLevyTax { get; set; } 
    #endif
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_AkJEVtokEeC60axPepSq7g_-1925768749")]
    [DisplayName("Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTax")]
    #endif
    [IsoXmlTag("LclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalTax { get; init; } 
    #else
    public AmountAndDirection29? LocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_AkSOQNokEeC60axPepSq7g_1080168456")]
    [DisplayName("Local Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssn")]
    #endif
    [IsoXmlTag("LclBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection29? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_AkSOQdokEeC60axPepSq7g_261214775")]
    [DisplayName("Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrgn")]
    #endif
    [IsoXmlTag("Mrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? Margin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? Margin { get; init; } 
    #else
    public AmountAndDirection29? Margin { get; set; } 
    #endif
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_AkSOQtokEeC60axPepSq7g_-1797209537")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? Other { get; init; } 
    #else
    public AmountAndDirection29? Other { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_AkSOQ9okEeC60axPepSq7g_389773987")]
    [DisplayName("Regulatory Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryAmt")]
    #endif
    [IsoXmlTag("RgltryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? RegulatoryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? RegulatoryAmount { get; init; } 
    #else
    public AmountAndDirection29? RegulatoryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_AkSORNokEeC60axPepSq7g_1807363290")]
    [DisplayName("Special Concession")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclCncssn")]
    #endif
    [IsoXmlTag("SpclCncssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? SpecialConcession { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? SpecialConcession { get; init; } 
    #else
    public AmountAndDirection29? SpecialConcession { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_AkSORdokEeC60axPepSq7g_988409609")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? StampDuty { get; init; } 
    #else
    public AmountAndDirection29? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_Akb_QNokEeC60axPepSq7g_-300620482")]
    [DisplayName("Stock Exchange Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTax")]
    #endif
    [IsoXmlTag("StockXchgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? StockExchangeTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? StockExchangeTax { get; init; } 
    #else
    public AmountAndDirection29? StockExchangeTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_Akb_QdokEeC60axPepSq7g_-1119574163")]
    [DisplayName("Transfer Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTax")]
    #endif
    [IsoXmlTag("TrfTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? TransferTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? TransferTax { get; init; } 
    #else
    public AmountAndDirection29? TransferTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_Akb_QtokEeC60axPepSq7g_1116968821")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? TransactionTax { get; init; } 
    #else
    public AmountAndDirection29? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_Akb_Q9okEeC60axPepSq7g_298015140")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ValueAddedTax { get; init; } 
    #else
    public AmountAndDirection29? ValueAddedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Akb_RNokEeC60axPepSq7g_-991014951")]
    [DisplayName("Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTax")]
    #endif
    [IsoXmlTag("WhldgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? WithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? WithholdingTax { get; init; } 
    #else
    public AmountAndDirection29? WithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_Akb_RdokEeC60axPepSq7g_-1809968632")]
    [DisplayName("Net Gain Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetGnLoss")]
    #endif
    [IsoXmlTag("NetGnLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? NetGainLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? NetGainLoss { get; init; } 
    #else
    public AmountAndDirection29? NetGainLoss { get; set; } 
    #endif
    
    /// <summary>
    /// A tax on spending on goods and services.
    /// </summary>
    [IsoId("_Akb_RtokEeC60axPepSq7g_426574352")]
    [DisplayName("Consumption Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CsmptnTax")]
    #endif
    [IsoXmlTag("CsmptnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ConsumptionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ConsumptionTax { get; init; } 
    #else
    public AmountAndDirection29? ConsumptionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged for matching and/or confirmation.
    /// </summary>
    [IsoId("_AklwQNokEeC60axPepSq7g_220976439")]
    [DisplayName("Matching Confirmation Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgConfFee")]
    #endif
    [IsoXmlTag("MtchgConfFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? MatchingConfirmationFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? MatchingConfirmationFee { get; init; } 
    #else
    public AmountAndDirection29? MatchingConfirmationFee { get; set; } 
    #endif
    
    /// <summary>
    /// Amount following a foreign exchange conversion.
    /// </summary>
    [IsoId("_AklwQdokEeC60axPepSq7g_-889934980")]
    [DisplayName("Converted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtdAmt")]
    #endif
    [IsoXmlTag("ConvtdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ConvertedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ConvertedAmount { get; init; } 
    #else
    public AmountAndDirection29? ConvertedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_AklwQtokEeC60axPepSq7g_-2065126005")]
    [DisplayName("Original Currency Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCcyAmt")]
    #endif
    [IsoXmlTag("OrgnlCcyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? OriginalCurrencyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? OriginalCurrencyAmount { get; init; } 
    #else
    public AmountAndDirection29? OriginalCurrencyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    [IsoId("_AklwQ9okEeC60axPepSq7g_-869025171")]
    [DisplayName("Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookVal")]
    #endif
    [IsoXmlTag("BookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? BookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? BookValue { get; init; } 
    #else
    public AmountAndDirection29? BookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_AklwRNokEeC60axPepSq7g_-1266427787")]
    [DisplayName("Accrued Capitalisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdCptlstnAmt")]
    #endif
    [IsoXmlTag("AcrdCptlstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? AccruedCapitalisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? AccruedCapitalisationAmount { get; init; } 
    #else
    public AmountAndDirection29? AccruedCapitalisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_AklwRdokEeC60axPepSq7g_-1826667761")]
    [DisplayName("Local Tax Country Specific")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTaxCtrySpcfc1")]
    #endif
    [IsoXmlTag("LclTaxCtrySpcfc1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalTaxCountrySpecific1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalTaxCountrySpecific1 { get; init; } 
    #else
    public AmountAndDirection29? LocalTaxCountrySpecific1 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_AklwRtokEeC60axPepSq7g_-629538772")]
    [DisplayName("Local Tax Country Specific")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTaxCtrySpcfc2")]
    #endif
    [IsoXmlTag("LclTaxCtrySpcfc2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalTaxCountrySpecific2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalTaxCountrySpecific2 { get; init; } 
    #else
    public AmountAndDirection29? LocalTaxCountrySpecific2 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_Aku6MNokEeC60axPepSq7g_655234286")]
    [DisplayName("Local Tax Country Specific")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTaxCtrySpcfc3")]
    #endif
    [IsoXmlTag("LclTaxCtrySpcfc3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalTaxCountrySpecific3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalTaxCountrySpecific3 { get; init; } 
    #else
    public AmountAndDirection29? LocalTaxCountrySpecific3 { get; set; } 
    #endif
    
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    [IsoId("_Aku6MdokEeC60axPepSq7g_354399335")]
    [DisplayName("Local Tax Country Specific")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTaxCtrySpcfc4")]
    #endif
    [IsoXmlTag("LclTaxCtrySpcfc4")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? LocalTaxCountrySpecific4 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? LocalTaxCountrySpecific4 { get; init; } 
    #else
    public AmountAndDirection29? LocalTaxCountrySpecific4 { get; set; } 
    #endif
    
    /// <summary>
    /// Amount paid as result of transactions subject to shared brokerage commissions.
    /// </summary>
    [IsoId("_Aku6MtokEeC60axPepSq7g_1030295959")]
    [DisplayName("Shared Brokerage Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrdBrkrgAmt")]
    #endif
    [IsoXmlTag("ShrdBrkrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? SharedBrokerageAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? SharedBrokerageAmount { get; init; } 
    #else
    public AmountAndDirection29? SharedBrokerageAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total fees related to the trade, with deduction of rebates (on brokerage, commission or differential) granted by the market member (fee amount with tax excluded).
    /// </summary>
    [IsoId("_Aku6M9okEeC60axPepSq7g_796132789")]
    [DisplayName("Market Member Fee Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktMmbFeeAmt")]
    #endif
    [IsoXmlTag("MktMmbFeeAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? MarketMemberFeeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? MarketMemberFeeAmount { get; init; } 
    #else
    public AmountAndDirection29? MarketMemberFeeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that this information is available upon request.
    /// </summary>
    [IsoId("_Aku6NNokEeC60axPepSq7g_-871934786")]
    [DisplayName("Remuneration Amount Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmnrtnAmtReq")]
    #endif
    [IsoXmlTag("RmnrtnAmtReq")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RemunerationAmountRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemunerationAmountRequest { get; init; } 
    #else
    public System.String? RemunerationAmountRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the source and amount of any other remuneration received or to be received by the broker in connection with the transaction.
    /// </summary>
    [IsoId("_Aku6NdokEeC60axPepSq7g_-2143702248")]
    [DisplayName("Remuneration Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmnrtnAmt")]
    #endif
    [IsoXmlTag("RmnrtnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? RemunerationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? RemunerationAmount { get; init; } 
    #else
    public AmountAndDirection29? RemunerationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount to be paid by the lender to the borrower calculated based on the interest rate.
    /// </summary>
    [IsoId("_Aku6NtokEeC60axPepSq7g_-872372487")]
    [DisplayName("Borrowing Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwgIntrstAmt")]
    #endif
    [IsoXmlTag("BrrwgIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? BorrowingInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? BorrowingInterestAmount { get; init; } 
    #else
    public AmountAndDirection29? BorrowingInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount to be paid by the Borrower to the Lender for the securities borrowed calculated based on the bond loan rate.
    /// </summary>
    [IsoId("_Ak4rMNokEeC60axPepSq7g_1194275752")]
    [DisplayName("Borrowing Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwgFee")]
    #endif
    [IsoXmlTag("BrrwgFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? BorrowingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? BorrowingFee { get; init; } 
    #else
    public AmountAndDirection29? BorrowingFee { get; set; } 
    #endif
    
    /// <summary>
    /// Net market value of the securities lent used to calculate the collateral amount.
    /// </summary>
    [IsoId("_Ak4rMdokEeC60axPepSq7g_-945645155")]
    [DisplayName("Net Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetMktVal")]
    #endif
    [IsoXmlTag("NetMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? NetMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? NetMarketValue { get; init; } 
    #else
    public AmountAndDirection29? NetMarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining nominal value of a security.
    /// </summary>
    [IsoId("_Ak4rMtokEeC60axPepSq7g_-653776665")]
    [DisplayName("Remaining Face Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngFaceVal")]
    #endif
    [IsoXmlTag("RmngFaceVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? RemainingFaceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? RemainingFaceValue { get; init; } 
    #else
    public AmountAndDirection29? RemainingFaceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining value at which an asset is carried on a balance sheet.
    /// </summary>
    [IsoId("_Ak4rM9okEeC60axPepSq7g_-1340367681")]
    [DisplayName("Remaining Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngBookVal")]
    #endif
    [IsoXmlTag("RmngBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? RemainingBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? RemainingBookValue { get; init; } 
    #else
    public AmountAndDirection29? RemainingBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a clearing broker.
    /// </summary>
    [IsoId("_Ak4rNNokEeC60axPepSq7g_-1805097640")]
    [DisplayName("Clearing Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBrkrComssn")]
    #endif
    [IsoXmlTag("ClrBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? ClearingBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? ClearingBrokerCommission { get; init; } 
    #else
    public AmountAndDirection29? ClearingBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the deal price and another reference price.
    /// </summary>
    [IsoId("_Ak4rNdokEeC60axPepSq7g_-2083089411")]
    [DisplayName("Difference In Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DiffInPric")]
    #endif
    [IsoXmlTag("DiffInPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? DifferenceInPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? DifferenceInPrice { get; init; } 
    #else
    public AmountAndDirection29? DifferenceInPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that the odd-lot differential or equivalent fee has been paid by such customer in connection with the execution of an order for an odd-lot number of shares or units (or principal amount) of a security and the fact that the amount of any such differential or fee will be furnished upon oral or written request.
    /// </summary>
    [IsoId("_AlCcMNokEeC60axPepSq7g_-2089465782")]
    [DisplayName("Odd Lot Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OddLotFee")]
    #endif
    [IsoXmlTag("OddLotFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OddLotFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OddLotFee { get; init; } 
    #else
    public System.String? OddLotFee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
