// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionMandatoryVoluntary1FormatChoice
{
    /// <summary>
    /// Standard code to specify whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_RmZ7I9p-Ed-ak6NoX_4Aeg_-1747006967")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionMandatoryVoluntary1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the event is mandatory, mandatory with options or voluntary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionMandatoryVoluntary1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
