// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting9Choice.Code))]
    [KnownType(typeof(Reporting9Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting9Choice.Code),nameof(Reporting9Choice.Code))]
    [JsonDerivedType(typeof(Reporting9Choice.Proprietary),nameof(Reporting9Choice.Proprietary))]
    [IsoId("_5mslkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reporting 9 Choice")]
    public abstract partial record Reporting9Choice_
    {
    }
}
