// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Period11Choice
{
    /// <summary>
    /// To Date.
    /// </summary>
    [DisplayName("To Date")]
    public partial record ToDate : Period11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ToDt")]
        public required IsoISODate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
