// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of pension scheme.
    /// </summary>
    [KnownType(typeof(PensionSchemeType2Choice.Code))]
    [KnownType(typeof(PensionSchemeType2Choice.Proprietary))]
    [JsonDerivedType(typeof(PensionSchemeType2Choice.Code),nameof(PensionSchemeType2Choice.Code))]
    [JsonDerivedType(typeof(PensionSchemeType2Choice.Proprietary),nameof(PensionSchemeType2Choice.Proprietary))]
    [IsoId("_CELmwTOUEeqLMcD_sEa8Xw")]
    [DisplayName("Pension Scheme Type 2 Choice")]
    public abstract partial record PensionSchemeType2Choice_
    {
    }
}
