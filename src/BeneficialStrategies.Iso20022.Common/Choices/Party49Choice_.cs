// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party49Choice.OrganisationIdentification))]
    [KnownType(typeof(Party49Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party49Choice.OrganisationIdentification),
        nameof(Party49Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party49Choice.PrivateIdentification),
        nameof(Party49Choice.PrivateIdentification)
    )]
    [IsoId("_dPk6ceEpEemRzcIkmUETeA")]
    [DisplayName("Party 49 Choice")]
    public abstract record Party49Choice_ { }
}
