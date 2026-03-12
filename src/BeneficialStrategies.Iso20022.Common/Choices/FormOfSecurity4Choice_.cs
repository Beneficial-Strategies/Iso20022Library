// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the form of securities.
    /// </summary>
    [KnownType(typeof(FormOfSecurity4Choice.Code))]
    [KnownType(typeof(FormOfSecurity4Choice.Proprietary))]
    [JsonDerivedType(typeof(FormOfSecurity4Choice.Code),nameof(FormOfSecurity4Choice.Code))]
    [JsonDerivedType(typeof(FormOfSecurity4Choice.Proprietary),nameof(FormOfSecurity4Choice.Proprietary))]
    [IsoId("_AbzAotokEeC60axPepSq7g_-664085466")]
    [DisplayName("Form Of Security 4 Choice")]
    public abstract partial record FormOfSecurity4Choice_
    {
    }
}
