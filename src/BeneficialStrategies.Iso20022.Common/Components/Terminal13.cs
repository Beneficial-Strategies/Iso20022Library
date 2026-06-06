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
    /// <summary>
    /// Identification of the terminal.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax16Text? Identification { get; init; }

    /// <summary>
    /// Type of terminal. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType2Code? Type { get; init; }

    /// <summary>
    /// Other type of terminal.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-sub")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public ISO8583AccountEntryDeviceTypeCode? SubType { get; init; }

    /// <summary>
    /// Card reading capability of the terminal performing the transaction. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-rdcp")]
    [DisplayName("Reading Capability")]
    [IsoXmlTag("RdgCpblty")]
    public SimpleValueList<CardDataReading11Code> ReadingCapability { get; init; } = [];

    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-wrcp")]
    [DisplayName("Writing Capability")]
    [IsoXmlTag("WrtgCpblty")]
    public SimpleValueList<CardDataWriting2Code> WritingCapability { get; init; } = [];

    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pnln")]
    [DisplayName("PIN Length Capability")]
    [IsoXmlTag("PINLngthCpblty")]
    public IsoNumber? PINLengthCapability { get; init; }

    /// <summary>
    /// Security characteristic of the PIN Entry device solution.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pnsc")]
    [DisplayName("PIN Entry Security Characteristic")]
    [IsoXmlTag("PINNtrySctyCrtrstc")]
    public ISO8583PINEntryCapabilityCode? PINEntrySecurityCharacteristic { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-acln")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("AprvlCdLngth")]
    public IsoNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-mxsl")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// Indicates whether the terminal can capture cards or not.|True: The terminal is able to capture cards|False: The terminal is not able to capture cards.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-cccp")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// Capability of the terminal to go online.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-olcp")]
    [DisplayName("On Line Capability")]
    [IsoXmlTag("OnLineCpblty")]
    public OnLineCapability2Code? OnLineCapability { get; init; }

    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-mscp")]
    [DisplayName("Message Capability")]
    [IsoXmlTag("MsgCpblty")]
    public ValueList<DisplayCapabilities6> MessageCapability { get; init; } = [];

    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-chvc")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public SimpleValueList<CardholderVerificationCapability6Code> CardholderVerificationCapability { get; init; } = [];

    /// <summary>
    /// Terminal is capable of temporary secure storage of the card details for reuse upon permission of the card issuer.|Default meaning when not present: false.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-tmss")]
    [DisplayName("Temporary Secure Storage")]
    [IsoXmlTag("TmpryScrtStrg")]
    public IsoTrueFalseIndicator? TemporarySecureStorage { get; init; }

    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-intp")]
    [DisplayName("Integration Type")]
    [IsoXmlTag("IntgrtnTp")]
    public TerminalIntegrationCategory1Code? IntegrationType { get; init; }

    /// <summary>
    /// Geographic location of the terminal.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-gelo")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeoLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }

    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.|True: The terminal is operated outdoor|False: The terminal is operated indoor
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-outd")]
    [DisplayName("Outdoor")]
    [IsoXmlTag("Outdr")]
    public IsoTrueFalseIndicator? Outdoor { get; init; }

    /// <summary>
    /// Indicates whether the terminal is operated on- or off-premises at the point of service.|True: The terminal is operated off premises.|False: The terminal is operated on premises.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-offp")]
    [DisplayName("Off Premises")]
    [IsoXmlTag("OffPrmss")]
    public IsoTrueFalseIndicator? OffPremises { get; init; }

    /// <summary>
    /// Indicates whether the transaction was performed on board.||True: The terminal is located on board.|False: The terminal is not located on board.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-onbd")]
    [DisplayName("On Board")]
    [IsoXmlTag("OnBrd")]
    public IsoTrueFalseIndicator? OnBoard { get; init; }

    /// <summary>
    /// Serial number identifying an occurrence of an hardware component.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-srnb")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SerlNb")]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Terminal software information.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-sftw")]
    [DisplayName("Software")]
    [IsoXmlTag("Sftwr")]
    public ValueList<Software2> Software { get; init; } = [];

    /// <summary>
    /// Terminal certification identification.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-crti")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    public IsoMax256Text? CertificationIdentification { get; init; }

    /// <summary>
    /// Country of the terminal.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-ctry")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_IvaAEWP2EfCX7uJiAWHfoQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
