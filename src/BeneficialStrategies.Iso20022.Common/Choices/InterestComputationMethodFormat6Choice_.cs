// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the format to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat6Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat6Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat6Choice.Code),nameof(InterestComputationMethodFormat6Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat6Choice.Proprietary),nameof(InterestComputationMethodFormat6Choice.Proprietary))]
    [IsoId("_n8gFUSDuEeahCJeThTBhHA")]
    [DisplayName("Interest Computation Method Format 6 Choice")]
    public abstract partial record InterestComputationMethodFormat6Choice_
    {
    }
}
