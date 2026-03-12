// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReason2Choice
{
    /// <summary>
    /// Tax exemption reason expressed as a code.
    /// </summary>
    [IsoId("_PE3O0SDAEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public partial record Code : TaxExemptionReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxExemptReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
