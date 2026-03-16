// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice
{
    /// <summary>
    /// Direct Debit Mandate.
    /// </summary>
    [DisplayName("Direct Debit Mandate")]
    public partial record DirectDebitMandate : MandateRelatedData3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DrctDbtMndt")]
        public required MandateRelatedInformation16 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
