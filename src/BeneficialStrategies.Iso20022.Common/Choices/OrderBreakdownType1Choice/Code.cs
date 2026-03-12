// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderBreakdownType1Choice
{
    /// <summary>
    /// Order breakdown type expressed as a code.
    /// </summary>
    [IsoId("_4Ff_gjhjEeamLZQeccJa7w")]
    [DisplayName("Code")]
    public partial record Code : OrderBreakdownType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the category of the investment fund order.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundOrderType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
