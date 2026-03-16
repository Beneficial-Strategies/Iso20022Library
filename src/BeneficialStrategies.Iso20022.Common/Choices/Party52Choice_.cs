// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party52Choice.
    /// </summary>
    [KnownType(typeof(Party52Choice.OrganisationIdentification))]
    [KnownType(typeof(Party52Choice.PrivateIdentification))]
    [JsonDerivedType(typeof(Party52Choice.OrganisationIdentification),nameof(Party52Choice.OrganisationIdentification))]
    [JsonDerivedType(typeof(Party52Choice.PrivateIdentification),nameof(Party52Choice.PrivateIdentification))]
    [IsoId("_bHNcUTFIEe651u5xu3f5iw")]
    [DisplayName("Party52Choice")]
    public abstract partial record Party52Choice_
    {
    }
}
