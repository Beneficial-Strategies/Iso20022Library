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
[IsoId("_5TXZq5NLEeWGlc8L7oPDIg")]
[DisplayName("Other Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherAmounts33
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
    [IsoId("_5TXZrZNLEeWGlc8L7oPDIg")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection58? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_5TXZtZNLEeWGlc8L7oPDIg")]
    [DisplayName("Charges Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsFees")]
    #endif
    [IsoXmlTag("ChrgsFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? ChargesFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? ChargesFees { get; init; } 
    #else
    public AmountAndDirection58? ChargesFees { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_5TXZvZNLEeWGlc8L7oPDIg")]
    [DisplayName("Country National Federal Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryNtlFdrlTax")]
    #endif
    [IsoXmlTag("CtryNtlFdrlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? CountryNationalFederalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? CountryNationalFederalTax { get; init; } 
    #else
    public AmountAndDirection58? CountryNationalFederalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    [IsoId("_5TXZxZNLEeWGlc8L7oPDIg")]
    [DisplayName("Payment Levy Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtLevyTax")]
    #endif
    [IsoXmlTag("PmtLevyTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? PaymentLevyTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? PaymentLevyTax { get; init; } 
    #else
    public AmountAndDirection58? PaymentLevyTax { get; set; } 
    #endif
    
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_5TXZzZNLEeWGlc8L7oPDIg")]
    [DisplayName("Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTax")]
    #endif
    [IsoXmlTag("LclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? LocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? LocalTax { get; init; } 
    #else
    public AmountAndDirection58? LocalTax { get; set; } 
    #endif
    
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    [IsoId("_5TXZ1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? Other { get; init; } 
    #else
    public AmountAndDirection58? Other { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_5TXZ3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Regulatory Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryAmt")]
    #endif
    [IsoXmlTag("RgltryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? RegulatoryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? RegulatoryAmount { get; init; } 
    #else
    public AmountAndDirection58? RegulatoryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_5TXZ5ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Shipping Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShppgAmt")]
    #endif
    [IsoXmlTag("ShppgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? ShippingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? ShippingAmount { get; init; } 
    #else
    public AmountAndDirection58? ShippingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_5TXZ7ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? StampDuty { get; init; } 
    #else
    public AmountAndDirection58? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_5TXZ9ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Stock Exchange Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchgTax")]
    #endif
    [IsoXmlTag("StockXchgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? StockExchangeTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? StockExchangeTax { get; init; } 
    #else
    public AmountAndDirection58? StockExchangeTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_5TXZ_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Transfer Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTax")]
    #endif
    [IsoXmlTag("TrfTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? TransferTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? TransferTax { get; init; } 
    #else
    public AmountAndDirection58? TransferTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_5TXaBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTax")]
    #endif
    [IsoXmlTag("TxTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? TransactionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? TransactionTax { get; init; } 
    #else
    public AmountAndDirection58? TransactionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    [IsoId("_5TXaDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Value Added Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAddedTax")]
    #endif
    [IsoXmlTag("ValAddedTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? ValueAddedTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? ValueAddedTax { get; init; } 
    #else
    public AmountAndDirection58? ValueAddedTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_5TXaFZNLEeWGlc8L7oPDIg")]
    [DisplayName("Withholding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTax")]
    #endif
    [IsoXmlTag("WhldgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? WithholdingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? WithholdingTax { get; init; } 
    #else
    public AmountAndDirection58? WithholdingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    [IsoId("_5TXaHZNLEeWGlc8L7oPDIg")]
    [DisplayName("Consumption Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CsmptnTax")]
    #endif
    [IsoXmlTag("CsmptnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? ConsumptionTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? ConsumptionTax { get; init; } 
    #else
    public AmountAndDirection58? ConsumptionTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    [IsoId("_5TXaJZNLEeWGlc8L7oPDIg")]
    [DisplayName("Accrued Capitalisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdCptlstnAmt")]
    #endif
    [IsoXmlTag("AcrdCptlstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection58? AccruedCapitalisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection58? AccruedCapitalisationAmount { get; init; } 
    #else
    public AmountAndDirection58? AccruedCapitalisationAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
