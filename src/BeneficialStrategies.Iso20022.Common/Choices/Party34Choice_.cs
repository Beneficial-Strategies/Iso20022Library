// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party34Choice.OrganisationIdentification))]
    [KnownType(typeof(Party34Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party34Choice.OrganisationIdentification),
        nameof(Party34Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party34Choice.PrivateIdentification),
        nameof(Party34Choice.PrivateIdentification)
    )]
    [IsoId("_jzRp6a9UEeeJJK1oRb-jTw")]
    [DisplayName("Party 34 Choice")]
    public abstract record Party34Choice_ { }
}
