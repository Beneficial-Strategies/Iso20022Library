// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
[IsoId("_1MESNTL3EeKU9IrkkToqcw_405434818")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCANOCSDDataSD1V02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number and continuation indicator used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_1MESNjL3EeKU9IrkkToqcw_953243499")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1MESNzL3EeKU9IrkkToqcw_413108357")]
    [DisplayName("Notification General Information Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnGnlInfXtnsn")]
    #endif
    [IsoXmlTag("NtfctnGnlInfXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationSD3? NotificationGeneralInformationExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationSD3? NotificationGeneralInformationExtension { get; init; } 
    #else
    public CorporateActionNotificationSD3? NotificationGeneralInformationExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1MODMDL3EeKU9IrkkToqcw_939060651")]
    [DisplayName("Corporate Action General Information Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInfXtnsn")]
    #endif
    [IsoXmlTag("CorpActnGnlInfXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD9? CorporateActionGeneralInformationExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD9? CorporateActionGeneralInformationExtension { get; init; } 
    #else
    public CorporateActionGeneralInformationSD9? CorporateActionGeneralInformationExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_1MODMTL3EeKU9IrkkToqcw_279330117")]
    [DisplayName("Underlying Security Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygSctyXtnsn")]
    #endif
    [IsoXmlTag("UndrlygSctyXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD6? UnderlyingSecurityExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD6? UnderlyingSecurityExtension { get; init; } 
    #else
    public FinancialInstrumentAttributesSD6? UnderlyingSecurityExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_1MODMjL3EeKU9IrkkToqcw_-613312639")]
    [DisplayName("Corporate Action Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtlsXtnsn")]
    #endif
    [IsoXmlTag("CorpActnDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD3? CorporateActionDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD3? CorporateActionDetailsExtension { get; init; } 
    #else
    public CorporateActionSD3? CorporateActionDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_1MODMzL3EeKU9IrkkToqcw_-972271225")]
    [DisplayName("Corporate Action Date Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtDtlsXtnsn")]
    #endif
    [IsoXmlTag("CorpActnDtDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDateSD3? CorporateActionDateDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDateSD3? CorporateActionDateDetailsExtension { get; init; } 
    #else
    public CorporateActionDateSD3? CorporateActionDateDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_1MODNDL3EeKU9IrkkToqcw_1791320847")]
    [DisplayName("Corporate Action Price Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPricDtlsXtnsn")]
    #endif
    [IsoXmlTag("CorpActnPricDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD3? CorporateActionPriceDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD3? CorporateActionPriceDetailsExtension { get; init; } 
    #else
    public CorporateActionPriceSD3? CorporateActionPriceDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_1MODNTL3EeKU9IrkkToqcw_-573969811")]
    [DisplayName("Corporate Action Period Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPrdDtlsXtnsn")]
    #endif
    [IsoXmlTag("CorpActnPrdDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriodSD1? CorporateActionPeriodDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriodSD1? CorporateActionPeriodDetailsExtension { get; init; } 
    #else
    public CorporateActionPeriodSD1? CorporateActionPeriodDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_1MXNIDL3EeKU9IrkkToqcw_-2139645596")]
    [DisplayName("Corporate Action Rate And Amount Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnRateAndAmtDtlsXtnsn")]
    #endif
    [IsoXmlTag("CorpActnRateAndAmtDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD1? CorporateActionRateAndAmountDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD1? CorporateActionRateAndAmountDetailsExtension { get; init; } 
    #else
    public CorporateActionRateSD1? CorporateActionRateAndAmountDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_1MXNITL3EeKU9IrkkToqcw_-188585172")]
    [DisplayName("Corporate Action Securities Quantity Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnSctiesQtyXtnsn")]
    #endif
    [IsoXmlTag("CorpActnSctiesQtyXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantityExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantityExtension { get; init; } 
    #else
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantityExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1MXNIjL3EeKU9IrkkToqcw_-2006832664")]
    [DisplayName("Option Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtlsXtnsn")]
    #endif
    [IsoXmlTag("OptnDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOptionSD4? OptionDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOptionSD4? OptionDetailsExtension { get; init; } 
    #else
    public CorporateActionOptionSD4? OptionDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1MXNIzL3EeKU9IrkkToqcw_-1328983965")]
    [DisplayName("Securities Movement Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtlsXtnsn")]
    #endif
    [IsoXmlTag("SctiesMvmntDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOptionSD3? SecuritiesMovementDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOptionSD3? SecuritiesMovementDetailsExtension { get; init; } 
    #else
    public SecuritiesOptionSD3? SecuritiesMovementDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1MXNJDL3EeKU9IrkkToqcw_774044256")]
    [DisplayName("Securities Movement Security Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntSctyDtlsXtnsn")]
    #endif
    [IsoXmlTag("SctiesMvmntSctyDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD1? SecuritiesMovementSecurityDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD1? SecuritiesMovementSecurityDetailsExtension { get; init; } 
    #else
    public FinancialInstrumentAttributesSD1? SecuritiesMovementSecurityDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_1MXNJTL3EeKU9IrkkToqcw_1306046274")]
    [DisplayName("Securities Movement Rate Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntRateDtlsXtnsn")]
    #endif
    [IsoXmlTag("SctiesMvmntRateDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD3? SecuritiesMovementRateDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD3? SecuritiesMovementRateDetailsExtension { get; init; } 
    #else
    public CorporateActionRateSD3? SecuritiesMovementRateDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_1MXNJjL3EeKU9IrkkToqcw_-1345714107")]
    [DisplayName("Securities Movement Cash In Lieu Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntCshInLieuDtlsXtnsn")]
    #endif
    [IsoXmlTag("SctiesMvmntCshInLieuDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetailsExtension { get; init; } 
    #else
    public CorporateActionPriceSD1? SecuritiesMovementCashInLieuDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_1Mg-IDL3EeKU9IrkkToqcw_-1092733027")]
    [DisplayName("Securities Movement Fraction Disposition Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntFrctnDspstnXtnsn")]
    #endif
    [IsoXmlTag("SctiesMvmntFrctnDspstnXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionTypeSD1? SecuritiesMovementFractionDispositionExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionTypeSD1? SecuritiesMovementFractionDispositionExtension { get; init; } 
    #else
    public FractionDispositionTypeSD1? SecuritiesMovementFractionDispositionExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_1Mg-ITL3EeKU9IrkkToqcw_-2105914908")]
    [DisplayName("Cash Movement Details Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtlsXtnsn")]
    #endif
    [IsoXmlTag("CshMvmntDtlsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOptionSD4? CashMovementDetailsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOptionSD4? CashMovementDetailsExtension { get; init; } 
    #else
    public CashOptionSD4? CashMovementDetailsExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_1Mg-IjL3EeKU9IrkkToqcw_1370775805")]
    [DisplayName("New Agent Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAgtXtnsn")]
    #endif
    [IsoXmlTag("NewAgtXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD1? NewAgentExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD1? NewAgentExtension { get; init; } 
    #else
    public PartyIdentificationSD1? NewAgentExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like &quot;issuer agent&quot;, &quot;reselling agent&quot;, etc). Used when required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_1Mg-IzL3EeKU9IrkkToqcw_-1692264305")]
    [DisplayName("Agent Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtXtnsn")]
    #endif
    [IsoXmlTag("AgtXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD2? AgentExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD2? AgentExtension { get; init; } 
    #else
    public PartyIdentificationSD2? AgentExtension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V02.

