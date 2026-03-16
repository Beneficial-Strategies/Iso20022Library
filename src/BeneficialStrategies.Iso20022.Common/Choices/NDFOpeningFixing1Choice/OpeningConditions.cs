// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NDFOpeningFixing1Choice
{
    /// <summary>
    /// Used to provide the opening information associated with an NDF trade.
    /// </summary>
    [IsoId("_hvh9oLC1EeaYscKJ1tWGRA")]
    [DisplayName("Opening Conditions")]
    public record OpeningConditions : NDFOpeningFixing1Choice_
    {
        /// <summary>
        /// Specifies the settlement currency of the non deliverable trade.
        /// </summary>
        [IsoId("_teDWYJR-Eeak6e8_Fc5fQg")]
        [DisplayName("Settlement Currency")]
        [IsoXmlTag("SttlmCcy")]
        public required ActiveCurrencyCode SettlementCurrency { get; init; }

        /// <summary>
        /// Specifies the valuation date for a non deliverable trade.
        /// </summary>
        [IsoId("_XAtxMJR_Eeak6e8_Fc5fQg")]
        [DisplayName("Valuation Date")]
        [IsoXmlTag("ValtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValuationDate { get; init; }

        /// <summary>
        /// Specifies the rate source associated with the non deliverable trade.
        /// </summary>
        [IsoId("_q4iDMJUOEeak6e8_Fc5fQg")]
        [DisplayName("Settlement Rate Source")]
        [IsoXmlTag("SttlmRateSrc")]
        [MinLength(1)]
        [MaxLength(2)]
        public ValueList<SettlementRateSource1> SettlementRateSource { get; init; } = [];
    }
}
