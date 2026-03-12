// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction1Choice
{
    /// <summary>
    /// Indicates whether the option, for example, currency option, will be selected by default if no instruction is provided by the account owner.
    /// </summary>
    [IsoId("_Q0VlA9p-Ed-ak6NoX_4Aeg_-887513505")]
    [DisplayName("Default Option Indicator")]
    public partial record DefaultOptionIndicator : DefaultProcessingOrStandingInstruction1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("DfltOptnInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
