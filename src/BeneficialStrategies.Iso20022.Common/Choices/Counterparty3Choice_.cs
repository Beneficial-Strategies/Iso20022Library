// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty3Choice.Seller))]
    [KnownType(typeof(Counterparty3Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty3Choice.Seller),nameof(Counterparty3Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty3Choice.Buyer),nameof(Counterparty3Choice.Buyer))]
    [IsoId("_K14CX-aOEd-q8fx_Zl_34A")]
    [DisplayName("Counterparty 3 Choice")]
    public abstract partial record Counterparty3Choice_
    {
    }
}
