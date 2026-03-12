// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the market infrastructure identification.
    /// </summary>
    [KnownType(typeof(MarketInfrastructureIdentification1Choice.Code))]
    [KnownType(typeof(MarketInfrastructureIdentification1Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketInfrastructureIdentification1Choice.Code),nameof(MarketInfrastructureIdentification1Choice.Code))]
    [JsonDerivedType(typeof(MarketInfrastructureIdentification1Choice.Proprietary),nameof(MarketInfrastructureIdentification1Choice.Proprietary))]
    [IsoId("_8BQtWKMgEeCJ6YNENx4h-w_739589116")]
    [DisplayName("Market Infrastructure Identification 1 Choice")]
    public abstract partial record MarketInfrastructureIdentification1Choice_
    {
    }
}
