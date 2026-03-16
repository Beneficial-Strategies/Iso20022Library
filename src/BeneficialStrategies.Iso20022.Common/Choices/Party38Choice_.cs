// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party38Choice.OrganisationIdentification))]
    [KnownType(typeof(Party38Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party38Choice.OrganisationIdentification),
        nameof(Party38Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party38Choice.PrivateIdentification),
        nameof(Party38Choice.PrivateIdentification)
    )]
    [IsoId("_6L-JzW48EeiU9cctagi5ow")]
    [DisplayName("Party 38 Choice")]
    public abstract record Party38Choice_ { }
}
