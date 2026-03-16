// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Person Or Organisation4Choice.
    /// </summary>
    [KnownType(typeof(PersonOrOrganisation4Choice.ExceptionIdentification))]
    [KnownType(typeof(PersonOrOrganisation4Choice.LEI))]
    [KnownType(typeof(PersonOrOrganisation4Choice.Person))]
    [JsonDerivedType(typeof(PersonOrOrganisation4Choice.ExceptionIdentification),nameof(PersonOrOrganisation4Choice.ExceptionIdentification))]
    [JsonDerivedType(typeof(PersonOrOrganisation4Choice.LEI),nameof(PersonOrOrganisation4Choice.LEI))]
    [JsonDerivedType(typeof(PersonOrOrganisation4Choice.Person),nameof(PersonOrOrganisation4Choice.Person))]
    [IsoId("_gwG4sSCYEe64P8jfINlL1Q")]
    [DisplayName("Person Or Organisation4Choice")]
    public abstract partial record PersonOrOrganisation4Choice_
    {
    }
}
