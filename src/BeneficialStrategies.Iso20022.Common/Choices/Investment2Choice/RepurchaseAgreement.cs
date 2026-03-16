// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Investment2Choice
{
    /// <summary>
    /// Repurchase Agreement.
    /// </summary>
    [DisplayName("Repurchase Agreement")]
    public partial record RepurchaseAgreement : Investment2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RpAgrmt")]
        public required RepurchaseAgreement2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
