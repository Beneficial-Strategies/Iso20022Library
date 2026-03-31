// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketInfrastructureIdentification1Choice
{
    /// <summary>
    /// Infrastructure through which the payment instruction is processed, as published in an external clearing system identification code list.
    /// </summary>
    [IsoId("_8BQtWaMgEeCJ6YNENx4h-w_-1124219834")]
    [DisplayName("Code")]
    public record Code : MarketInfrastructureIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
        /// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalMarketInfrastructure1Code Value { get; init; }
    }
}
