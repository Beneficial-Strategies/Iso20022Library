// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity22Choice
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [IsoId("_cfsEV5KQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity Choice")]
    public record QuantityChoice : Quantity22Choice_ { }
}
