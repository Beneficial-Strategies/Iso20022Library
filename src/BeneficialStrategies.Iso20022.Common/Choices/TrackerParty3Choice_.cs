// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Tracker Party3Choice.
    /// </summary>
    [KnownType(typeof(TrackerParty3Choice.FinancialInstitutionIdentification))]
    [KnownType(typeof(TrackerParty3Choice.OrganisationIdentification))]
    [KnownType(typeof(TrackerParty3Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(TrackerParty3Choice.FinancialInstitutionIdentification),nameof(TrackerParty3Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(TrackerParty3Choice.OrganisationIdentification),nameof(TrackerParty3Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(TrackerParty3Choice.PrivateIdentification),nameof(TrackerParty3Choice.PrivateIdentification))]
    [IsoId("_IYmWMTFKEe651u5xu3f5iw")]
    [DisplayName("Tracker Party3Choice")]
    public abstract partial record TrackerParty3Choice_
    {
    }
}
