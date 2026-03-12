// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of status.
/// </summary>
[IsoId("_xxDOweFXEeWIA4E9cYSxxQ")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason31
{
    #nullable enable
    
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_x6RcNeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus24Choice_? InferredMatchingStatus { get; init; } 
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_x6RcPeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus24Choice_? MatchingStatus { get; init; } 
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_x6RcReFXEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus17Choice_? SettlementStatus { get; init; } 
    
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_x6RcTeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Instruction Processing Status")]
    [IsoXmlTag("InstrPrcgSts")]
    public InstructionProcessingStatus22Choice_? InstructionProcessingStatus { get; init; } 
    
    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_x6RcVeFXEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; } 
    
    /// <summary>
    /// Proprietary status.
    /// </summary>
    [IsoId("_x6RcV-FXEeWIA4E9cYSxxQ")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryStatusAndReason6? Proprietary { get; init; } 
    
    
    #nullable disable
    
}
