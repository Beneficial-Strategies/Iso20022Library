// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation4Choice
{
    /// <summary>
    /// Non Confirmed.
    /// </summary>
    [DisplayName("Non Confirmed")]
    public partial record NonConfirmed : TradeConfirmation4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NonConfd")]
        public required TradeNonConfirmation1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
