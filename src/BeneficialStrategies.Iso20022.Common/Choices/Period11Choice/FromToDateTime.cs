// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Period11Choice
{
    /// <summary>
    /// From To Date Time.
    /// </summary>
    [DisplayName("From To Date Time")]
    public partial record FromToDateTime : Period11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("FrToDtTm")]
        public required DateTimePeriod1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
