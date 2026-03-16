// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty5Choice.Seller))]
    [KnownType(typeof(Counterparty5Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty5Choice.Seller), nameof(Counterparty5Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty5Choice.Buyer), nameof(Counterparty5Choice.Buyer))]
    [IsoId("_idvrweaOEd-q8fx_Zl_34A")]
    [DisplayName("Counterparty 5 Choice")]
    public abstract record Counterparty5Choice_ { }
}
