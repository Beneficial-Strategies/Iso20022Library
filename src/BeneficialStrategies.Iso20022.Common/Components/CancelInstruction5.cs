// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancel Instruction5.
/// </summary>
[IsoId("_4Y5gUY-9Ee-COKgew96POA")]
[DisplayName("Cancel Instruction5")]
public partial record CancelInstruction5
{
    #nullable enable

    /// <summary>
    /// Instructed Position.
    /// </summary>
    [DisplayName("Instructed Position")]
    [IsoXmlTag("InstdPos")]
    public SafekeepingAccount18? InstructedPosition { get; init; } 

    /// <summary>
    /// Single Instruction Identification.
    /// </summary>
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 

    
    #nullable disable
    
}
