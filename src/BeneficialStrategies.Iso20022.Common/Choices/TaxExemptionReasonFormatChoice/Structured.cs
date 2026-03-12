// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReasonFormatChoice
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_UzJj9Np-Ed-ak6NoX_4Aeg_-1748201268")]
    [DisplayName("Structured")]
    public partial record Structured : TaxExemptionReasonFormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required TaxExemptReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
