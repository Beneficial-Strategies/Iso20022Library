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
/// Settlement transaction numbering information.
/// </summary>
[IsoId("_Qr_hWNp-Ed-ak6NoX_4Aeg_-606322098")]
[DisplayName("Total Number")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalNumber1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalNumber1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalNumber1( System.String reqCurrentInstructionNumber,System.String reqTotalOfLinkedInstructions )
    {
        CurrentInstructionNumber = reqCurrentInstructionNumber;
        TotalOfLinkedInstructions = reqTotalOfLinkedInstructions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number of the instruction in a range of linked settlement instructions.
    /// </summary>
    [IsoId("_Qr_hWdp-Ed-ak6NoX_4Aeg_-2082263388")]
    [DisplayName("Current Instruction Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurInstrNb")]
    #endif
    [IsoXmlTag("CurInstrNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText CurrentInstructionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CurrentInstructionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CurrentInstructionNumber { get; init; } 
    #else
    public System.String CurrentInstructionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of settlement instructions that are linked together.
    /// </summary>
    [IsoId("_Qr_hWtp-Ed-ak6NoX_4Aeg_-1935589206")]
    [DisplayName("Total Of Linked Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOfLkdInstrs")]
    #endif
    [IsoXmlTag("TtlOfLkdInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText TotalOfLinkedInstructions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalOfLinkedInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalOfLinkedInstructions { get; init; } 
    #else
    public System.String TotalOfLinkedInstructions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
