// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification5Choice
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    public partial record Description : MarketIdentification5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Desc")]
        public required IsoMax140Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
