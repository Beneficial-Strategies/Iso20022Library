// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData3Choice
{
    /// <summary>
    /// Credit Transfer Mandate.
    /// </summary>
    [DisplayName("Credit Transfer Mandate")]
    public partial record CreditTransferMandate : MandateRelatedData3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CdtTrfMndt")]
        public required CreditTransferMandateData1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
