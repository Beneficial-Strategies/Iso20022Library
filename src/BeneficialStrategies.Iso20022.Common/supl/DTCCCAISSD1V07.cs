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
/// This record is an implementation of the supl.030.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAISSD1 message extends ISO corporate action instruction status advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_myaAeVB5Ee2KGNXAcFL5RA")]
[DisplayName("DTCCCAISSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAISSD1V07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.030.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAISSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.030.001.07";
    
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
    /// Information to be extended as supplementary data to instruction status message for reorganisation events.
    /// </summary>
    [IsoId("_myaAe1B5Ee2KGNXAcFL5RA")]
    [DisplayName("Reorganisation Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReorgInstrDtls")]
    #endif
    [IsoXmlTag("ReorgInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationInstructionSD12? ReorganisationInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationInstructionSD12? ReorganisationInstructionDetails { get; init; } 
    #else
    public ReorganisationInstructionSD12? ReorganisationInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to instruction status message for distribution events.
    /// </summary>
    [IsoId("_O1nlIFB7Ee2KGNXAcFL5RA")]
    [DisplayName("Distribution Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnInstrDtls")]
    #endif
    [IsoXmlTag("DstrbtnInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionInstructionSD1? DistributionInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionInstructionSD1? DistributionInstructionDetails { get; init; } 
    #else
    public DistributionInstructionSD1? DistributionInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCAISSD1V07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAISSD1V07.

