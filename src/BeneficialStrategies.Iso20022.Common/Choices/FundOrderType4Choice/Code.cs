// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundOrderType4Choice
{
    /// <summary>
    /// Type of the investment fund order expressed as a code.
    /// </summary>
    [IsoId("_EyIk0zhREeaRwdGFv45qTQ")]
    [DisplayName("Code")]
    public partial record Code : FundOrderType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the category of the investment fund order.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundOrderType8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
