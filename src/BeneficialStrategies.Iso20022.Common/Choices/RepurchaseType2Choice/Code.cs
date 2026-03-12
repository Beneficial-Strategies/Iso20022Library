// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType2Choice
{
    /// <summary>
    /// Type of securities financing transaction process expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtL0Jtp-Ed-ak6NoX_4Aeg_566735114")]
    [DisplayName("Code")]
    public partial record Code : RepurchaseType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of repurchase process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepurchaseType4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
