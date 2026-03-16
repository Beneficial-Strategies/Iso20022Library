// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat87Choice
{
    /// <summary>
    /// Index Points.
    /// </summary>
    [DisplayName("Index Points")]
    public partial record IndexPoints : PriceFormat87Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndxPts")]
        public required IsoRestrictedFINDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
