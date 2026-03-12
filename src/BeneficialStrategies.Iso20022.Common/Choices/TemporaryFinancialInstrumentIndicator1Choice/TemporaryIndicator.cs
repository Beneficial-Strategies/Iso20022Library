// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TemporaryFinancialInstrumentIndicator1Choice
{
    /// <summary>
    /// Temporary financial instrument identification used for processing reasons.
    /// </summary>
    [IsoId("_Q08B9Np-Ed-ak6NoX_4Aeg_-953773850")]
    [DisplayName("Temporary Indicator")]
    public partial record TemporaryIndicator : TemporaryFinancialInstrumentIndicator1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("TempInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
