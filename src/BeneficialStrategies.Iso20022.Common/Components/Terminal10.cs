// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Terminal performing a card transaction.
/// </summary>
[IsoId("_qDGlYRQVEfC1ZfCQz0xB3g")]
[DisplayName("Terminal10")]
public record Terminal10
{
    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax16Text Identification { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType2Code? Type { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-sub")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public ISO8583AccountEntryDeviceTypeCode? SubType { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-rdcp")]
    [DisplayName("Reading Capability")]
    [IsoXmlTag("RdgCpblty")]
    public SimpleValueList<CardDataReading11Code> ReadingCapability { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-wrcp")]
    [DisplayName("Writing Capability")]
    [IsoXmlTag("WrtgCpblty")]
    public SimpleValueList<CardDataWriting2Code> WritingCapability { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-pnln")]
    [DisplayName("PIN Length Capability")]
    [IsoXmlTag("PINLngthCpblty")]
    public IsoNumber? PINLengthCapability { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-pnec")]
    [DisplayName("PIN Entry Capability")]
    [IsoXmlTag("PINNtryCapblty")]
    public ISO8583PINEntryCapabilityCode? PINEntryCapability { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-acln")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("AprvlCdLngth")]
    public IsoNumber? ApprovalCodeLength { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-mxsl")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoNumber? MaxScriptLength { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-cccp")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-olcp")]
    [DisplayName("On Line Capability")]
    [IsoXmlTag("OnLineCpblty")]
    public OnLineCapability2Code? OnLineCapability { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-mscp")]
    [DisplayName("Message Capability")]
    [IsoXmlTag("MsgCpblty")]
    public ValueList<DisplayCapabilities6> MessageCapability { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-chvc")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public SimpleValueList<CardholderVerificationCapability6Code> CardholderVerificationCapability { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-tmss")]
    [DisplayName("Temporary Secure Storage")]
    [IsoXmlTag("TmpryScrtStrg")]
    public IsoTrueFalseIndicator? TemporarySecureStorage { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-intp")]
    [DisplayName("Integration Type")]
    [IsoXmlTag("IntgrtnTp")]
    public TerminalIntegrationCategory1Code? IntegrationType { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-gelo")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeoLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-outd")]
    [DisplayName("Outdoor")]
    [IsoXmlTag("Outdr")]
    public IsoTrueFalseIndicator? Outdoor { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-offp")]
    [DisplayName("Off Premises")]
    [IsoXmlTag("OffPrmss")]
    public IsoTrueFalseIndicator? OffPremises { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-onbd")]
    [DisplayName("On Board")]
    [IsoXmlTag("OnBrd")]
    public IsoTrueFalseIndicator? OnBoard { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-srnb")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SerlNb")]
    public IsoMax35Text? SerialNumber { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-sftw")]
    [DisplayName("Software")]
    [IsoXmlTag("Sftwr")]
    public ValueList<Software2> Software { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-crti")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    public IsoMax256Text? CertificationIdentification { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-tlen")]
    [DisplayName("Terminal Line Encryption Certified")]
    [IsoXmlTag("TrmnlLineNcrptnCrtfd")]
    public IsoTrueFalseIndicator? TerminalLineEncryptionCertified { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-ukpt")]
    [DisplayName("Unique Key Per Terminal Certified")]
    [IsoXmlTag("UqKeyPerTrmnlCrtfd")]
    public IsoTrueFalseIndicator? UniqueKeyPerTerminalCertified { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-encm")]
    [DisplayName("Encryption Method")]
    [IsoXmlTag("NcrptnMtd")]
    public IsoMax35Text? EncryptionMethod { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-sngt")]
    [DisplayName("Single Tap")]
    [IsoXmlTag("SnglTap")]
    public IsoTrueFalseIndicator? SingleTap { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-ctry")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_qDGlYRQVEfC1ZfCQz0xB3g-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
