// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification3Choice
{
    /// <summary>
    /// Market Specific Attribute.
    /// </summary>
    [DisplayName("Market Specific Attribute")]
    public partial record MarketSpecificAttribute : SystemPartyModification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MktSpcfcAttr")]
        public required MarketSpecificAttribute1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
