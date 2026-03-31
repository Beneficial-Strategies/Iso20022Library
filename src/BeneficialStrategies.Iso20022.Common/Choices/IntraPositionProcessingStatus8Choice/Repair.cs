// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus8Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_65NaKffUEeiNZp_PtLohLw")]
    [DisplayName("Repair")]
    public record Repair : IntraPositionProcessingStatus8Choice_ { }
}
