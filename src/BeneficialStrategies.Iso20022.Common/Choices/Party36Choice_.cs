// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party36Choice.OrganisationIdentification))]
    [KnownType(typeof(Party36Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party36Choice.OrganisationIdentification),
        nameof(Party36Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party36Choice.PrivateIdentification),
        nameof(Party36Choice.PrivateIdentification)
    )]
    [IsoId("_2lSwceWkEeevU7McUP3D1w")]
    [DisplayName("Party 36 Choice")]
    public abstract record Party36Choice_ { }
}
