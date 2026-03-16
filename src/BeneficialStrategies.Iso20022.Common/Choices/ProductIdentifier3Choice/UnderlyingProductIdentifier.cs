// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProductIdentifier3Choice
{
    /// <summary>
    /// Underlying Product Identifier.
    /// </summary>
    [DisplayName("Underlying Product Identifier")]
    public partial record UnderlyingProductIdentifier : ProductIdentifier3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UndrlygPdctIdr")]
        public required UnderlyingProductIdentifier1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
