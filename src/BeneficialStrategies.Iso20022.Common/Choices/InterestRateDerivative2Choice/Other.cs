// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestRateDerivative2Choice
{
    /// <summary>
    /// Where contract type is different from swaps, swaptions, futures on swaps and forwards on a swap, this field is used.
    /// </summary>
    [IsoId("_xbbEc2lIEeaLAKoEUNsD9g")]
    [DisplayName("Other")]
    public partial record Other : InterestRateDerivative2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of an underlying contract for interest rate derivatives.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required UnderlyingInterestRateType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
