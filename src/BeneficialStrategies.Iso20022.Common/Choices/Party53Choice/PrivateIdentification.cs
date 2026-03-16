// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party53Choice
{
    /// <summary>
    /// Private Identification.
    /// </summary>
    [DisplayName("Private Identification")]
    public partial record PrivateIdentification : Party53Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrvtId")]
        public required PersonIdentification20 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
