// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_UVDSs9p-Ed-ak6NoX_4Aeg_-1873411737")]
    [DisplayName("Instruction Processing Status")]
    public partial record InstructionProcessingStatus : Status1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InstrPrcgSts")]
        public required InstructionProcessingStatus2Choice_ Value { get; init; }
    }
}
