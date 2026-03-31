// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty4Choice.Seller))]
    [KnownType(typeof(Counterparty4Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty4Choice.Seller), nameof(Counterparty4Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty4Choice.Buyer), nameof(Counterparty4Choice.Buyer))]
    [IsoId("_eanNmeaOEd-q8fx_Zl_34A")]
    [DisplayName("Counterparty 4 Choice")]
    public abstract record Counterparty4Choice_ { }
}
