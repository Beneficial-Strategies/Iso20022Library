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
[IsoId("_cpWxUU0uEeybj420QgWBkA")]
[DisplayName("Message Status Response Data")]
public record MessageStatusResponseData6
{
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_cwG5kU0uEeybj420QgWBkA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_cwG5k00uEeybj420QgWBkA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; }

    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_cwG5lU0uEeybj420QgWBkA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType11 TransactionResponse { get; init; }

    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_cwG5l00uEeybj420QgWBkA")]
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; }

    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_cwG5mU0uEeybj420QgWBkA")]
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse4? RepeatedPaymentResponse { get; init; }

    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_cwG5m00uEeybj420QgWBkA")]
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse6? RepeatedReversalResponse { get; init; }

    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_cwG5nU0uEeybj420QgWBkA")]
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse5? RepeatedStoredValueResponse { get; init; }

    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_cwG5n00uEeybj420QgWBkA")]
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_cwG5oU0uEeybj420QgWBkA")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; }
}
