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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.065.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPBackTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the methodology used to carry out backtesting.
/// </summary>
[Description(@"The CCPBackTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the methodology used to carry out backtesting.")]
[IsoId("_lfCcNjW0EemdWfjs3tykFQ")]
[DisplayName("CCP Back Testing Definition Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPBackTestingDefinitionReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.065.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPBckTstgDefRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.065.001.01";
    
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
    /// <summary>
    /// Constructs a CCPBackTestingDefinitionReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPBackTestingDefinitionReportV01( BackTestingMethodology1 reqMethodology )
    {
        Methodology = reqMethodology;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details parameters and methodology used to conduct the back test.
    /// </summary>
    [IsoId("_lfCcNzW0EemdWfjs3tykFQ")]
    [DisplayName("Methodology")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mthdlgy")]
    #endif
    [IsoXmlTag("Mthdlgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BackTestingMethodology1 Methodology { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BackTestingMethodology1 Methodology { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BackTestingMethodology1 Methodology { get; init; } 
    #else
    public BackTestingMethodology1 Methodology { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lfCcODW0EemdWfjs3tykFQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CCPBackTestingDefinitionReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPBackTestingDefinitionReportV01.

