// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Energy commodities.
    /// </summary>
    [IsoId("_1bgUExZXEe2QNcZTDeoKnQ")]
    [DisplayName("Energy")]
    public record Energy : AssetClassCommodity6Choice_ { }
}
