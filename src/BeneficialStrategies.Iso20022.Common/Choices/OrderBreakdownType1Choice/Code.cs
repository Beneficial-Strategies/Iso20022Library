// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderBreakdownType1Choice
{
    /// <summary>
    /// Order breakdown type expressed as a code.
    /// </summary>
    [IsoId("_4Ff_gjhjEeamLZQeccJa7w")]
    [DisplayName("Code")]
    public record Code : OrderBreakdownType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the category of the investment fund order.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundOrderType5Code Value { get; init; }
    }
}
