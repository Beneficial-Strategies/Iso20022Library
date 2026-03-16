// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderRestriction1Choice
{
    /// <summary>
    /// Order Restriction Code.
    /// </summary>
    [DisplayName("Order Restriction Code")]
    public record OrderRestrictionCode : OrderRestriction1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrdrRstrctnCd")]
        public required OrderRestrictionType1Code Value { get; init; }
    }
}
