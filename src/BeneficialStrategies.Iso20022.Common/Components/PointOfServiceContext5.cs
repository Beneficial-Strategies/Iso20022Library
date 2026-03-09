// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the transaction at the point of service.
/// </summary>
[IsoId("_S9KGEcSoEeuBjv5G5kw00g")]
[DisplayName("Point Of Service Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfServiceContext5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// True: Card physically present during the transaction
    /// False: Card physically absent during the transaction.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-6.
    /// </summary>
    [IsoId("_TCpqEcSoEeuBjv5G5kw00g")]
    [DisplayName("Card Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPres")]
    #endif
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardPresent { get; init; } 
    #else
    public System.String? CardPresent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// True: Cardholder present during the transaction
    /// False: Cardholder absent during the transaction.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-5
    /// </summary>
    [IsoId("_TCpqE8SoEeuBjv5G5kw00g")]
    [DisplayName("Cardholder Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrPres")]
    #endif
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardholderPresent { get; init; } 
    #else
    public System.String? CardholderPresent { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the automated device was operated solely by the cardholder or not (for example, vending machine, automated fuel dispenser, ATM, kiosk, etc.).
    /// True: Device operated solely by the cardholder
    /// False: Device not operated solely by the cardholder.
    /// ISO 8583:2003 bit 22-3
    /// </summary>
    [IsoId("_TCpqFcSoEeuBjv5G5kw00g")]
    [DisplayName("Cardholder Activated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrActvtd")]
    #endif
    [IsoXmlTag("CrdhldrActvtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardholderActivated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardholderActivated { get; init; } 
    #else
    public System.String? CardholderActivated { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction initiated through a transponder or not.
    /// True: Transaction initiated through a transponder.
    /// False: Transaction not initiated through a transponder.
    /// </summary>
    [IsoId("_TCpqF8SoEeuBjv5G5kw00g")]
    [DisplayName("Transponder Initiated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnspndrInittd")]
    #endif
    [IsoXmlTag("TrnspndrInittd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TransponderInitiated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransponderInitiated { get; init; } 
    #else
    public System.String? TransponderInitiated { get; set; } 
    #endif
    
    /// <summary>
    /// Card acceptor representative in attendance at the point of service during the transaction. When an acceptor’s terminal is semi-attended (for example, multiple terminals supervised by a single clerk), it will be identified as ‘attended’.
    /// True: Attended transaction at the terminal
    /// False: Non-attended transaction at the terminal
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-4
    /// </summary>
    [IsoId("_TCpqGcSoEeuBjv5G5kw00g")]
    [DisplayName("Attended Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttnddInd")]
    #endif
    [IsoXmlTag("AttnddInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AttendedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttendedIndicator { get; init; } 
    #else
    public System.String? AttendedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_TCpqG8SoEeuBjv5G5kw00g")]
    [DisplayName("Unattended Level Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UattnddLvlCtgy")]
    #endif
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnattendedLevelCategory { get; init; } 
    #else
    public System.String? UnattendedLevelCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the point of service is an e-commerce one or not.
    /// True: e-commerce 
    /// False: non e-commerce 
    /// Default: False
    /// ISO 8583:2003 bit 22-3
    /// </summary>
    [IsoId("_TCqRIcSoEeuBjv5G5kw00g")]
    [DisplayName("E Commerce Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EComrcInd")]
    #endif
    [IsoXmlTag("EComrcInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ECommerceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ECommerceIndicator { get; init; } 
    #else
    public System.String? ECommerceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains electronic commerce data. 
    /// </summary>
    [IsoId("_TCqRI8SoEeuBjv5G5kw00g")]
    [DisplayName("E Commerce Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EComrcData")]
    #endif
    [IsoXmlTag("EComrcData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ECommerceData1? ECommerceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ECommerceData1? ECommerceData { get; init; } 
    #else
    public ECommerceData1? ECommerceData { get; set; } 
    #endif
    
    /// <summary>
    /// A code that identifies the type of MOTO transaction.
    /// </summary>
    [IsoId("_N_l-8THMEeyTT91yHXSlSQ")]
    [DisplayName("MOTO Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MOTOCd")]
    #endif
    [IsoXmlTag("MOTOCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MOTO1Code? MOTOCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MOTO1Code? MOTOCode { get; init; } 
    #else
    public MOTO1Code? MOTOCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a transit transaction.
    /// </summary>
    [IsoId("_Dx1l8THWEeyTT91yHXSlSQ")]
    [DisplayName("Transit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnstInd")]
    #endif
    [IsoXmlTag("TrnstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TransitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransitIndicator { get; init; } 
    #else
    public System.String? TransitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the point of service supports partial approval or not.
    /// True: partial approval is supported
    /// False: partial approval is not supported
    /// </summary>
    [IsoId("_TCqRJ8SoEeuBjv5G5kw00g")]
    [DisplayName("Partial Approval Supported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlApprvlSpprtd")]
    #endif
    [IsoXmlTag("PrtlApprvlSpprtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PartialApprovalSupported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialApprovalSupported { get; init; } 
    #else
    public System.String? PartialApprovalSupported { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the authorisation was delayed due to an on-board initiated transaction.
    /// True: The authorisation was delayed
    /// False: The authorisation was not delayed
    /// </summary>
    [IsoId("_TCqRKcSoEeuBjv5G5kw00g")]
    [DisplayName("Delayed Authorisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DelydAuthstnInd")]
    #endif
    [IsoXmlTag("DelydAuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DelayedAuthorisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelayedAuthorisationIndicator { get; init; } 
    #else
    public System.String? DelayedAuthorisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Security characteristics of the communication link in the card acceptance process.
    /// ISO 8583:2003 bit 22-4
    /// </summary>
    [IsoId("_TCqRK8SoEeuBjv5G5kw00g")]
    [DisplayName("Security Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyChrtcs")]
    #endif
    [IsoXmlTag("SctyChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCharacteristics1Code? SecurityCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCharacteristics1Code? SecurityCharacteristics { get; init; } 
    #else
    public SecurityCharacteristics1Code? SecurityCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Other security characteristics.
    /// </summary>
    [IsoId("_TCqRLcSoEeuBjv5G5kw00g")]
    [DisplayName("Other Security Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrSctyChrtcs")]
    #endif
    [IsoXmlTag("OthrSctyChrtcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherSecurityCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherSecurityCharacteristics { get; init; } 
    #else
    public System.String? OtherSecurityCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the card data for the transaction.
    /// </summary>
    [IsoId("_TCqRL8SoEeuBjv5G5kw00g")]
    [DisplayName("Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardDataNtryMd")]
    #endif
    [IsoXmlTag("CardDataNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading10Code? CardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading10Code? CardDataEntryMode { get; init; } 
    #else
    public CardDataReading10Code? CardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to present a QR Code at the point of service.
    /// </summary>
    [IsoId("_2XTM8cV4Eeua2vd9tJAtHg")]
    [DisplayName("QR Code Presentment Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QRCdPresntmntMd")]
    #endif
    [IsoXmlTag("QRCdPresntmntMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QRCodePresentmentMode1Code? QRCodePresentmentMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QRCodePresentmentMode1Code? QRCodePresentmentMode { get; init; } 
    #else
    public QRCodePresentmentMode1Code? QRCodePresentmentMode { get; set; } 
    #endif
    
    /// <summary>
    /// Other method of QR Code presentment.
    /// </summary>
    [IsoId("_4B5GgcV4Eeua2vd9tJAtHg")]
    [DisplayName("Other QR Code Presentment Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrQRCdPresntmntMd")]
    #endif
    [IsoXmlTag("OthrQRCdPresntmntMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherQRCodePresentmentMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherQRCodePresentmentMode { get; init; } 
    #else
    public System.String? OtherQRCodePresentmentMode { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of card data entry mode.
    /// </summary>
    [IsoId("_TCqRMcSoEeuBjv5G5kw00g")]
    [DisplayName("Other Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCardDataNtryMd")]
    #endif
    [IsoXmlTag("OthrCardDataNtryMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherCardDataEntryMode { get; init; } 
    #else
    public System.String? OtherCardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Storage location of payment credential (for example, Acceptor or third party wallet).
    /// </summary>
    [IsoId("_TCqRM8SoEeuBjv5G5kw00g")]
    [DisplayName("Storage Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StorgLctn")]
    #endif
    [IsoXmlTag("StorgLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StorageLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StorageLocation { get; init; } 
    #else
    public System.String? StorageLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Data used to assign specific conditions at the card acceptor location and decided by bilateral agreements.
    /// </summary>
    [IsoId("_TCqRNcSoEeuBjv5G5kw00g")]
    [DisplayName("Special Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclConds")]
    #endif
    [IsoXmlTag("SpclConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialConditions1? SpecialConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialConditions1? SpecialConditions { get; init; } 
    #else
    public SpecialConditions1? SpecialConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Additional point of service context data.
    /// </summary>
    [IsoId("_etypYTECEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
