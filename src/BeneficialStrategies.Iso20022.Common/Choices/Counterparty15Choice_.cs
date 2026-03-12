// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty15Choice.Seller))]
    [KnownType(typeof(Counterparty15Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty15Choice.Seller),nameof(Counterparty15Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty15Choice.Buyer),nameof(Counterparty15Choice.Buyer))]
    [IsoId("_tllw7SqDEeyR9JrVGfaMKw")]
    [DisplayName("Counterparty 15 Choice")]
    public abstract partial record Counterparty15Choice_
    {
    }
}
