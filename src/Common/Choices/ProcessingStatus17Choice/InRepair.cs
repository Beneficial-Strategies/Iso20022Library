// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus17Choice
{
    /// <summary>
    /// Trade is InRepair.
    /// </summary>
    [IsoId("_A4_6A9okEeC60axPepSq7g_-1646438235")]
    [DisplayName("In Repair")]
    public partial record InRepair : ProcessingStatus17Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InRpr")]
        public required InstructionProcessingReason2Choice_ Value { get; init; }
    }
}
