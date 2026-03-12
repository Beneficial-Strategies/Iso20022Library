// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType7Choice
{
    /// <summary>
    /// Type of securities financing transaction process expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_WNdtg9uJEd-RF5yaMAVhAw")]
    [DisplayName("Code")]
    public partial record Code : RepurchaseType7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of repurchase process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepurchaseType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
