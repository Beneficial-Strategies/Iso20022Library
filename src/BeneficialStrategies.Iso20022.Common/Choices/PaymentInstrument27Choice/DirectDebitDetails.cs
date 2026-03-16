// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument27Choice
{
    /// <summary>
    /// Direct Debit Details.
    /// </summary>
    [DisplayName("Direct Debit Details")]
    public partial record DirectDebitDetails : PaymentInstrument27Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DrctDbtDtls")]
        public required DirectDebitMandate8 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
