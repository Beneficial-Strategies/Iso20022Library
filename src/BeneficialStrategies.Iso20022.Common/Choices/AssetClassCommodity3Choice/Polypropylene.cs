// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice
{
    /// <summary>
    /// Polypropylene commodities.
    /// </summary>
    [IsoId("_lThdc3vyEeanCNPcMT7sSg")]
    [DisplayName("Polypropylene")]
    public record Polypropylene : AssetClassCommodity3Choice_ { }
}
