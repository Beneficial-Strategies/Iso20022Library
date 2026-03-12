// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType2FormatChoice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_RjRupNp-Ed-ak6NoX_4Aeg_-1455569753")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventType2FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
