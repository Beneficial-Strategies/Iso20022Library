// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity5Choice
{
    /// <summary>
    /// Environmental commodities.
    /// </summary>
    [IsoId("_owQINbtIEeiLRYqS-r-R-A")]
    [DisplayName("Environmental")]
    public record Environmental : AssetClassCommodity5Choice_ { }
}
