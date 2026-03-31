// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies that the category of a product may be indicated by a code or by free text.
    /// </summary>
    [KnownType(typeof(ProductCategory1Choice.StructuredProductCategory))]
    [KnownType(typeof(ProductCategory1Choice.OtherProductCategory))]
    [JsonDerivedType(
        typeof(ProductCategory1Choice.StructuredProductCategory),
        nameof(ProductCategory1Choice.StructuredProductCategory)
    )]
    [JsonDerivedType(
        typeof(ProductCategory1Choice.OtherProductCategory),
        nameof(ProductCategory1Choice.OtherProductCategory)
    )]
    [IsoId("_RbrR1tp-Ed-ak6NoX_4Aeg_-1773751928")]
    [DisplayName("Product Category 1 Choice")]
    public abstract record ProductCategory1Choice_ { }
}
