// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClientSide1Choice
{
    /// <summary>
    /// Market side or a client side information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QvuKxtp-Ed-ak6NoX_4Aeg_-2044453579")]
    [DisplayName("Code")]
    public record Code : MarketClientSide1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if an instruction is for a market or client side transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketClientSideCode Value { get; init; }
    }
}
