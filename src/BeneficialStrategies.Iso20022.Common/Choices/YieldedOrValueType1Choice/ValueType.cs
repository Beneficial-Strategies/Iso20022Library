// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.YieldedOrValueType1Choice
{
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_RdBVqNp-Ed-ak6NoX_4Aeg_599544875")]
    [DisplayName("Value Type")]
    public record ValueType : YieldedOrValueType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of value of the price.
        /// </summary>
        [IsoXmlTag("ValTp")]
        public required PriceValueType1Code Value { get; init; }
    }
}
