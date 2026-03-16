// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetHolding3Choice
{
    /// <summary>
    /// Commodity.
    /// </summary>
    [DisplayName("Commodity")]
    public partial record Commodity : AssetHolding3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmmdty")]
        public required Commodity2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
