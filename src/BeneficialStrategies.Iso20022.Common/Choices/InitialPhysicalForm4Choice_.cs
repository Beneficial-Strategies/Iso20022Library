// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for initial physical form.
    /// </summary>
    [KnownType(typeof(InitialPhysicalForm4Choice.Code))]
    [KnownType(typeof(InitialPhysicalForm4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InitialPhysicalForm4Choice.Code),
        nameof(InitialPhysicalForm4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InitialPhysicalForm4Choice.Proprietary),
        nameof(InitialPhysicalForm4Choice.Proprietary)
    )]
    [IsoId("_UjitceLxEeWOD7aAy2fAcA")]
    [DisplayName("Initial Physical Form 4 Choice")]
    public abstract record InitialPhysicalForm4Choice_ { }
}
