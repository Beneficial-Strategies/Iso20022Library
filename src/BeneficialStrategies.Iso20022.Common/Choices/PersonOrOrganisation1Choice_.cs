// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of a person or an organisation.
    /// </summary>
    [KnownType(typeof(PersonOrOrganisation1Choice.LEI))]
    [KnownType(typeof(PersonOrOrganisation1Choice.MIC))]
    [KnownType(typeof(PersonOrOrganisation1Choice.Person))]
    [KnownType(typeof(PersonOrOrganisation1Choice.Internal))]
    [JsonDerivedType(
        typeof(PersonOrOrganisation1Choice.LEI),
        nameof(PersonOrOrganisation1Choice.LEI)
    )]
    [JsonDerivedType(
        typeof(PersonOrOrganisation1Choice.MIC),
        nameof(PersonOrOrganisation1Choice.MIC)
    )]
    [JsonDerivedType(
        typeof(PersonOrOrganisation1Choice.Person),
        nameof(PersonOrOrganisation1Choice.Person)
    )]
    [JsonDerivedType(
        typeof(PersonOrOrganisation1Choice.Internal),
        nameof(PersonOrOrganisation1Choice.Internal)
    )]
    [IsoId("_va6b4PPYEeS_qLctCs2aRQ")]
    [DisplayName("Person Or Organisation 1 Choice")]
    public abstract record PersonOrOrganisation1Choice_ { }
}
