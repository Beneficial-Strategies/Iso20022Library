// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice
{
    /// <summary>
    /// Original Debtor Identification.
    /// </summary>
    [DisplayName("Original Debtor Identification")]
    public partial record OriginalDebtorIdentification : OriginalActivation3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OrgnlDbtrId")]
        public required Party53Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
