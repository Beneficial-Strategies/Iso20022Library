// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderType1Choice
{
    /// <summary>
    /// Liquidity transfer standing order type, in a coded form.
    /// </summary>
    [IsoId("_73bb4aMgEeCJ6YNENx4h-w_-1852211918")]
    [DisplayName("Code")]
    public record Code : StandingOrderType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StandingOrderType1Code Value { get; init; }
    }
}
