// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Account12Choice
{
    /// <summary>
    /// Charges Account.
    /// </summary>
    [DisplayName("Charges Account")]
    public partial record ChargesAccount : Account12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ChrgsAcct")]
        public required CashAccountIdentification6Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
