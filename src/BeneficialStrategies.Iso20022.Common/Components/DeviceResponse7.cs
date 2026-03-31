// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Response7.
/// </summary>
[IsoId("_zU-7EZJEEe6RsYhlPIxpVw")]
[DisplayName("Device Response7")]
public record DeviceResponse7
{
    /// <summary>
    /// Card Reader Application Protocol Data Unit Response.
    /// </summary>
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; }

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext30? Context { get; init; }

    /// <summary>
    /// Display Response.
    /// </summary>
    [DisplayName("Display Response")]
    [IsoXmlTag("DispRspn")]
    public DeviceDisplayResponse2? DisplayResponse { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment80? Environment { get; init; }

    /// <summary>
    /// Initialisation Card Reader Response.
    /// </summary>
    [DisplayName("Initialisation Card Reader Response")]
    [IsoXmlTag("InitlstnCardRdrRspn")]
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; }

    /// <summary>
    /// Input Response.
    /// </summary>
    [DisplayName("Input Response")]
    [IsoXmlTag("InptRspn")]
    public DeviceInputResponse6? InputResponse { get; init; }

    /// <summary>
    /// Print Response.
    /// </summary>
    [DisplayName("Print Response")]
    [IsoXmlTag("PrtRspn")]
    public DevicePrintResponse1? PrintResponse { get; init; }

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Secure Input Response.
    /// </summary>
    [DisplayName("Secure Input Response")]
    [IsoXmlTag("ScrInptRspn")]
    public DeviceSecureInputResponse6? SecureInputResponse { get; init; }

    /// <summary>
    /// Service Content.
    /// </summary>
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService9Code ServiceContent { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transmission Response.
    /// </summary>
    [DisplayName("Transmission Response")]
    [IsoXmlTag("TrnsmssnRspn")]
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; }
}
