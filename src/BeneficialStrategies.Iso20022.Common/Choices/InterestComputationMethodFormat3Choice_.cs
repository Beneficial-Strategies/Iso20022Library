// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat3Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat3Choice.Code),nameof(InterestComputationMethodFormat3Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat3Choice.Proprietary),nameof(InterestComputationMethodFormat3Choice.Proprietary))]
    [IsoId("_AbzApdokEeC60axPepSq7g_-1161845137")]
    [DisplayName("Interest Computation Method Format 3 Choice")]
    public abstract partial record InterestComputationMethodFormat3Choice_
    {
    }
}
