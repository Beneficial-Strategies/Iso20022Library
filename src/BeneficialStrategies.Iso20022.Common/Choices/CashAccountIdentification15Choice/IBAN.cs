// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification15Choice
{
    /// <summary>
    /// IBAN.
    /// </summary>
    [DisplayName("IBAN")]
    public partial record IBAN : CashAccountIdentification15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IBAN")]
        public required IsoIBAN2007Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
