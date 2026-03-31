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
[IsoId("_hevo4S5KEeunNvJlR_vCbg")]
[DisplayName("Device Response")]
public record DeviceResponse4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_hvVpoS5KEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment77? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_hvVpoy5KEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_hvVppS5KEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_hvVppy5KEeunNvJlR_vCbg")]
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse2? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_hvVpqS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse3? InputResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_hvVpqy5KEeunNvJlR_vCbg")]
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_hvVprS5KEeunNvJlR_vCbg")]
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse3? SecureInputResponse { get; init; }

    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_hvVpry5KEeunNvJlR_vCbg")]
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_hvVpsS5KEeunNvJlR_vCbg")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_hvVpsy5KEeunNvJlR_vCbg")]
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_hvVptS5KEeunNvJlR_vCbg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_hvVpty5KEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
