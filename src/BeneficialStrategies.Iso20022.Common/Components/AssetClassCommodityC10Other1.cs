// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity attributes of a derivative where the type is other C10.
/// </summary>
[IsoId("_nxY4ARZYEe2QNcZTDeoKnQ")]
[DisplayName("Asset Class Commodity C 10 Other")]
public record AssetClassCommodityC10Other1
{
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_nyJtARZYEe2QNcZTDeoKnQ")]
    [DisplayName("Base Product")]
    [IsoXmlTag("BasePdct")]
    public required AssetClassProductType11Code BaseProduct { get; init; }
}
