// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralType22Choice
{
    /// <summary>
    /// Specific Collateral.
    /// </summary>
    [DisplayName("Specific Collateral")]
    public partial record SpecificCollateral : CollateralType22Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SpcfcColl")]
        public required SpecificCollateral3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
