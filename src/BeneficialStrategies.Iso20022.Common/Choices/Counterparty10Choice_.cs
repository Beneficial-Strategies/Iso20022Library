// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty10Choice.Seller))]
    [KnownType(typeof(Counterparty10Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty10Choice.Seller), nameof(Counterparty10Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty10Choice.Buyer), nameof(Counterparty10Choice.Buyer))]
    [IsoId("_5myFAJNLEeWGlc8L7oPDIg")]
    [DisplayName("Counterparty 10 Choice")]
    public abstract record Counterparty10Choice_ { }
}
