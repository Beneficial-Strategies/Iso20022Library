// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat94Choice
{
    /// <summary>
    /// Amount Price.
    /// </summary>
    [DisplayName("Amount Price")]
    public partial record AmountPrice : PriceFormat94Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AmtPric")]
        public required AmountPrice5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
