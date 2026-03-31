// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus31Choice
{
    /// <summary>
    /// Provides status information related to an instruction request cancelled.
    /// </summary>
    [IsoId("_pZNIY7XTEeiTob_PrFFUxA")]
    [DisplayName("Cancelled")]
    public record Cancelled : InstructionProcessingStatus31Choice_ { }
}
