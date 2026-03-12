// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeType3Choice
{
    /// <summary>
    /// Trade type information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AXK_VdokEeC60axPepSq7g_1214802521")]
    [DisplayName("Code")]
    public partial record Code : TradeType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of executed order.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
