// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Terminal9.
/// </summary>
[IsoId("_nrBW0b8REe6tVqdcbD5-mg")]
[DisplayName("Terminal9")]
public record Terminal9
{
    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Approval Code Length.
    /// </summary>
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    public IsoNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Card Capture Capable.
    /// </summary>
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// Cardholder Verification Capability.
    /// </summary>
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public ValueList<CardholderVerificationCapabilities1> CardholderVerificationCapability { get; init; } =
        [];

    /// <summary>
    /// Certification Identification.
    /// </summary>
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    public IsoMax256Text? CertificationIdentification { get; init; }

    /// <summary>
    /// Geographic Location.
    /// </summary>
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax16Text? Identification { get; init; }

    /// <summary>
    /// Integration Type.
    /// </summary>
    [DisplayName("Integration Type")]
    [IsoXmlTag("IntgtnTp")]
    public TerminalIntegrationCategory1Code? IntegrationType { get; init; }

    /// <summary>
    /// Max Script Length.
    /// </summary>
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// Message Capability.
    /// </summary>
    [DisplayName("Message Capability")]
    [IsoXmlTag("MsgCpblty")]
    public ValueList<DisplayCapabilities6> MessageCapability { get; init; } = [];

    /// <summary>
    /// Off Premises.
    /// </summary>
    [DisplayName("Off Premises")]
    [IsoXmlTag("OffPrmiss")]
    public IsoTrueFalseIndicator? OffPremises { get; init; }

    /// <summary>
    /// On Board.
    /// </summary>
    [DisplayName("On Board")]
    [IsoXmlTag("OnBrd")]
    public IsoTrueFalseIndicator? OnBoard { get; init; }

    /// <summary>
    /// On Line Capability.
    /// </summary>
    [DisplayName("On Line Capability")]
    [IsoXmlTag("OnLineCpblty")]
    public OnLineCapability2Code? OnLineCapability { get; init; }

    /// <summary>
    /// Other PIN Entry Security Characteristic.
    /// </summary>
    [DisplayName("Other PIN Entry Security Characteristic")]
    [IsoXmlTag("OthrPINNtrySctyChrtc")]
    public IsoMax35Text? OtherPINEntrySecurityCharacteristic { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Outdoor.
    /// </summary>
    [DisplayName("Outdoor")]
    [IsoXmlTag("Outdr")]
    public IsoTrueFalseIndicator? Outdoor { get; init; }

    /// <summary>
    /// PIN Entry Security Characteristic.
    /// </summary>
    [DisplayName("PIN Entry Security Characteristic")]
    [IsoXmlTag("PINNtrySctyChrtc")]
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; init; }

    /// <summary>
    /// PIN Length Capability.
    /// </summary>
    [DisplayName("PIN Length Capability")]
    [IsoXmlTag("PINLngthCpblty")]
    public IsoNumber? PINLengthCapability { get; init; }

    /// <summary>
    /// Reading Capability.
    /// </summary>
    [DisplayName("Reading Capability")]
    [IsoXmlTag("RdngCpblty")]
    public ValueList<CardReadingCapabilities1> ReadingCapability { get; init; } = [];

    /// <summary>
    /// Serial Number.
    /// </summary>
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Software.
    /// </summary>
    [DisplayName("Software")]
    [IsoXmlTag("Sftwr")]
    public ValueList<Software1> Software { get; init; } = [];

    /// <summary>
    /// Temporary Secure Storage.
    /// </summary>
    [DisplayName("Temporary Secure Storage")]
    [IsoXmlTag("TempScrStorg")]
    public IsoTrueFalseIndicator? TemporarySecureStorage { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType1Code? Type { get; init; }

    /// <summary>
    /// Writing Capability.
    /// </summary>
    [DisplayName("Writing Capability")]
    [IsoXmlTag("WrtgCpblty")]
    public ValueList<CardWritingCapabilities1> WritingCapability { get; init; } = [];
}
