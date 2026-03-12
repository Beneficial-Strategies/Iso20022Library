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
/// This record is an implementation of the supl.031.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCASTSD1 message extends ISO Corporate Action Instruction Statement Report message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCASTSD1 message extends ISO Corporate Action Instruction Statement Report message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_b_h_Y-aHEei5aPS232E3Mw")]
[DisplayName("DTCCCASTSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCASTSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.031.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCASTSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.031.001.03";
    
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
    /// Information to be extended as supplementary data to corporate action balance details at event level.
    /// </summary>
    [IsoId("_b_h_ZeaHEei5aPS232E3Mw")]
    [DisplayName("Event Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtBalDtls")]
    #endif
    [IsoXmlTag("EvtBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionBalanceSD5? EventBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionBalanceSD5? EventBalanceDetails { get; init; } 
    #else
    public CorporateActionBalanceSD5? EventBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option level.
    /// </summary>
    [IsoId("_b_h_Z-aHEei5aPS232E3Mw")]
    [DisplayName("Total Instructed Balance Option Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBalOptnBalDtls")]
    #endif
    [IsoXmlTag("TtlInstdBalOptnBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionInstructedBalanceOptionBalanceSD3? TotalInstructedBalanceOptionBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInstructedBalanceOptionBalanceSD3? TotalInstructedBalanceOptionBalanceDetails { get; init; } 
    #else
    public CorporateActionInstructedBalanceOptionBalanceSD3? TotalInstructedBalanceOptionBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option instruction details level. Option level instruction details are referenced by unique instruction identification, instruction date, quantity and status of instruction.
    /// </summary>
    [IsoId("_b_h_aeaHEei5aPS232E3Mw")]
    [DisplayName("Total Instructed Balance Option Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBalOptnInstrDtls")]
    #endif
    [IsoXmlTag("TtlInstdBalOptnInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionInstructedBalanceOptionInstructionSD3? TotalInstructedBalanceOptionInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInstructedBalanceOptionInstructionSD3? TotalInstructedBalanceOptionInstructionDetails { get; init; } 
    #else
    public CorporateActionInstructedBalanceOptionInstructionSD3? TotalInstructedBalanceOptionInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details at option protect instruction details level.
    /// </summary>
    [IsoId("_b_h_a-aHEei5aPS232E3Mw")]
    [DisplayName("Total Instructed Balance Option Protect Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBalOptnPrtctInstrDtls")]
    #endif
    [IsoXmlTag("TtlInstdBalOptnPrtctInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionInstructedBalanceOptionProtectInstructionSD3? TotalInstructedBalanceOptionProtectInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInstructedBalanceOptionProtectInstructionSD3? TotalInstructedBalanceOptionProtectInstructionDetails { get; init; } 
    #else
    public CorporateActionInstructedBalanceOptionProtectInstructionSD3? TotalInstructedBalanceOptionProtectInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCASTSD1V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCASTSD1V03.

