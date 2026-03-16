// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party11Choice.OrganisationIdentification))]
    [KnownType(typeof(Party11Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party11Choice.OrganisationIdentification),
        nameof(Party11Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party11Choice.PrivateIdentification),
        nameof(Party11Choice.PrivateIdentification)
    )]
    [IsoId("_PWnCwtp-Ed-ak6NoX_4Aeg_2128331948")]
    [DisplayName("Party 11 Choice")]
    public abstract record Party11Choice_ { }
}
