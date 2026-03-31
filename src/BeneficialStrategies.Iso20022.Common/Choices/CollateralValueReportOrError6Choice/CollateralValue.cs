// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueReportOrError6Choice
{
    /// <summary>
    /// Requested information on the value of the position for collateral purposes.
    /// </summary>
    [IsoId("_EP0oozpyEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public record CollateralValue : CollateralValueReportOrError6Choice_
    {
        /// <summary>
        /// Date and time when the data was last accessed.
        /// </summary>
        [IsoId("_EbS40TpyEemk2e6qGBk8IQ")]
        [DisplayName("Data Access Time")]
        [IsoXmlTag("DataAccsTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime DataAccessTime { get; init; }

        /// <summary>
        /// Total value of the collateral valuation.
        /// </summary>
        [IsoId("_EbS40zpyEemk2e6qGBk8IQ")]
        [DisplayName("Total Collateral Valuation")]
        [IsoXmlTag("TtlCollValtn")]
        public ActiveCurrencyAndAmount? TotalCollateralValuation { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the securities account.
        /// </summary>
        [IsoId("_EbS41TpyEemk2e6qGBk8IQ")]
        [DisplayName("Securities Account")]
        [IsoXmlTag("SctiesAcct")]
        public SecuritiesAccount19? SecuritiesAccount { get; init; }

        /// <summary>
        /// Unique identification, as known by the account owner, to unambiguously identify the securities on which the collateral value position is requested.
        /// </summary>
        [IsoId("_EbS41zpyEemk2e6qGBk8IQ")]
        [DisplayName("Securities")]
        [IsoXmlTag("Scties")]
        public SecurityCharacteristics3? Securities { get; init; }
    }
}
