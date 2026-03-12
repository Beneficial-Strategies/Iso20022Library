// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party8Choice.OrganisationIdentification))]
    [KnownType(typeof(Party8Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party8Choice.OrganisationIdentification),nameof(Party8Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party8Choice.PrivateIdentification),nameof(Party8Choice.PrivateIdentification))]
    [IsoId("_PW59uNp-Ed-ak6NoX_4Aeg_-1799084049")]
    [DisplayName("Party 8 Choice")]
    public abstract partial record Party8Choice_
    {
    }
}
