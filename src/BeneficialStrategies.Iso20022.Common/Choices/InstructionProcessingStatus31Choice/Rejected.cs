// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus31Choice
{
    /// <summary>
    /// Provides status information related to an instruction request rejected for further processing due to system reasons.
    /// </summary>
    [IsoId("_pZNIc7XTEeiTob_PrFFUxA")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionProcessingStatus31Choice_ { }
}
