// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError4Choice
{
    /// <summary>
    /// Business Error.
    /// </summary>
    [DisplayName("Business Error")]
    public partial record BusinessError : PartyOrBusinessError4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("BizErr")]
        public required ErrorHandling4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
