// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction8Choice
{
    /// <summary>
    /// Initiation.
    /// </summary>
    [DisplayName("Initiation")]
    public partial record Initiation : UnderlyingTransaction8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Initn")]
        public required UnderlyingPaymentInstruction9 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
