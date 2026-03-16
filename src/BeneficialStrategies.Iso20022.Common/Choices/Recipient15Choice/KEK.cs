// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient15Choice
{
    /// <summary>
    /// KEK.
    /// </summary>
    [DisplayName("KEK")]
    public partial record KEK : Recipient15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("KEK")]
        public required KEK9 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
