// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty16Choice.Seller))]
    [KnownType(typeof(Counterparty16Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty16Choice.Seller),nameof(Counterparty16Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty16Choice.Buyer),nameof(Counterparty16Choice.Buyer))]
    [IsoId("_c69UwTi8Eeydid5dcNPKvg")]
    [DisplayName("Counterparty 16 Choice")]
    public abstract partial record Counterparty16Choice_
    {
    }
}
