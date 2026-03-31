// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Fertilizer commodities.
    /// </summary>
    [IsoId("_lThdZ3vyEeanCNPcMT7sSg")]
    [DisplayName("Fertilizer")]
    public record Fertilizer : AssetClassCommodity3Choice_ { }
}
