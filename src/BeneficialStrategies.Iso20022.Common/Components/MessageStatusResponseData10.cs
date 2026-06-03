// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the message status response.
/// </summary>
[IsoId("_-_ZXcbZbEfCUZfsQO4rYeA")]
[DisplayName("Message Status Response Data10")]
public record MessageStatusResponseData10
{
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("__AT9dbZbEfCUZfsQO4rYeA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("__AT9e7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; }

    /// <summary>
    /// Specific response of the repeated message sent back by the POI system.
    /// </summary>
    [IsoId("__AT9gbZbEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType11 TransactionResponse { get; init; }

    /// <summary>
    /// Content of the requested loyalty message response.
    /// </summary>
    [IsoId("__AT9h7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; }

    /// <summary>
    /// Content of the requested payment message response.
    /// </summary>
    [IsoId("__AT9jbZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse8? RepeatedPaymentResponse { get; init; }

    /// <summary>
    /// Content of the requested reversal message response.
    /// </summary>
    [IsoId("__AT9k7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse10? RepeatedReversalResponse { get; init; }

    /// <summary>
    /// Content of the requested stored value message response.
    /// </summary>
    [IsoId("__AT9mbZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse9? RepeatedStoredValueResponse { get; init; }

    /// <summary>
    /// Content of the requested card acquisition message response.
    /// </summary>
    [IsoId("__AT9n7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the requested send application protocol data unit card reader message response.
    /// </summary>
    [IsoId("__AT9pbZbEfCUZfsQO4rYeA")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; }
}
