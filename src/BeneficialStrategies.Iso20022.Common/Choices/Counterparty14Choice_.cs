// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between buyer and seller.
    /// </summary>
    [KnownType(typeof(Counterparty14Choice.Seller))]
    [KnownType(typeof(Counterparty14Choice.Buyer))]
    [JsonDerivedType(typeof(Counterparty14Choice.Seller),nameof(Counterparty14Choice.Seller))]
    [JsonDerivedType(typeof(Counterparty14Choice.Buyer),nameof(Counterparty14Choice.Buyer))]
    [IsoId("_6slmIffVEeiNZp_PtLohLw")]
    [DisplayName("Counterparty 14 Choice")]
    public abstract partial record Counterparty14Choice_
    {
    }
}
