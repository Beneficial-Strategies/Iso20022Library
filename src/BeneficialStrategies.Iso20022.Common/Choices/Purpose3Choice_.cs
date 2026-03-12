// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a settlement purpose.
    /// </summary>
    [KnownType(typeof(Purpose3Choice.SecuritiesPurposeCode))]
    [KnownType(typeof(Purpose3Choice.Proprietary))]
    [JsonDerivedType(typeof(Purpose3Choice.SecuritiesPurposeCode),nameof(Purpose3Choice.SecuritiesPurposeCode))]
    [JsonDerivedType(typeof(Purpose3Choice.Proprietary),nameof(Purpose3Choice.Proprietary))]
    [IsoId("_J8-MUSUOEeOgKIHGINc2Uw")]
    [DisplayName("Purpose 3 Choice")]
    public abstract partial record Purpose3Choice_
    {
    }
}
