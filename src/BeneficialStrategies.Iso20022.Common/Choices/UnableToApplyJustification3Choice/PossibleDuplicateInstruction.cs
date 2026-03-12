// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification3Choice
{
    /// <summary>
    /// Indicates whether or not the referred item is a possible duplicate of a previous instruction or entry.
    /// </summary>
    [IsoId("_S_E3F0goEeaGKYpLDboHPQ")]
    [DisplayName("Possible Duplicate Instruction")]
    public partial record PossibleDuplicateInstruction : UnableToApplyJustification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A flag indicating a True or False value.
        /// </summary>
        [IsoXmlTag("PssblDplctInstr")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
