// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This groups the information of an event, namely of a payment message or status confirmation update. 
/// Usage:
/// It is repeated as many times as there are events to be returned.
/// </summary>
[IsoId("_gmEpkUJREeinU6Cqu8f2Ow")]
[DisplayName("Payment Event")]
public partial record PaymentEvent6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Usage: The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_gmEpn0JREeinU6Cqu8f2Ow")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier From { get; init; } 
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Usage: The receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_gmEpkkJREeinU6Cqu8f2Ow")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? To { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_gmFQh0JREeinU6Cqu8f2Ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_gmEpnEJREeinU6Cqu8f2Ow")]
    [DisplayName("Charge Amount")]
    [IsoXmlTag("ChrgAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    
    /// <summary>
    /// Specifies the exchange rate details between two currencies.
    /// </summary>
    [IsoId("_gmEpnkJREeinU6Cqu8f2Ow")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    
    
    #nullable disable
    
}
