// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementFailsDailyTransactionType1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_9tfhFTOYEeqBfed1bmSPqg")]
    [DisplayName("Data")]
    public record Data : SettlementFailsDailyTransactionType1Choice_
    {
        /// <summary>
        /// Purchase or sale of securities.
        /// </summary>
        [IsoId("_MU7YoTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Securities Buy Or Sell")]
        [IsoXmlTag("SctiesBuyOrSell")]
        public required SettlementFailsDailyCSD1Choice_ SecuritiesBuyOrSell { get; init; }

        /// <summary>
        /// Relates to securities transfers aiming to provide or to return collateral.
        /// </summary>
        [IsoId("_MU7YozOmEeqX8uoQQ3KffQ")]
        [DisplayName("Collateral Management Operation")]
        [IsoXmlTag("CollMgmtOpr")]
        public required SettlementFailsDailyCSD1Choice_ CollateralManagementOperation { get; init; }

        /// <summary>
        /// Relates to a securities lending or borrowing operation.
        /// </summary>
        [IsoId("_MU7YpTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Securities Lending Or Borrowing")]
        [IsoXmlTag("SctiesLndgOrBrrwg")]
        public required SettlementFailsDailyCSD1Choice_ SecuritiesLendingOrBorrowing { get; init; }

        /// <summary>
        /// Repurchase transactions.
        /// </summary>
        [IsoId("_MU7YpzOmEeqX8uoQQ3KffQ")]
        [DisplayName("Repurchase Agreement")]
        [IsoXmlTag("RpAgrmt")]
        public required SettlementFailsDailyCSD1Choice_ RepurchaseAgreement { get; init; }

        /// <summary>
        /// Covers any securities transactions type not covered as a dedicated type.
        /// </summary>
        [IsoId("_MU7YqTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public required SettlementFailsDailyCSD1Choice_ Other { get; init; }
    }
}
