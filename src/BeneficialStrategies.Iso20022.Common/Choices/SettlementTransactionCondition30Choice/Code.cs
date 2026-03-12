// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition30Choice
{
    /// <summary>
    /// Settlement condition expressed as a code.
    /// </summary>
    [IsoId("_1wpf00c8EeaBWtcfqEyXyw")]
    [DisplayName("Code")]
    public partial record Code : SettlementTransactionCondition30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions under which a order/trade is to be settled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementTransactionCondition11Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
