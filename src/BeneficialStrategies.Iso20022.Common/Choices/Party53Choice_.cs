// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party53Choice.
    /// </summary>
    [KnownType(typeof(Party53Choice.OrganisationIdentification))]
    [KnownType(typeof(Party53Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party53Choice.OrganisationIdentification),nameof(Party53Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party53Choice.PrivateIdentification),nameof(Party53Choice.PrivateIdentification))]
    [IsoId("_HsxyATFKEe651u5xu3f5iw")]
    [DisplayName("Party53Choice")]
    public abstract partial record Party53Choice_
    {
    }
}
