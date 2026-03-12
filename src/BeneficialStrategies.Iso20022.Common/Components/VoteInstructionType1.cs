// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote options for a resolution.
/// </summary>
[IsoId("_ScucEK4JEemG7MmivSuE5g")]
[DisplayName("Vote Instruction Type")]
public partial record VoteInstructionType1
{
    #nullable enable
    
    /// <summary>
    /// Vote option allowed at the resolution level.
    /// </summary>
    [IsoId("_ov6xUK4JEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction Type Code")]
    [IsoXmlTag("VoteInstrTpCd")]
    public required VoteInstructionType1Choice_ VoteInstructionTypeCode { get; init; } 
    
    /// <summary>
    /// Additional information about the vote instruction type code when expressed as a proprietary code.
    /// </summary>
    [IsoId("_uWdjEK4JEemG7MmivSuE5g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
