// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity7Choice
{
    /// <summary>
    /// Polypropylene.
    /// </summary>
    [DisplayName("Polypropylene")]
    public partial record Polypropylene : AssetClassCommodity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Plprpln")]
        public required AssetClassCommodityPolypropylene4Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
