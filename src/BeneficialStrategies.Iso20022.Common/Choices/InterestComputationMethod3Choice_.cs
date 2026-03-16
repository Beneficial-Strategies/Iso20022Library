// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethod3Choice.Code))]
    [KnownType(typeof(InterestComputationMethod3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InterestComputationMethod3Choice.Code),
        nameof(InterestComputationMethod3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InterestComputationMethod3Choice.Proprietary),
        nameof(InterestComputationMethod3Choice.Proprietary)
    )]
    [IsoId("_xpR2AZEjEeakHoV5BVecAQ")]
    [DisplayName("Interest Computation Method 3 Choice")]
    public abstract record InterestComputationMethod3Choice_ { }
}
