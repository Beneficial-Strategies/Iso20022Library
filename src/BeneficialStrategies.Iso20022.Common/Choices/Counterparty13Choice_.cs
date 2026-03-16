// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty13Choice.Seller))]
    [KnownType(typeof(Counterparty13Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty13Choice.Seller), nameof(Counterparty13Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty13Choice.Buyer), nameof(Counterparty13Choice.Buyer))]
    [IsoId("_9RmwddLCEeiN28wlpBQScw")]
    [DisplayName("Counterparty 13 Choice")]
    public abstract record Counterparty13Choice_ { }
}
