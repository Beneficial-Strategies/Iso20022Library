// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentification1Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification1Choice.PersonName))]
    [JsonDerivedType(typeof(IndividualPersonIdentification1Choice.IdentificationNumber),nameof(IndividualPersonIdentification1Choice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentification1Choice.PersonName),nameof(IndividualPersonIdentification1Choice.PersonName))]
    [IsoId("_gbR24SFWEeWgV9SQSyaAog")]
    [DisplayName("Individual Person Identification 1 Choice")]
    public abstract partial record IndividualPersonIdentification1Choice_
    {
    }
}
