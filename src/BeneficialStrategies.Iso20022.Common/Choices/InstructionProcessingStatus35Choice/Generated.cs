// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus35Choice
{
    /// <summary>
    /// Transaction was created by the account servicer or a third party. It was not instructed directly by the account owner.
    /// </summary>
    [IsoId("_iE4OjffZEeiNZp_PtLohLw")]
    [DisplayName("Generated")]
    public partial record Generated : InstructionProcessingStatus35Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Gnrtd")]
        public required GeneratedStatus8Choice_ Value { get; init; }
    }
}
