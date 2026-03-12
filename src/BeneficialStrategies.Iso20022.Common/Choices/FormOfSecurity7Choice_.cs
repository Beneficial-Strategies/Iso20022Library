// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the form of securities.
    /// </summary>
    [KnownType(typeof(FormOfSecurity7Choice.Code))]
    [KnownType(typeof(FormOfSecurity7Choice.Proprietary))]
    [JsonDerivedType(typeof(FormOfSecurity7Choice.Code),nameof(FormOfSecurity7Choice.Code))]
    [JsonDerivedType(typeof(FormOfSecurity7Choice.Proprietary),nameof(FormOfSecurity7Choice.Proprietary))]
    [IsoId("_5NZUzpNLEeWGlc8L7oPDIg")]
    [DisplayName("Form Of Security 7 Choice")]
    public abstract partial record FormOfSecurity7Choice_
    {
    }
}
