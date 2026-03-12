// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a reporting type.
    /// </summary>
    [KnownType(typeof(Reporting10Choice.Code))]
    [KnownType(typeof(Reporting10Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting10Choice.Code),nameof(Reporting10Choice.Code))]
    [JsonDerivedType(typeof(Reporting10Choice.Proprietary),nameof(Reporting10Choice.Proprietary))]
    [IsoId("_owofkdB5EeihG9bKfarOOA")]
    [DisplayName("Reporting 10 Choice")]
    public abstract partial record Reporting10Choice_
    {
    }
}
