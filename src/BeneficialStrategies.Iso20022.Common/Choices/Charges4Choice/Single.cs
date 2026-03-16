// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Charges4Choice
{
    /// <summary>
    /// Single.
    /// </summary>
    [DisplayName("Single")]
    public partial record Single : Charges4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Sngl")]
        public required ChargesRecord10 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
