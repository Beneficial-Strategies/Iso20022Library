// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to be cancelled.
/// </summary>
[IsoId("_x0jHGTT5Ee2j2eQlcOSMKg")]
[DisplayName("Cancel Instruction")]
public partial record CancelInstruction4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction previously sent.
    /// </summary>
    [IsoId("_yKdFoTT5Ee2j2eQlcOSMKg")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Account and instructed positions to which the meeting instruction cancellation request applies.
    /// </summary>
    [IsoId("_yKdFozT5Ee2j2eQlcOSMKg")]
    [DisplayName("Instructed Position")]
    [IsoXmlTag("InstdPos")]
    public SafekeepingAccount16? InstructedPosition { get; init; } 
    
    
    #nullable disable
    
}
