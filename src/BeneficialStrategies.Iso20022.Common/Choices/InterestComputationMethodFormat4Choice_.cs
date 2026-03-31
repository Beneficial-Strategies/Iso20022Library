// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat4Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InterestComputationMethodFormat4Choice.Code),
        nameof(InterestComputationMethodFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InterestComputationMethodFormat4Choice.Proprietary),
        nameof(InterestComputationMethodFormat4Choice.Proprietary)
    )]
    [IsoId("_atvUATm6EeWV5sr121Fc8A")]
    [DisplayName("Interest Computation Method Format 4 Choice")]
    public abstract record InterestComputationMethodFormat4Choice_ { }
}
