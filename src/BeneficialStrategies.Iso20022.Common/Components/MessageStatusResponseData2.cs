// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message status Response.
/// </summary>
[IsoId("_YEAKUYYMEemxIqbaFEE8-w")]
[DisplayName("Message Status Response Data")]
public partial record MessageStatusResponseData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_YOXAMYYMEemxIqbaFEE8-w")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_YOXAM4YMEemxIqbaFEE8-w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification171 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_YOXANYYMEemxIqbaFEE8-w")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType9 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_YOXAN4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse1? RepeatedLoyaltyResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_YOXAOYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse1? RepeatedPaymentResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_YOXAO4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse1? RepeatedReversalResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_YOXAPYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse2? RepeatedStoredValueResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_YOXAP4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse1? RepeatedCardAcquisitionResponse { get; init; } 
    
    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_YOXAQYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    
    
    #nullable disable
    
}
