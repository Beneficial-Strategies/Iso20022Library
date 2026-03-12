// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundOrderType5Choice
{
    /// <summary>
    /// Type of the investment fund order expressed as a code.
    /// </summary>
    [IsoId("_Ix7loV8rEeicg40_9gK9vQ")]
    [DisplayName("Code")]
    public partial record Code : FundOrderType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment fund transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundOrderType10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
