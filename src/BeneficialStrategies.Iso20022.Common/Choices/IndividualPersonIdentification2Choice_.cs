// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentification2Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification2Choice.PersonName))]
    [JsonDerivedType(typeof(IndividualPersonIdentification2Choice.IdentificationNumber),nameof(IndividualPersonIdentification2Choice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentification2Choice.PersonName),nameof(IndividualPersonIdentification2Choice.PersonName))]
    [IsoId("_5uE1YSGZEeWKAaDJcYGKLw")]
    [DisplayName("Individual Person Identification 2 Choice")]
    public abstract partial record IndividualPersonIdentification2Choice_
    {
    }
}
