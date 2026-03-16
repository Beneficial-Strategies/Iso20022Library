// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party58Choice.
    /// </summary>
    [KnownType(typeof(Party58Choice.OrganisationIdentification))]
    [KnownType(typeof(Party58Choice.PrivateIdentification))]
    [JsonDerivedType(
        typeof(Party58Choice.OrganisationIdentification),
        nameof(Party58Choice.OrganisationIdentification)
    )]
    [JsonDerivedType(
        typeof(Party58Choice.PrivateIdentification),
        nameof(Party58Choice.PrivateIdentification)
    )]
    [IsoId("_dvPlgwJBEe-BSY_bts84pg")]
    [DisplayName("Party58Choice")]
    public abstract record Party58Choice_ { }
}
