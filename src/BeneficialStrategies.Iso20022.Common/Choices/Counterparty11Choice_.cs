// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty11Choice.Seller))]
    [KnownType(typeof(Counterparty11Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty11Choice.Seller), nameof(Counterparty11Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty11Choice.Buyer), nameof(Counterparty11Choice.Buyer))]
    [IsoId("_N0Z5Ua5YEeey8N0JWnVPUw")]
    [DisplayName("Counterparty 11 Choice")]
    public abstract record Counterparty11Choice_ { }
}
