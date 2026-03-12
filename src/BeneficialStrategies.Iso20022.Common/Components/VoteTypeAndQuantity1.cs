// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of vote that can be provided for a resolution in a general meeting.
/// </summary>
[IsoId("_X_oUcPNBEeqRfth943bvEA")]
[DisplayName("Vote Type And Quantity")]
public partial record VoteTypeAndQuantity1
{
    #nullable enable
    
    /// <summary>
    /// Types of vote instruction allowed for resolutions to be voted on in general meeting.
    /// </summary>
    [IsoId("_joPWUPNBEeqRfth943bvEA")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    public required VoteInstructionType1Choice_ VoteInstructionType { get; init; } 
    
    /// <summary>
    /// Quantity of vote expressed for the specified type of vote instruction.
    /// </summary>
    [IsoId("_n-JmoPNBEeqRfth943bvEA")]
    [DisplayName("Vote Quantity")]
    [IsoXmlTag("VoteQty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber VoteQuantity { get; init; } 
    
    
    #nullable disable
    
}
