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
[IsoId("_fiTKkVS7EeuUvsVXOV79DQ")]
[DisplayName("Message Status Response Data")]
public record MessageStatusResponseData5
{
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_fn-UwVS7EeuUvsVXOV79DQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_fn-Uw1S7EeuUvsVXOV79DQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; }

    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_fn-UxVS7EeuUvsVXOV79DQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType11 TransactionResponse { get; init; }

    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_fn-Ux1S7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse2? RepeatedLoyaltyResponse { get; init; }

    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_fn-UyVS7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse3? RepeatedPaymentResponse { get; init; }

    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_fn-Uy1S7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse5? RepeatedReversalResponse { get; init; }

    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_fn-UzVS7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse4? RepeatedStoredValueResponse { get; init; }

    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_fn-Uz1S7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse2? RepeatedCardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_fn-U0VS7EeuUvsVXOV79DQ")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; }
}
