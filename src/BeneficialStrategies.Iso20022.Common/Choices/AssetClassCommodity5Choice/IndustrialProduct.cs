// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Industrial Product commodities.
    /// </summary>
    [IsoId("_owQIO7tIEeiLRYqS-r-R-A")]
    [DisplayName("Industrial Product")]
    public record IndustrialProduct : AssetClassCommodity5Choice_ { }
}
