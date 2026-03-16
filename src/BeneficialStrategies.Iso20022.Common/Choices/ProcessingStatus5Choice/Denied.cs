// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus5Choice
{
    /// <summary>
    /// Modification request will not be executed.
    /// </summary>
    [IsoId("_UUvwsNp-Ed-ak6NoX_4Aeg_1371540313")]
    [DisplayName("Denied")]
    public record Denied : ProcessingStatus5Choice_ { }
}
