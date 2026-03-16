// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice
{
    /// <summary>
    /// Asset class is composed of both an interest derivate and a foreign exchange derivative.
    /// </summary>
    [IsoId("_vAX4UO94EeW7gabYEJmWIA")]
    [DisplayName("Both")]
    [IsoXmlTag("Both")]
    public record Both : AssetClassAttributes1Choice_
    {
        /// <summary>
        /// Asset class is a non-financial instrument of type interest rate.
        /// </summary>
        [IsoId("_IO1OE8nYEeWpf-ImB_F2gQ")]
        [DisplayName("Interest")]
        [IsoXmlTag("Intrst")]
        public required DerivativeInterest2 Interest { get; init; }

        /// <summary>
        /// Asset class is a non-financial instrument of type foreign exchange.
        /// </summary>
        [IsoId("_IO1OFcnYEeWpf-ImB_F2gQ")]
        [DisplayName("Foreign Exchange")]
        [IsoXmlTag("FX")]
        public required DerivativeForeignExchange2 ForeignExchange { get; init; }
    }
}
