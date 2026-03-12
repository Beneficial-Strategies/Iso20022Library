// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat5Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("__XFDg-wOEd-sn-FiNtktcA")]
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : NetDividendRateFormat5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
