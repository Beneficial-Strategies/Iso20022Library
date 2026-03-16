// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the transaction at the point of service.
/// </summary>
[IsoId("_S9KGEcSoEeuBjv5G5kw00g")]
[DisplayName("Point Of Service Context")]
public record PointOfServiceContext5
{
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// True: Card physically present during the transaction
    /// False: Card physically absent during the transaction.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-6.
    /// </summary>
    [IsoId("_TCpqEcSoEeuBjv5G5kw00g")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; }

    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// True: Cardholder present during the transaction
    /// False: Cardholder absent during the transaction.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-5
    /// </summary>
    [IsoId("_TCpqE8SoEeuBjv5G5kw00g")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; }

    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not (for example, vending machine, automated fuel dispenser, ATM, kiosk, etc.).
    /// True: Device operated solely by the cardholder
    /// False: Device not operated solely by the cardholder.
    /// ISO 8583:2003 bit 22-3
    /// </summary>
    [IsoId("_TCpqFcSoEeuBjv5G5kw00g")]
    [DisplayName("Cardholder Activated")]
    [IsoXmlTag("CrdhldrActvtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderActivated { get; init; }

    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// True: Transaction initiated through a transponder.
    /// False: Transaction not initiated through a transponder.
    /// </summary>
    [IsoId("_TCpqF8SoEeuBjv5G5kw00g")]
    [DisplayName("Transponder Initiated")]
    [IsoXmlTag("TrnspndrInittd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; }

    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction. When an acceptor’s terminal is semi-attended (for example, multiple terminals supervised by a single clerk), it will be identified as ‘attended’.
    /// True: Attended transaction at the terminal
    /// False: Non-attended transaction at the terminal
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-4
    /// </summary>
    [IsoId("_TCpqGcSoEeuBjv5G5kw00g")]
    [DisplayName("Attended Indicator")]
    [IsoXmlTag("AttnddInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AttendedIndicator { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_TCpqG8SoEeuBjv5G5kw00g")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// True: e-commerce
    /// False: non e-commerce
    /// Default: False
    /// ISO 8583:2003 bit 22-3
    /// </summary>
    [IsoId("_TCqRIcSoEeuBjv5G5kw00g")]
    [DisplayName("E Commerce Indicator")]
    [IsoXmlTag("EComrcInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ECommerceIndicator { get; init; }

    /// <summary>
    /// Contains electronic commerce data.
    /// </summary>
    [IsoId("_TCqRI8SoEeuBjv5G5kw00g")]
    [DisplayName("E Commerce Data")]
    [IsoXmlTag("EComrcData")]
    public ECommerceData1? ECommerceData { get; init; }

    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_N_l-8THMEeyTT91yHXSlSQ")]
    [DisplayName("MOTO Code")]
    [IsoXmlTag("MOTOCd")]
    public MOTO1Code? MOTOCode { get; init; }

    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_Dx1l8THWEeyTT91yHXSlSQ")]
    [DisplayName("Transit Indicator")]
    [IsoXmlTag("TrnstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// True: partial approval is supported
    /// False: partial approval is not supported
    /// </summary>
    [IsoId("_TCqRJ8SoEeuBjv5G5kw00g")]
    [DisplayName("Partial Approval Supported")]
    [IsoXmlTag("PrtlApprvlSpprtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; }

    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// True: The authorisation was delayed
    /// False: The authorisation was not delayed
    /// </summary>
    [IsoId("_TCqRKcSoEeuBjv5G5kw00g")]
    [DisplayName("Delayed Authorisation Indicator")]
    [IsoXmlTag("DelydAuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DelayedAuthorisationIndicator { get; init; }

    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// ISO 8583:2003 bit 22-4
    /// </summary>
    [IsoId("_TCqRK8SoEeuBjv5G5kw00g")]
    [DisplayName("Security Characteristics")]
    [IsoXmlTag("SctyChrtcs")]
    public SecurityCharacteristics1Code? SecurityCharacteristics { get; init; }

    /// <summary>
    /// Other security characteristics.
    /// </summary>
    [IsoId("_TCqRLcSoEeuBjv5G5kw00g")]
    [DisplayName("Other Security Characteristics")]
    [IsoXmlTag("OthrSctyChrtcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherSecurityCharacteristics { get; init; }

    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_TCqRL8SoEeuBjv5G5kw00g")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading10Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_2XTM8cV4Eeua2vd9tJAtHg")]
    [DisplayName("QR Code Presentment Mode")]
    [IsoXmlTag("QRCdPresntmntMd")]
    public QRCodePresentmentMode1Code? QRCodePresentmentMode { get; init; }

    /// <summary>
    /// Other method of QR Code presentment.
    /// </summary>
    [IsoId("_4B5GgcV4Eeua2vd9tJAtHg")]
    [DisplayName("Other QR Code Presentment Mode")]
    [IsoXmlTag("OthrQRCdPresntmntMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherQRCodePresentmentMode { get; init; }

    /// <summary>
    /// Other type of card data entry mode.
    /// </summary>
    [IsoId("_TCqRMcSoEeuBjv5G5kw00g")]
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherCardDataEntryMode { get; init; }

    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_TCqRM8SoEeuBjv5G5kw00g")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StorageLocation { get; init; }

    /// <summary>
    /// Data used to assign specific conditions at the card acceptor location and decided by bilateral agreements.
    /// </summary>
    [IsoId("_TCqRNcSoEeuBjv5G5kw00g")]
    [DisplayName("Special Conditions")]
    [IsoXmlTag("SpclConds")]
    public SpecialConditions1? SpecialConditions { get; init; }

    /// <summary>
    /// Additional point of service context data.
    /// </summary>
    [IsoId("_etypYTECEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
