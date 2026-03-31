// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat5Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InterestComputationMethodFormat5Choice.Code),
        nameof(InterestComputationMethodFormat5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InterestComputationMethodFormat5Choice.Proprietary),
        nameof(InterestComputationMethodFormat5Choice.Proprietary)
    )]
    [IsoId("_chVpq5KQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Computation Method Format 5 Choice")]
    public abstract record InterestComputationMethodFormat5Choice_ { }
}
