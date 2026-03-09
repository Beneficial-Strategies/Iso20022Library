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
/// This groups the information of an event, namely of a payment message or status confirmation update. 
/// Usage:
/// It is repeated as many times as there are events to be returned.
/// </summary>
[IsoId("_gmEpkUJREeinU6Cqu8f2Ow")]
[DisplayName("Payment Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentEvent6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentEvent6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentEvent6( System.String reqFrom )
    {
        From = reqFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Usage: The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_gmEpn0JREeinU6Cqu8f2Ow")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String From { get; init; } 
    #else
    public System.String From { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Usage: The receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_gmEpkkJREeinU6Cqu8f2Ow")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? To { get; init; } 
    #else
    public System.String? To { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_gmFQh0JREeinU6Cqu8f2Ow")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType3Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_gmEpnEJREeinU6Cqu8f2Ow")]
    [DisplayName("Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgAmt")]
    #endif
    [IsoXmlTag("ChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the exchange rate details between two currencies.
    /// </summary>
    [IsoId("_gmEpnkJREeinU6Cqu8f2Ow")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    #else
    public CurrencyExchange12? ForeignExchangeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
