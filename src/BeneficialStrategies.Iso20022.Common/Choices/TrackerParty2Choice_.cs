// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(TrackerParty2Choice.OrganisationIdentification))]
    [KnownType(typeof(TrackerParty2Choice.PrivateIdentification))]
    [KnownType(typeof(TrackerParty2Choice.FinancialInstitutionIdentification))]
    [JsonDerivedType(typeof(TrackerParty2Choice.OrganisationIdentification),nameof(TrackerParty2Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(TrackerParty2Choice.PrivateIdentification),nameof(TrackerParty2Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(TrackerParty2Choice.FinancialInstitutionIdentification),nameof(TrackerParty2Choice.FinancialInstitutionIdentification))]
    [IsoId("_dWHWv2OTEeq5Ar_w98FvsA")]
    [DisplayName("Tracker Party 2 Choice")]
    public abstract partial record TrackerParty2Choice_
    {
    }
}
