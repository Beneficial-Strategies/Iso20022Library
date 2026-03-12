// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat1Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat1Choice.Code),nameof(InterestComputationMethodFormat1Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat1Choice.Proprietary),nameof(InterestComputationMethodFormat1Choice.Proprietary))]
    [IsoId("_Q4NYa9p-Ed-ak6NoX_4Aeg_893786943")]
    [DisplayName("Interest Computation Method Format 1 Choice")]
    public abstract partial record InterestComputationMethodFormat1Choice_
    {
    }
}
