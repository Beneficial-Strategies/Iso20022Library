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
/// This record is an implementation of the supl.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAPASD1 messge extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_1Njf8TL3EeKU9IrkkToqcw_1609512939")]
[DisplayName("DTCCCAPASD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAPASD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.01";
    
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
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_1Njf8jL3EeKU9IrkkToqcw_-1573085315")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD1? CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD1? CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD1? CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_1Njf8zL3EeKU9IrkkToqcw_1688378389")]
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementSecuritiesMovementDetailsSD1? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementSecuritiesMovementDetailsSD1? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionMovementSecuritiesMovementDetailsSD1? CorporateActionMovementSecuritiesMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_1Njf9DL3EeKU9IrkkToqcw_51361216")]
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMovementCashMovementDetailsSD1? CorporateActionMovementCashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementCashMovementDetailsSD1? CorporateActionMovementCashMovementDetails { get; init; } 
    #else
    public CorporateActionMovementCashMovementDetailsSD1? CorporateActionMovementCashMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCAPASD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAPASD1V01.

