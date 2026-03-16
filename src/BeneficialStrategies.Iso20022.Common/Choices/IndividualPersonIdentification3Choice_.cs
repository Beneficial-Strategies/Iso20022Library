// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentification3Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification3Choice.PersonName))]
    [JsonDerivedType(
        typeof(IndividualPersonIdentification3Choice.IdentificationNumber),
        nameof(IndividualPersonIdentification3Choice.IdentificationNumber)
    )]
    [JsonDerivedType(
        typeof(IndividualPersonIdentification3Choice.PersonName),
        nameof(IndividualPersonIdentification3Choice.PersonName)
    )]
    [IsoId("_GWjI8YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Individual Person Identification 3 Choice")]
    public abstract record IndividualPersonIdentification3Choice_ { }
}
