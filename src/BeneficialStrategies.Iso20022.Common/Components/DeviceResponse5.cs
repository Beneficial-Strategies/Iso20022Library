// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of Device service to be used with this message.
/// </summary>
[IsoId("_mcri4U6qEeyGi9JAv6wq7Q")]
[DisplayName("Device Response")]
public record DeviceResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_mjEewU6qEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment78? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_mjEew06qEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext29? Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_mjEexU6qEeyGi9JAv6wq7Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_mjEex06qEeyGi9JAv6wq7Q")]
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse2? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_mjEeyU6qEeyGi9JAv6wq7Q")]
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse4? InputResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_mjEey06qEeyGi9JAv6wq7Q")]
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_mjEezU6qEeyGi9JAv6wq7Q")]
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse4? SecureInputResponse { get; init; }

    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_mjEez06qEeyGi9JAv6wq7Q")]
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_mjEe0U6qEeyGi9JAv6wq7Q")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_mjEe006qEeyGi9JAv6wq7Q")]
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_mjEe1U6qEeyGi9JAv6wq7Q")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_mjEe106qEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
