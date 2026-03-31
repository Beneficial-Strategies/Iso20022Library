// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for form of security.
    /// </summary>
    [KnownType(typeof(FormOfSecurity8Choice.Code))]
    [KnownType(typeof(FormOfSecurity8Choice.Proprietary))]
    [JsonDerivedType(typeof(FormOfSecurity8Choice.Code), nameof(FormOfSecurity8Choice.Code))]
    [JsonDerivedType(
        typeof(FormOfSecurity8Choice.Proprietary),
        nameof(FormOfSecurity8Choice.Proprietary)
    )]
    [IsoId("_dhNzFeLxEeWOD7aAy2fAcA")]
    [DisplayName("Form Of Security 8 Choice")]
    public abstract record FormOfSecurity8Choice_ { }
}
