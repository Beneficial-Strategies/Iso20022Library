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
[IsoId("_TUrH0Q0sEeqUVL7sB4m7NA")]
[DisplayName("Device Response")]
public record DeviceResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_TgiZkQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment75? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_TgiZkw0sEeqUVL7sB4m7NA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_TgiZlQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_TgiZlw0sEeqUVL7sB4m7NA")]
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse1? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_TgiZmQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse2? InputResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_TgiZmw0sEeqUVL7sB4m7NA")]
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_TgiZnQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse2? SecureInputResponse { get; init; }

    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_TgiZnw0sEeqUVL7sB4m7NA")]
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_TgiZoQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_TgiZow0sEeqUVL7sB4m7NA")]
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_TgiZpQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_TgiZpw0sEeqUVL7sB4m7NA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
