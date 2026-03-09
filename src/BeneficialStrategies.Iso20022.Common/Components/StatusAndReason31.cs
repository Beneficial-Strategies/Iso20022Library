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
/// Choice of status.
/// </summary>
[IsoId("_xxDOweFXEeWIA4E9cYSxxQ")]
[DisplayName("Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAndReason31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_x6RcNeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Inferred Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IfrrdMtchgSts")]
    #endif
    [IsoXmlTag("IfrrdMtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; } 
    #else
    public MatchingStatus24Choice_? InferredMatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_x6RcPeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus24Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus24Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus24Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_x6RcReFXEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus17Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus17Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus17Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_x6RcTeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Instruction Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgSts")]
    #endif
    [IsoXmlTag("InstrPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionProcessingStatus22Choice_? InstructionProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionProcessingStatus22Choice_? InstructionProcessingStatus { get; init; } 
    #else
    public InstructionProcessingStatus22Choice_? InstructionProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_x6RcVeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryReason4? Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryReason4? Settled { get; init; } 
    #else
    public ProprietaryReason4? Settled { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_x6RcV-FXEeWIA4E9cYSxxQ")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryStatusAndReason6? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryStatusAndReason6? Proprietary { get; init; } 
    #else
    public ProprietaryStatusAndReason6? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
