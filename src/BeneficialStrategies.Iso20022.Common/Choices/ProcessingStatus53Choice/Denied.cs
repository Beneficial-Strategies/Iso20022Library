// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus53Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_2993MTp4EeWVrPy0StzzSg")]
    [DisplayName("Denied")]
    public record Denied : ProcessingStatus53Choice_ { }
}
