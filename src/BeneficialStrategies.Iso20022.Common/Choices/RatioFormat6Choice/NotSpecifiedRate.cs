// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat6Choice
{
    /// <summary>
    /// Value of the ratio not specified.
    /// </summary>
    [IsoId("_Q1-jx9p-Ed-ak6NoX_4Aeg_-2128705007")]
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : RatioFormat6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
