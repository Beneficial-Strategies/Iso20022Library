// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus72Choice
{
    /// <summary>
    /// Instruction is rejected by the executing party.
    /// </summary>
    [IsoId("_a2nK1eLtEeWOD7aAy2fAcA")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus72Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required Reason18Choice_ Value { get; init; }
    }
}
