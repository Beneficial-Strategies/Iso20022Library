// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of pension scheme.
    /// </summary>
    [KnownType(typeof(PensionSchemeType3Choice.Code))]
    [KnownType(typeof(PensionSchemeType3Choice.Proprietary))]
    [JsonDerivedType(typeof(PensionSchemeType3Choice.Code),nameof(PensionSchemeType3Choice.Code))]
    [JsonDerivedType(typeof(PensionSchemeType3Choice.Proprietary),nameof(PensionSchemeType3Choice.Proprietary))]
    [IsoId("_XUKNoelqEeuvhrZwLF0fDg")]
    [DisplayName("Pension Scheme Type 3 Choice")]
    public abstract partial record PensionSchemeType3Choice_
    {
    }
}
