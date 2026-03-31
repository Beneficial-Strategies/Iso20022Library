// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus91Choice
{
    /// <summary>
    /// Modification is pending. It is not known at this time whether modification can be affected.
    /// </summary>
    [IsoId("_diXTGzi8Eeydid5dcNPKvg")]
    [DisplayName("Pending")]
    public record Pending : ProcessingStatus91Choice_ { }
}
