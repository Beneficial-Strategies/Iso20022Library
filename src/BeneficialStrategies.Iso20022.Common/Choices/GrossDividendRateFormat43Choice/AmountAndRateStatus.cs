// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat43Choice
{
    /// <summary>
    /// Amount And Rate Status.
    /// </summary>
    [DisplayName("Amount And Rate Status")]
    public partial record AmountAndRateStatus : GrossDividendRateFormat43Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtAndRateSts")]
        public required AmountAndRateStatus1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
