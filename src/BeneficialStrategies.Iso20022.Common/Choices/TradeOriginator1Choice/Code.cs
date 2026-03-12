// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeOriginator1Choice
{
    /// <summary>
    /// Trading party capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QsvINdp-Ed-ak6NoX_4Aeg_-776260701")]
    [DisplayName("Code")]
    public partial record Code : TradeOriginator1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the trading party in the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OriginatorRole2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
