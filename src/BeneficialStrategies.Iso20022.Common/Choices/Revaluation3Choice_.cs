// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a data source scheme to determine the revaluation.
    /// </summary>
    [KnownType(typeof(Revaluation3Choice.Indicator))]
    [KnownType(typeof(Revaluation3Choice.Proprietary))]
    [JsonDerivedType(typeof(Revaluation3Choice.Indicator), nameof(Revaluation3Choice.Indicator))]
    [JsonDerivedType(
        typeof(Revaluation3Choice.Proprietary),
        nameof(Revaluation3Choice.Proprietary)
    )]
    [IsoId("_sfc1cZEjEeakHoV5BVecAQ")]
    [DisplayName("Revaluation 3 Choice")]
    public abstract record Revaluation3Choice_ { }
}
