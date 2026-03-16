// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the response of a previous device request.
/// </summary>
[IsoId("_pJ06oXGqEe2TbaNWBpRZpQ")]
[DisplayName("Device Response")]
public record DeviceResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_pQHI0XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment79? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_pQHI03GqEe2TbaNWBpRZpQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext30? Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_pQHI1XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_pQHI13GqEe2TbaNWBpRZpQ")]
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse2? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_pQHI2XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse5? InputResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_pQHI23GqEe2TbaNWBpRZpQ")]
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_pQHI3XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse5? SecureInputResponse { get; init; }

    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_pQHI33GqEe2TbaNWBpRZpQ")]
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_pQHI4XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_pQHI43GqEe2TbaNWBpRZpQ")]
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_pQHI5XGqEe2TbaNWBpRZpQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_pQHI53GqEe2TbaNWBpRZpQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
