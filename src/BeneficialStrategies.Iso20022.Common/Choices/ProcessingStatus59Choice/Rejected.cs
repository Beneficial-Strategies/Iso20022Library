// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus59Choice
{
    /// <summary>
    /// Instruction is rejected.
    /// </summary>
    [IsoId("_6HV0_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus59Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus22Choice_ Value { get; init; }
    }
}
