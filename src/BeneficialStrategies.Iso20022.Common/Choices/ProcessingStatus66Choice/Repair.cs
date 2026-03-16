// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus66Choice
{
    /// <summary>
    /// Instruction or request is accepted but in repair.
    /// </summary>
    [IsoId("_BvN4eeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus66Choice_ { }
}
