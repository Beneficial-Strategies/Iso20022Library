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
/// This record is an implementation of the supl.008.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_b_Y1U-aHEei5aPS232E3Mw")]
[DisplayName("DTCCCAINSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCAINSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.008.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.05";
    
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
    /// DTC (The Depository Trust Corporation) optional dividend service election.
    /// </summary>
    [IsoId("_b_h_EeaHEei5aPS232E3Mw")]
    [DisplayName("Optional Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnlDvdd")]
    #endif
    [IsoXmlTag("OptnlDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionalDividendAccountQuantitySD3? OptionalDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionalDividendAccountQuantitySD3? OptionalDividend { get; init; } 
    #else
    public OptionalDividendAccountQuantitySD3? OptionalDividend { get; set; } 
    #endif
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) tax exempt service election.
    /// </summary>
    [IsoId("_b_h_GeaHEei5aPS232E3Mw")]
    [DisplayName("Tax Exempt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxXmpt")]
    #endif
    [IsoXmlTag("TaxXmpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxExemptQuantitySD2? TaxExempt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxExemptQuantitySD2? TaxExempt { get; init; } 
    #else
    public TaxExemptQuantitySD2? TaxExempt { get; set; } 
    #endif
    
    /// <summary>
    /// Tax category number assigned on the announcement to provide a breakdown at a category level on the inbound instruction to determine tax treatment as required by issuers, their agents, or tax authorities.
    /// </summary>
    [IsoId("_rsHT0OcjEei5aPS232E3Mw")]
    [DisplayName("Tax Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCtgy")]
    #endif
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory2> TaxCategory { get; init; } = new ValueList<TaxCategory2>(){};
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) foreign currency payment service wire payment instruction.
    /// </summary>
    [IsoId("_b_h_IeaHEei5aPS232E3Mw")]
    [DisplayName("Wire Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WireInstr")]
    #endif
    [IsoXmlTag("WireInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WireInstructionSD3? WireInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WireInstructionSD3? WireInstruction { get; init; } 
    #else
    public WireInstructionSD3? WireInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Supplementary data extending corporate action reorganisation instruction message with corporate action elements not covered in the standard message.
    /// </summary>
    [IsoId("_b_h_KeaHEei5aPS232E3Mw")]
    [DisplayName("Reorganisation Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReorgInstrDtls")]
    #endif
    [IsoXmlTag("ReorgInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReorganisationInstructionSD5? ReorganisationInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReorganisationInstructionSD5? ReorganisationInstructionDetails { get; init; } 
    #else
    public ReorganisationInstructionSD5? ReorganisationInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCAINSD1V05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAINSD1V05.

