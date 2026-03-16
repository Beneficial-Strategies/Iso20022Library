// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity17Choice
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [IsoId("_LyFLIzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity Choice")]
    public record QuantityChoice : Quantity17Choice_ { }
}
