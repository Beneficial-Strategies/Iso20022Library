// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus3Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("_UZg78Np-Ed-ak6NoX_4Aeg_1071699914")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : InstructionProcessingStatus3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcg")]
        public required PendingProcessingStatus1Choice_ Value { get; init; }
    }
}
