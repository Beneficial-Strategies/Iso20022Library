// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus2Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_UUJ619p-Ed-ak6NoX_4Aeg_325561589")]
    [DisplayName("Denied")]
    public record Denied : ProcessingStatus2Choice_ { }
}
