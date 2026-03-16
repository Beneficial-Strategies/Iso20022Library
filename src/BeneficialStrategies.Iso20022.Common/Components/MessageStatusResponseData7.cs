// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message status Response.
/// </summary>
[IsoId("_VigGkXIqEe299ZbWCkdR_w")]
[DisplayName("Message Status Response Data")]
public record MessageStatusResponseData7
{
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_Vp02kXIqEe299ZbWCkdR_w")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_Vp02k3IqEe299ZbWCkdR_w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; }

    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_Vp02lXIqEe299ZbWCkdR_w")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType11 TransactionResponse { get; init; }

    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_Vp02l3IqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; }

    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_Vp02mXIqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse5? RepeatedPaymentResponse { get; init; }

    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_Vp02m3IqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse7? RepeatedReversalResponse { get; init; }

    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_Vp02nXIqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse6? RepeatedStoredValueResponse { get; init; }

    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_Vp02n3IqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_Vp02oXIqEe299ZbWCkdR_w")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; }
}
