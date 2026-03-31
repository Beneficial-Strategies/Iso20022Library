// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of a person and the identification of a non-financial institution.
    /// </summary>
    [KnownType(typeof(Party2Choice.OrganisationIdentification))]
    [KnownType(typeof(Party2Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party2Choice.OrganisationIdentification),
        nameof(Party2Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party2Choice.PrivateIdentification),
        nameof(Party2Choice.PrivateIdentification)
    )]
    [IsoId("_RCDQ4Np-Ed-ak6NoX_4Aeg_-1691234030")]
    [DisplayName("Party 2 Choice")]
    public abstract record Party2Choice_ { }
}
