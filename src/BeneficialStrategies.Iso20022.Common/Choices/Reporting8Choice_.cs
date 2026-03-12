// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting8Choice.Code))]
    [KnownType(typeof(Reporting8Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting8Choice.Code),nameof(Reporting8Choice.Code))]
    [JsonDerivedType(typeof(Reporting8Choice.Proprietary),nameof(Reporting8Choice.Proprietary))]
    [IsoId("_5TJXI5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reporting 8 Choice")]
    public abstract partial record Reporting8Choice_
    {
    }
}
