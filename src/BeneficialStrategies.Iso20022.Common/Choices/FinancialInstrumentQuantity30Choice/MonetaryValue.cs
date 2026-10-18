// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity30Choice
{
    /// <summary>
    /// Indicates that quantity is expressed as a monetary value.
    /// </summary>
    [IsoId("_zSz2p_9jEea3W_f2lS_aiw")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : FinancialInstrumentQuantity30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MntryVal")]
        public required ImpliedCurrencyAnd20Amount Value { get; init; }
    }
}
