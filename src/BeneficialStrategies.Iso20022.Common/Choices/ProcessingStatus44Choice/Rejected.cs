// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus44Choice
{
    /// <summary>
    /// Modification Request has been rejected for further processing.
    /// </summary>
    [IsoId("_iZ0nS1hgEeS8HfHHd4stCA")]
    [DisplayName("Rejected")]
    public record Rejected : ProcessingStatus44Choice_ { }
}
