// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_i0ct01hgEeS8HfHHd4stCA")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus45Choice_ { }
}
