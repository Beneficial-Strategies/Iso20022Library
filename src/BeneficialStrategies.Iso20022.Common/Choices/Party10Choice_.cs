// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party10Choice.OrganisationIdentification))]
    [KnownType(typeof(Party10Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party10Choice.OrganisationIdentification),nameof(Party10Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party10Choice.PrivateIdentification),nameof(Party10Choice.PrivateIdentification))]
    [IsoId("_PWwzwtp-Ed-ak6NoX_4Aeg_-2096726580")]
    [DisplayName("Party 10 Choice")]
    public abstract partial record Party10Choice_
    {
    }
}
