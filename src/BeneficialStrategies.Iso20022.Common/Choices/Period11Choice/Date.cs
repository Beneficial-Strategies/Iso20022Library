// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Period11Choice
{
    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    public partial record Date : Period11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Dt")]
        public required IsoISODate Value { get; init; } 
        
        
        #nullable disable
        
    }
}
