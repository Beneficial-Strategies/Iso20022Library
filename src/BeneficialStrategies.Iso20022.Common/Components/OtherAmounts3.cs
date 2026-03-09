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
[IsoId("_STtGCdp-Ed-ak6NoX_4Aeg_2133574697")]
[DisplayName("Other Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherAmounts3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_STtGCtp-Ed-ak6NoX_4Aeg_-1983273927")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection9? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_ST23ANp-Ed-ak6NoX_4Aeg_1314621016")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? ChargesFees { get; init; } 
    #else
    public AmountAndDirection9? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_ST23Adp-Ed-ak6NoX_4Aeg_394587364")]
    [DisplayName("Country National Federal Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryNtlFdrlTax")]
    #endif
    [IsoXmlTag("CtryNtlFdrlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? CountryNationalFederalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? CountryNationalFederalTax { get; init; } 
    #else
    public AmountAndDirection9? CountryNationalFederalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_ST23Atp-Ed-ak6NoX_4Aeg_2080577266")]
    [DisplayName("Trade Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmt")]
    #endif
    [IsoXmlTag("TradAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? TradeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? TradeAmount { get; init; } 
    #else
    public AmountAndDirection9? TradeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_ST23A9p-Ed-ak6NoX_4Aeg_1083504913")]
    [DisplayName("Executing Broker Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgBrkrAmt")]
    #endif
    [IsoXmlTag("ExctgBrkrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? ExecutingBrokerAmount { get; init; } 
    #else
    public AmountAndDirection9? ExecutingBrokerAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_ST23BNp-Ed-ak6NoX_4Aeg_86432560")]
    [DisplayName("Issue Discount Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDscntAllwnc")]
    #endif
    [IsoXmlTag("IsseDscntAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? IssueDiscountAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? IssueDiscountAllowance { get; init; } 
    #else
    public AmountAndDirection9? IssueDiscountAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_ST23Bdp-Ed-ak6NoX_4Aeg_-910639793")]
    [DisplayName("Payment Levy Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtLevyTax")]
    #endif
    [IsoXmlTag("PmtLevyTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? PaymentLevyTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? PaymentLevyTax { get; init; } 
    #else
    public AmountAndDirection9? PaymentLevyTax { get; set; } 
    #endif
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_ST23Btp-Ed-ak6NoX_4Aeg_-1907712146")]
    [DisplayName("Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTax")]
    #endif
    [IsoXmlTag("LclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? LocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? LocalTax { get; init; } 
    #else
    public AmountAndDirection9? LocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_ST23B9p-Ed-ak6NoX_4Aeg_1390182797")]
    [DisplayName("Local Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssn")]
    #endif
    [IsoXmlTag("LclBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection9? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    [IsoId("_ST23CNp-Ed-ak6NoX_4Aeg_393110444")]
    [DisplayName("Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrgn")]
    #endif
    [IsoXmlTag("Mrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? Margin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? Margin { get; init; } 
    #else
    public AmountAndDirection9? Margin { get; set; } 
    #endif
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_ST23Cdp-Ed-ak6NoX_4Aeg_-603961909")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? Other { get; init; } 
    #else
    public AmountAndDirection9? Other { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_SUAA8Np-Ed-ak6NoX_4Aeg_-1601034262")]
    [DisplayName("Postage Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstgAmt")]
    #endif
    [IsoXmlTag("PstgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? PostageAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? PostageAmount { get; init; } 
    #else
    public AmountAndDirection9? PostageAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_SUAA8dp-Ed-ak6NoX_4Aeg_1696860681")]
    [DisplayName("Regulatory Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryAmt")]
    #endif
    [IsoXmlTag("RgltryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? RegulatoryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? RegulatoryAmount { get; init; } 
    #else
    public AmountAndDirection9? RegulatoryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_SUAA8tp-Ed-ak6NoX_4Aeg_699788328")]
    [DisplayName("Shipping Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgAmt")]
    #endif
    [IsoXmlTag("ShppgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? ShippingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? ShippingAmount { get; init; } 
    #else
    public AmountAndDirection9? ShippingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_SUAA89p-Ed-ak6NoX_4Aeg_-297284025")]
    [DisplayName("Special Concession")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclCncssn")]
    #endif
    [IsoXmlTag("SpclCncssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? SpecialConcession { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? SpecialConcession { get; init; } 
    #else
    public AmountAndDirection9? SpecialConcession { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_SUAA9Np-Ed-ak6NoX_4Aeg_-1294356378")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? StampDuty { get; init; } 
    #else
    public AmountAndDirection9? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_SUAA9dp-Ed-ak6NoX_4Aeg_2003538565")]
    [DisplayName("Stock Exchange Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTax")]
    #endif
    [IsoXmlTag("StockXchgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? StockExchangeTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? StockExchangeTax { get; init; } 
    #else
    public AmountAndDirection9? StockExchangeTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_SUAA9tp-Ed-ak6NoX_4Aeg_1006466212")]
    [DisplayName("Transfer Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTax")]
    #endif
    [IsoXmlTag("TrfTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? TransferTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? TransferTax { get; init; } 
    #else
    public AmountAndDirection9? TransferTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_SUAA99p-Ed-ak6NoX_4Aeg_9393859")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? TransactionTax { get; init; } 
    #else
    public AmountAndDirection9? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_SUAA-Np-Ed-ak6NoX_4Aeg_-987678494")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? ValueAddedTax { get; init; } 
    #else
    public AmountAndDirection9? ValueAddedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_SUAA-dp-Ed-ak6NoX_4Aeg_-1984750847")]
    [DisplayName("Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTax")]
    #endif
    [IsoXmlTag("WhldgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? WithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? WithholdingTax { get; init; } 
    #else
    public AmountAndDirection9? WithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    [IsoId("_SUJx8Np-Ed-ak6NoX_4Aeg_1313144096")]
    [DisplayName("Net Gain Loss")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetGnLoss")]
    #endif
    [IsoXmlTag("NetGnLoss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? NetGainLoss { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? NetGainLoss { get; init; } 
    #else
    public AmountAndDirection9? NetGainLoss { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_SUJx8dp-Ed-ak6NoX_4Aeg_316071743")]
    [DisplayName("Consumption Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CsmptnTax")]
    #endif
    [IsoXmlTag("CsmptnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? ConsumptionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? ConsumptionTax { get; init; } 
    #else
    public AmountAndDirection9? ConsumptionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_SUJx8tp-Ed-ak6NoX_4Aeg_-681000610")]
    [DisplayName("Accrued Capitalisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdCptlstnAmt")]
    #endif
    [IsoXmlTag("AcrdCptlstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; } 
    #else
    public AmountAndDirection9? AccruedCapitalisationAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
