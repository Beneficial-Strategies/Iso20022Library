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
/// This record is an implementation of the supl.001.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
[IsoId("_b_Y1IeaHEei5aPS232E3Mw")]
[DisplayName("DTCCCANOCSD Data SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCANOCSDDataSD1V11 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.001.001.11";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.11";
    
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
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_b_Y1I-aHEei5aPS232E3Mw")]
    [DisplayName("Notification General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnGnlInf")]
    #endif
    [IsoXmlTag("NtfctnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; init; } 
    #else
    public CorporateActionNotificationSD9? NotificationGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_b_Y1JeaHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD33? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD33? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD33? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_b_Y1J-aHEei5aPS232E3Mw")]
    [DisplayName("Underlying Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygScty")]
    #endif
    [IsoXmlTag("UndrlygScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD15? UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD15? UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributesSD15? UnderlyingSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_b_Y1KeaHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD21? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD21? CorporateActionDetails { get; init; } 
    #else
    public CorporateActionSD21? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_b_Y1K-aHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtDtls")]
    #endif
    [IsoXmlTag("CorpActnDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDateSD10? CorporateActionDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDateSD10? CorporateActionDateDetails { get; init; } 
    #else
    public CorporateActionDateSD10? CorporateActionDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_b_Y1LeaHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPricDtls")]
    #endif
    [IsoXmlTag("CorpActnPricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; init; } 
    #else
    public CorporateActionPriceSD4? CorporateActionPriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_b_Y1L-aHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnPrdDtls")]
    #endif
    [IsoXmlTag("CorpActnPrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; init; } 
    #else
    public CorporateActionPeriodSD3? CorporateActionPeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_b_Y1MeaHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnRateAndAmtDtls")]
    #endif
    [IsoXmlTag("CorpActnRateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRateSD9? CorporateActionRateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_b_Y1M-aHEei5aPS232E3Mw")]
    [DisplayName("Corporate Action Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnSctiesQty")]
    #endif
    [IsoXmlTag("CorpActnSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; init; } 
    #else
    public CorporateActionQuantitySD3? CorporateActionSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_b_Y1NeaHEei5aPS232E3Mw")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOptionSD12? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOptionSD12? OptionDetails { get; init; } 
    #else
    public CorporateActionOptionSD12? OptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_b_Y1N-aHEei5aPS232E3Mw")]
    [DisplayName("Option Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtDtls")]
    #endif
    [IsoXmlTag("OptnDtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDateSD11? OptionDateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDateSD11? OptionDateDetails { get; init; } 
    #else
    public CorporateActionDateSD11? OptionDateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_b_Y1OeaHEei5aPS232E3Mw")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesOptionSD9? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesOptionSD9? SecuritiesMovementDetails { get; init; } 
    #else
    public SecuritiesOptionSD9? SecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_b_Y1O-aHEei5aPS232E3Mw")]
    [DisplayName("Securities Movement Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntSctyDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntSctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD16? SecuritiesMovementSecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD16? SecuritiesMovementSecurityDetails { get; init; } 
    #else
    public FinancialInstrumentAttributesSD16? SecuritiesMovementSecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_b_Y1PeaHEei5aPS232E3Mw")]
    [DisplayName("Securities Movement Rate Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntRateDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntRateDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD10? SecuritiesMovementRateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD10? SecuritiesMovementRateDetails { get; init; } 
    #else
    public CorporateActionRateSD10? SecuritiesMovementRateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_b_Y1P-aHEei5aPS232E3Mw")]
    [DisplayName("Securities Movement Cash In Lieu Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntCshInLieuDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntCshInLieuDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPriceSD5? SecuritiesMovementCashInLieuDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPriceSD5? SecuritiesMovementCashInLieuDetails { get; init; } 
    #else
    public CorporateActionPriceSD5? SecuritiesMovementCashInLieuDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_b_Y1QeaHEei5aPS232E3Mw")]
    [DisplayName("Securities Movement Fraction Disposition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntFrctnDspstn")]
    #endif
    [IsoXmlTag("SctiesMvmntFrctnDspstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionTypeSD3? SecuritiesMovementFractionDisposition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionTypeSD3? SecuritiesMovementFractionDisposition { get; init; } 
    #else
    public FractionDispositionTypeSD3? SecuritiesMovementFractionDisposition { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_b_Y1Q-aHEei5aPS232E3Mw")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOptionSD11? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOptionSD11? CashMovementDetails { get; init; } 
    #else
    public CashOptionSD11? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO agent type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_b_Y1ReaHEei5aPS232E3Mw")]
    [DisplayName("New Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAgt")]
    #endif
    [IsoXmlTag("NewAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD5? NewAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD5? NewAgent { get; init; } 
    #else
    public PartyIdentificationSD5? NewAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like &quot;issuer agent&quot;, &quot;reselling agent&quot;). Used when required &quot;ISO agent type&quot; exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_b_Y1R-aHEei5aPS232E3Mw")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD6? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD6? Agent { get; init; } 
    #else
    public PartyIdentificationSD6? Agent { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCANOCSDDataSD1V11Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCANOCSDDataSD1V11.

