// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat79Choice
{
    /// <summary>
    /// Index Points.
    /// </summary>
    [DisplayName("Index Points")]
    public partial record IndexPoints : PriceFormat79Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndxPts")]
        public required IsoDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
