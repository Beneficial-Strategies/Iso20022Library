// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities restriction information.
    /// </summary>
    [KnownType(typeof(Restriction3Choice.Code))]
    [KnownType(typeof(Restriction3Choice.Proprietary))]
    [JsonDerivedType(typeof(Restriction3Choice.Code),nameof(Restriction3Choice.Code))]
    [JsonDerivedType(typeof(Restriction3Choice.Proprietary),nameof(Restriction3Choice.Proprietary))]
    [IsoId("_AZabBNokEeC60axPepSq7g_692067563")]
    [DisplayName("Restriction 3 Choice")]
    public abstract partial record Restriction3Choice_
    {
    }
}
