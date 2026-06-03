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
[IsoId("_IvaAEWP2EfCX7uJiAWHfoQ")]
[DisplayName("Terminal13")]
public record Terminal13
{
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax16Text? Identification { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType2Code? Type { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-sub")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public ISO8583AccountEntryDeviceTypeCode? SubType { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-rdcp")]
    [DisplayName("Reading Capability")]
    [IsoXmlTag("RdgCpblty")]
    public SimpleValueList<CardDataReading11Code> ReadingCapability { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-wrcp")]
    [DisplayName("Writing Capability")]
    [IsoXmlTag("WrtgCpblty")]
    public SimpleValueList<CardDataWriting2Code> WritingCapability { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pnln")]
    [DisplayName("PIN Length Capability")]
    [IsoXmlTag("PINLngthCpblty")]
    public IsoNumber? PINLengthCapability { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pnsc")]
    [DisplayName("PIN Entry Security Characteristic")]
    [IsoXmlTag("PINNtrySctyCrtrstc")]
    public ISO8583PINEntryCapabilityCode? PINEntrySecurityCharacteristic { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-acln")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("AprvlCdLngth")]
    public IsoNumber? ApprovalCodeLength { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-mxsl")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoNumber? MaxScriptLength { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-cccp")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-olcp")]
    [DisplayName("On Line Capability")]
    [IsoXmlTag("OnLineCpblty")]
    public OnLineCapability2Code? OnLineCapability { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-mscp")]
    [DisplayName("Message Capability")]
    [IsoXmlTag("MsgCpblty")]
    public ValueList<DisplayCapabilities6> MessageCapability { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-chvc")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public SimpleValueList<CardholderVerificationCapability6Code> CardholderVerificationCapability { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-tmss")]
    [DisplayName("Temporary Secure Storage")]
    [IsoXmlTag("TmpryScrtStrg")]
    public IsoTrueFalseIndicator? TemporarySecureStorage { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-intp")]
    [DisplayName("Integration Type")]
    [IsoXmlTag("IntgrtnTp")]
    public TerminalIntegrationCategory1Code? IntegrationType { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-gelo")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeoLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-outd")]
    [DisplayName("Outdoor")]
    [IsoXmlTag("Outdr")]
    public IsoTrueFalseIndicator? Outdoor { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-offp")]
    [DisplayName("Off Premises")]
    [IsoXmlTag("OffPrmss")]
    public IsoTrueFalseIndicator? OffPremises { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-onbd")]
    [DisplayName("On Board")]
    [IsoXmlTag("OnBrd")]
    public IsoTrueFalseIndicator? OnBoard { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-srnb")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SerlNb")]
    public IsoMax35Text? SerialNumber { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-sftw")]
    [DisplayName("Software")]
    [IsoXmlTag("Sftwr")]
    public ValueList<Software2> Software { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-crti")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    public IsoMax256Text? CertificationIdentification { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-ctry")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
