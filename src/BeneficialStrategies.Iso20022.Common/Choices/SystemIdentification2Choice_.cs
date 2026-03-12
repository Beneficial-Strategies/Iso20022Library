// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information used to identify a cash clearing system.
    /// </summary>
    [KnownType(typeof(SystemIdentification2Choice.MarketInfrastructureIdentification))]
    [KnownType(typeof(SystemIdentification2Choice.Country))]
    [JsonDerivedType(typeof(SystemIdentification2Choice.MarketInfrastructureIdentification),nameof(SystemIdentification2Choice.MarketInfrastructureIdentification))]
    [JsonDerivedType(typeof(SystemIdentification2Choice.Country),nameof(SystemIdentification2Choice.Country))]
    [IsoId("_8BZ3QaMgEeCJ6YNENx4h-w_-1347709917")]
    [DisplayName("System Identification 2 Choice")]
    public abstract partial record SystemIdentification2Choice_
    {
    }
}
