// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat1Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DistributionTypeFormat1Choice.Code),
        nameof(DistributionTypeFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DistributionTypeFormat1Choice.Proprietary),
        nameof(DistributionTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3nihdp-Ed-ak6NoX_4Aeg_2019414237")]
    [DisplayName("Distribution Type Format 1 Choice")]
    public abstract record DistributionTypeFormat1Choice_ { }
}
