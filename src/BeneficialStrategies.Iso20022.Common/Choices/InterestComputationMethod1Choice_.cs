// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethod1Choice.Code))]
    [KnownType(typeof(InterestComputationMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestComputationMethod1Choice.Code),nameof(InterestComputationMethod1Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethod1Choice.Proprietary),nameof(InterestComputationMethod1Choice.Proprietary))]
    [IsoId("_Q-eYcdp-Ed-ak6NoX_4Aeg_-477937126")]
    [DisplayName("Interest Computation Method 1 Choice")]
    public abstract partial record InterestComputationMethod1Choice_
    {
    }
}
