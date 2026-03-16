// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity80Choice
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [IsoId("_pf0Yuzi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity Choice")]
    public record QuantityChoice : Quantity80Choice_ { }
}
