// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity7Choice
{
    /// <summary>
    /// Other C10.
    /// </summary>
    [DisplayName("Other C10")]
    public partial record OtherC10 : AssetClassCommodity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OthrC10")]
        public required AssetClassCommodityC10Other1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
