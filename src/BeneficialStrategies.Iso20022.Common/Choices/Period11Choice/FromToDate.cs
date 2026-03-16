// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Period11Choice
{
    /// <summary>
    /// From To Date.
    /// </summary>
    [DisplayName("From To Date")]
    public partial record FromToDate : Period11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("FrToDt")]
        public required Period2 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
