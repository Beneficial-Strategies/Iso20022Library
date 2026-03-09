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
/// Commercial agreement in which the buyer agrees to pay the seller an amount of cash. Some aspects of the payment may be defined in the agreement, for example, the method of the payment.
/// </summary>
[IsoId("_64s9gRF-EeSahYR-dAI4lQ")]
[DisplayName("Premium Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PremiumAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PremiumAmount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PremiumAmount3( PremiumQuote1Choice_ reqPremiumQuote,string reqPremiumCurrency,ActiveCurrencyAndAmount reqAmount,System.UInt64 reqDecimalPlaces,System.DateOnly reqPremiumSettlementDate,System.String reqPayerPartyReference,System.String reqReceiverPartyReference )
    {
        PremiumQuote = reqPremiumQuote;
        PremiumCurrency = reqPremiumCurrency;
        Amount = reqAmount;
        DecimalPlaces = reqDecimalPlaces;
        PremiumSettlementDate = reqPremiumSettlementDate;
        PayerPartyReference = reqPayerPartyReference;
        ReceiverPartyReference = reqReceiverPartyReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the calculation method of the premium amount.
    /// </summary>
    [IsoId("_7SevcxF-EeSahYR-dAI4lQ")]
    [DisplayName("Premium Quote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmQt")]
    #endif
    [IsoXmlTag("PrmQt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PremiumQuote1Choice_ PremiumQuote { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PremiumQuote1Choice_ PremiumQuote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PremiumQuote1Choice_ PremiumQuote { get; init; } 
    #else
    public PremiumQuote1Choice_ PremiumQuote { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the premium currency in which the option is held. 
    /// </summary>
    [IsoId("_mvqqIIaXEeSzIqahkBT6cQ")]
    [DisplayName("Premium Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmCcy")]
    #endif
    [IsoXmlTag("PrmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode PremiumCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string PremiumCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string PremiumCurrency { get; init; } 
    #else
    public string PremiumCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the calculation of the premium amount on the basis of the premium quote and one of the amounts of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_7SevdRF-EeSahYR-dAI4lQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_X0udMIGnEeSCANvq7-Awnw")]
    [DisplayName("Decimal Places")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmlPlcs")]
    #endif
    [IsoXmlTag("DcmlPlcs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber DecimalPlaces { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 DecimalPlaces { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 DecimalPlaces { get; init; } 
    #else
    public System.UInt64 DecimalPlaces { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the premium must be settled.
    /// </summary>
    [IsoId("_Ii_qMIcmEeSSpbtwQkzChA")]
    [DisplayName("Premium Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmSttlmDt")]
    #endif
    [IsoXmlTag("PrmSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PremiumSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PremiumSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PremiumSettlementDate { get; init; } 
    #else
    public System.DateOnly PremiumSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Premium fee payer related information.
    /// </summary>
    [IsoId("_BKYN8EUnEeSGWeX3z5zSZQ")]
    [DisplayName("Payer Party Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyerPtyRef")]
    #endif
    [IsoXmlTag("PyerPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PayerPartyReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PayerPartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PayerPartyReference { get; init; } 
    #else
    public System.String PayerPartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Premium fee receiver related information.
    /// </summary>
    [IsoId("_ZC3igEUmEeSGWeX3z5zSZQ")]
    [DisplayName("Receiver Party Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrPtyRef")]
    #endif
    [IsoXmlTag("RcvrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReceiverPartyReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceiverPartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceiverPartyReference { get; init; } 
    #else
    public System.String ReceiverPartyReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
