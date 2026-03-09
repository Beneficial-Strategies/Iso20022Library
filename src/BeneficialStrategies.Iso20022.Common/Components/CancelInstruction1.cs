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
/// Instruction to be cancelled.
/// </summary>
[IsoId("_32G-IK-aEemJ1NnLPsTFaw")]
[DisplayName("Cancel Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelInstruction1( System.String reqSingleInstructionIdentification )
    {
        SingleInstructionIdentification = reqSingleInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction previously sent.
    /// </summary>
    [IsoId("_QVAV8K-bEemJ1NnLPsTFaw")]
    [DisplayName("Single Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnglInstrId")]
    #endif
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SingleInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SingleInstructionIdentification { get; init; } 
    #else
    public System.String SingleInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account and instructed positions to which the meeting instruction cancellation request applies.
    /// </summary>
    [IsoId("_TGfmIa-bEemJ1NnLPsTFaw")]
    [DisplayName("Instructed Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdPos")]
    #endif
    [IsoXmlTag("InstdPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingAccount9? InstructedPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount9? InstructedPosition { get; init; } 
    #else
    public SafekeepingAccount9? InstructedPosition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
