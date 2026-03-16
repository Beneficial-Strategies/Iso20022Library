// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice
{
    /// <summary>
    /// Other C10 commodities.
    /// </summary>
    [IsoId("_1bgUHxZXEe2QNcZTDeoKnQ")]
    [DisplayName("Other C")]
    public record OtherC10 : AssetClassCommodity6Choice_
    {
        /// <summary>
        /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
        /// </summary>
        [IsoId("_nyJtARZYEe2QNcZTDeoKnQ")]
        [DisplayName("Base Product")]
        [IsoXmlTag("BasePdct")]
        public required AssetClassProductType11Code BaseProduct { get; init; }
    }
}
