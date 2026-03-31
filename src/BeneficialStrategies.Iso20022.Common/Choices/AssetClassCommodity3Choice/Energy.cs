// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Energy commodities.
    /// </summary>
    [IsoId("_lThdY3vyEeanCNPcMT7sSg")]
    [DisplayName("Energy")]
    public record Energy : AssetClassCommodity3Choice_ { }
}
