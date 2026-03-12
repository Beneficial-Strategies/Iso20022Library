// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice22Choice
{
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument, when the price is available in both monetary value and digital token amount.
    /// </summary>
    [IsoId("_fc2HMKOrEe2UDKy7o9_HIg")]
    [DisplayName("Digital Token Price")]
    public partial record DigitalTokenPrice : SecuritiesTransactionPrice22Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Price expressed as a monetary value.
        /// </summary>
        [IsoId("_i9PTAZiuEe2f7NHvXATP5g")]
        [DisplayName("Monetary Value")]
        [IsoXmlTag("MntryVal")]
        public required AmountAndDirection61 MonetaryValue { get; init; } 
        
        /// <summary>
        /// Price expressed as a number of digital tokens.
        /// </summary>
        [IsoId("_o26cIJiuEe2f7NHvXATP5g")]
        [DisplayName("Digital Token Quantity")]
        [IsoXmlTag("DgtlTknQty")]
        public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
        
        
        #nullable disable
        
    }
}
