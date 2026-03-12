// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a reporting type.
    /// </summary>
    [KnownType(typeof(Reporting11Choice.Code))]
    [KnownType(typeof(Reporting11Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting11Choice.Code),nameof(Reporting11Choice.Code))]
    [JsonDerivedType(typeof(Reporting11Choice.Proprietary),nameof(Reporting11Choice.Proprietary))]
    [IsoId("_6sleB_fVEeiNZp_PtLohLw")]
    [DisplayName("Reporting 11 Choice")]
    public abstract partial record Reporting11Choice_
    {
    }
}
