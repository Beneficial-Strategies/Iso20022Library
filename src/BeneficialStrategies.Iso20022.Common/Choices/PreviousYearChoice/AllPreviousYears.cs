// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PreviousYearChoice
{
    /// <summary>
    /// Selection ot the entirety of the investment plans.
    /// </summary>
    [IsoId("_Rb-Mwtp-Ed-ak6NoX_4Aeg_-602919807")]
    [DisplayName("All Previous Years")]
    public partial record AllPreviousYears : PreviousYearChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that the investment plan issued during all the previous years have to be transferred.
        /// </summary>
        [IsoXmlTag("AllPrvsYrs")]
        [IsoSimpleType(IsoSimpleType.PreviousAll)]
        public required IsoPreviousAll Value { get; init; } 
        
        
        #nullable disable
        
    }
}
