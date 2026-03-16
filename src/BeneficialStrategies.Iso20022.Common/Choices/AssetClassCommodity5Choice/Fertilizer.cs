// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Fertilizer commodities.
    /// </summary>
    [IsoId("_owQIN7tIEeiLRYqS-r-R-A")]
    [DisplayName("Fertilizer")]
    public record Fertilizer : AssetClassCommodity5Choice_ { }
}
