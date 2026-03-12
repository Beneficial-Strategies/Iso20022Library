// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a time horizon.
    /// </summary>
    [KnownType(typeof(TimeHorizon2Choice.NumberOfYears))]
    [KnownType(typeof(TimeHorizon2Choice.TimeFrame))]
    [JsonDerivedType(typeof(TimeHorizon2Choice.NumberOfYears),nameof(TimeHorizon2Choice.NumberOfYears))]
    [JsonDerivedType(typeof(TimeHorizon2Choice.TimeFrame),nameof(TimeHorizon2Choice.TimeFrame))]
    [IsoId("_U38AEbVOEeqkjqDuFVh1-A")]
    [DisplayName("Time Horizon 2 Choice")]
    public abstract partial record TimeHorizon2Choice_
    {
    }
}
