// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty12Choice.Seller))]
    [KnownType(typeof(Counterparty12Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty12Choice.Seller),nameof(Counterparty12Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty12Choice.Buyer),nameof(Counterparty12Choice.Buyer))]
    [IsoId("_5ToeNc3yEee5nJBZsW8MFQ")]
    [DisplayName("Counterparty 12 Choice")]
    public abstract partial record Counterparty12Choice_
    {
    }
}
