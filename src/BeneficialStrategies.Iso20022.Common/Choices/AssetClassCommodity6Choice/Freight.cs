// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Freight commodities.
    /// </summary>
    [IsoId("_1bgUGRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Freight")]
    public record Freight : AssetClassCommodity6Choice_ { }
}
