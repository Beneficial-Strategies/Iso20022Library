// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cleared12Choice
{
    /// <summary>
    /// Indicates that the contract has not been cleared.
    /// </summary>
    [IsoId("_Bemz9exYEemioJdkOVFBdw")]
    [DisplayName("Non Cleared")]
    public partial record NonCleared : Cleared12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NonClrd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
