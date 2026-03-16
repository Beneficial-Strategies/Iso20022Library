// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Industry Sector3Choice.
    /// </summary>
    [KnownType(typeof(IndustrySector3Choice.NACETaxonomySector))]
    [KnownType(typeof(IndustrySector3Choice.RegulatoryTaxonomySector))]
    [JsonDerivedType(
        typeof(IndustrySector3Choice.NACETaxonomySector),
        nameof(IndustrySector3Choice.NACETaxonomySector)
    )]
    [JsonDerivedType(
        typeof(IndustrySector3Choice.RegulatoryTaxonomySector),
        nameof(IndustrySector3Choice.RegulatoryTaxonomySector)
    )]
    [IsoId("_ZFrYoeJJEe-5wchdE0oJYw")]
    [DisplayName("Industry Sector3Choice")]
    public abstract record IndustrySector3Choice_ { }
}
