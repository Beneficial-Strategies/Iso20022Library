// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting6Choice.Code))]
    [KnownType(typeof(Reporting6Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting6Choice.Code),nameof(Reporting6Choice.Code))]
    [JsonDerivedType(typeof(Reporting6Choice.Proprietary),nameof(Reporting6Choice.Proprietary))]
    [IsoId("_o9glQTtCEeWRTLSN0i0tng")]
    [DisplayName("Reporting 6 Choice")]
    public abstract partial record Reporting6Choice_
    {
    }
}
