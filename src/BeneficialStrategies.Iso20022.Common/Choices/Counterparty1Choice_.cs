// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty1Choice.Seller))]
    [KnownType(typeof(Counterparty1Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty1Choice.Seller), nameof(Counterparty1Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty1Choice.Buyer), nameof(Counterparty1Choice.Buyer))]
    [IsoId("_PYGQidp-Ed-ak6NoX_4Aeg_1620346563")]
    [DisplayName("Counterparty 1 Choice")]
    public abstract record Counterparty1Choice_ { }
}
