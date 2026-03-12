// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a code.
    /// </summary>
    [KnownType(typeof(ClosingDate4Choice.Date))]
    [KnownType(typeof(ClosingDate4Choice.Code))]
    [JsonDerivedType(typeof(ClosingDate4Choice.Date),nameof(ClosingDate4Choice.Date))]
    [JsonDerivedType(typeof(ClosingDate4Choice.Code),nameof(ClosingDate4Choice.Code))]
    [IsoId("_xCN8YcpdEemQ1o-hyeYV5w")]
    [DisplayName("Closing Date 4 Choice")]
    public abstract partial record ClosingDate4Choice_
    {
    }
}
