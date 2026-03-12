// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty9Choice.Seller))]
    [KnownType(typeof(Counterparty9Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty9Choice.Seller),nameof(Counterparty9Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty9Choice.Buyer),nameof(Counterparty9Choice.Buyer))]
    [IsoId("_GBj6HR5dEeWE3PufGMdJ3w")]
    [DisplayName("Counterparty 9 Choice")]
    public abstract partial record Counterparty9Choice_
    {
    }
}
