// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethod2Choice.Code))]
    [KnownType(typeof(InterestComputationMethod2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InterestComputationMethod2Choice.Code),
        nameof(InterestComputationMethod2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InterestComputationMethod2Choice.Proprietary),
        nameof(InterestComputationMethod2Choice.Proprietary)
    )]
    [IsoId("_4-mnkNopEeCWg-hsBVGrDA_-378245373")]
    [DisplayName("Interest Computation Method 2 Choice")]
    public abstract record InterestComputationMethod2Choice_ { }
}
