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
[IsoId("_by2wwYYDEemxIqbaFEE8-w")]
[DisplayName("Device Response")]
public record DeviceResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_b9IuIYYDEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_b9IuI4YDEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_b9IuJYYDEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_b9IuJ4YDEemxIqbaFEE8-w")]
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse1? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_b9IuKYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse1? InputResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_b9IuK4YDEemxIqbaFEE8-w")]
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_b9IuLYYDEemxIqbaFEE8-w")]
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse1? SecureInputResponse { get; init; }

    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_b9IuL4YDEemxIqbaFEE8-w")]
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse1? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_b9IuMYYDEemxIqbaFEE8-w")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_b9IuM4YDEemxIqbaFEE8-w")]
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_b9IuNYYDEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_b9IuN4YDEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
