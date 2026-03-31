// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus5Choice
{
    /// <summary>
    /// Modification Request has been rejected for further processing.
    /// </summary>
    [IsoId("_UUmmx9p-Ed-ak6NoX_4Aeg_-1981006965")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus5Choice_ { }
}
