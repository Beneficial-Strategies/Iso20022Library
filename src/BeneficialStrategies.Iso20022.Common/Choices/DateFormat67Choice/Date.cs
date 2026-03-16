// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat67Choice
{
    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    public partial record Date : DateFormat67Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Dt")]
        public required DateAndDateTime2Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
