// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionType1Choice
{
    /// <summary>
    /// Vote option expressed as a code.
    /// </summary>
    [IsoId("_U7ERUK4KEemG7MmivSuE5g")]
    [DisplayName("Type")]
    public partial record Type : VoteInstructionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of voting instructions.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required VoteInstruction6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
