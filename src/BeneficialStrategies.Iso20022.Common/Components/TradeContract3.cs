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
/// Agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
/// </summary>
[IsoId("_6R7xwbGIEeuSTr8k0UEM8A")]
[DisplayName("Trade Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeContract3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_6SzUcbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDocId")]
    #endif
    [IsoXmlTag("CtrctDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification22? ContractDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type code of the trade contract.
    /// </summary>
    [IsoId("_ZRtPoLb6Eeu9Cp6InX88Vw")]
    [DisplayName("Trade Type Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTpId")]
    #endif
    [IsoXmlTag("TradTpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeTypeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeTypeIdentification { get; init; } 
    #else
    public System.String? TradeTypeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the trade contract.
    /// </summary>
    [IsoId("_6SzUc7GIEeuSTr8k0UEM8A")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_6SzUdbGIEeuSTr8k0UEM8A")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty5> Buyer { get; init; } = new ValueList<TradeParty5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6SzUdbGIEeuSTr8k0UEM8A
    
    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_6SzUd7GIEeuSTr8k0UEM8A")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty5> Seller { get; init; } = new ValueList<TradeParty5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6SzUd7GIEeuSTr8k0UEM8A
    
    /// <summary>
    /// Planned final payment date at the time of issuance.
    /// </summary>
    [IsoId("_6SzUebGIEeuSTr8k0UEM8A")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// When absent, the flag meaning is NotApplicable.
    /// </summary>
    [IsoId("_6SzUe7GIEeuSTr8k0UEM8A")]
    [DisplayName("Prolongation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrlngtnFlg")]
    #endif
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProlongationFlag { get; init; } 
    #else
    public System.String? ProlongationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of the trade contract.
    /// </summary>
    [IsoId("_6SzUfbGIEeuSTr8k0UEM8A")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the trade is being settled.
    /// </summary>
    [IsoId("_6SzUf7GIEeuSTr8k0UEM8A")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_6SzUgbGIEeuSTr8k0UEM8A")]
    [DisplayName("Exchange Rate Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateInf")]
    #endif
    [IsoXmlTag("XchgRateInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    #else
    public ExchangeRate1? ExchangeRateInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Schedule of the payments defined for the trade contract.
    /// </summary>
    [IsoId("_6SzUg7GIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSchdl")]
    #endif
    [IsoXmlTag("PmtSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestPaymentDateRange1? PaymentSchedule { get; init; } 
    #else
    public InterestPaymentDateRange1? PaymentSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Schedule of the shipment.
    /// </summary>
    [IsoId("_6SzUhbGIEeuSTr8k0UEM8A")]
    [DisplayName("Shipment Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipmntSchdl")]
    #endif
    [IsoXmlTag("ShipmntSchdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; } 
    #else
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the trade contract.
    /// </summary>
    [IsoId("_6SzUh7GIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation5? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
