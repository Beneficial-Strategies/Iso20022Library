// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateType12FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of rate.
    /// </summary>
    [IsoId("_RnTTAtp-Ed-ak6NoX_4Aeg_-1511308649")]
    [DisplayName("Code")]
    public partial record Code : RateType12FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
