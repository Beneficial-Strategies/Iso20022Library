// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductCategory1Choice
{
    /// <summary>
    /// Specifies the type of product category.
    /// </summary>
    [IsoId("_RbrR19p-Ed-ak6NoX_4Aeg_1854520026")]
    [DisplayName("Structured Product Category")]
    [IsoXmlTag("StrdPdctCtgy")]
    public record StructuredProductCategory : ProductCategory1Choice_
    {
        /// <summary>
        /// Specifies the type of product category by means of a code.
        /// </summary>
        [IsoId("_T5CFHNp-Ed-ak6NoX_4Aeg_-1686636659")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ProductCategory1Code Type { get; init; }

        /// <summary>
        /// Specifies the category of a product.
        /// </summary>
        [IsoId("_T5L2ENp-Ed-ak6NoX_4Aeg_-1658931027")]
        [DisplayName("Category")]
        [IsoXmlTag("Ctgy")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Category { get; init; }
    }
}
