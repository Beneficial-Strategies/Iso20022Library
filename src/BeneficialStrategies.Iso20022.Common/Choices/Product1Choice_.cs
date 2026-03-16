// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice between the major categories of financial instruments.
    /// </summary>
    [KnownType(typeof(Product1Choice.Derivative))]
    [KnownType(typeof(Product1Choice.SecuritiesFinancingTransaction))]
    [KnownType(typeof(Product1Choice.Security))]
    [JsonDerivedType(typeof(Product1Choice.Derivative), nameof(Product1Choice.Derivative))]
    [JsonDerivedType(
        typeof(Product1Choice.SecuritiesFinancingTransaction),
        nameof(Product1Choice.SecuritiesFinancingTransaction)
    )]
    [JsonDerivedType(typeof(Product1Choice.Security), nameof(Product1Choice.Security))]
    [IsoId("_AS4VYLVPEeadLcJesEbkTQ")]
    [DisplayName("Product 1 Choice")]
    public abstract record Product1Choice_ { }
}
