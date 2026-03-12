// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of number count type.
    /// </summary>
    [KnownType(typeof(NumberCount2Choice.CurrentInstructionNumber))]
    [KnownType(typeof(NumberCount2Choice.TotalNumber))]
    [JsonDerivedType(typeof(NumberCount2Choice.CurrentInstructionNumber),nameof(NumberCount2Choice.CurrentInstructionNumber))]
    [JsonDerivedType(typeof(NumberCount2Choice.TotalNumber),nameof(NumberCount2Choice.TotalNumber))]
    [IsoId("_JBmOYSgdEey2k_sfZmJz4g")]
    [DisplayName("Number Count 2 Choice")]
    public abstract partial record NumberCount2Choice_
    {
    }
}
