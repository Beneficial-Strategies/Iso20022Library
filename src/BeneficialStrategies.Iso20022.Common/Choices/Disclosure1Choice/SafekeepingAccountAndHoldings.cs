// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure1Choice
{
    /// <summary>
    /// Details of the account, account sub-levels and holdings.
    /// </summary>
    [IsoId("_WtmescANEembi_x1QDJfxw")]
    [DisplayName("Safekeeping Account And Holdings")]
    public record SafekeepingAccountAndHoldings : Disclosure1Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained. Account held by the responding intermediary with its account servicer.
        /// </summary>
        [IsoId("_913X9DqoEemL_ewJY9QP1g")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_F9KWnjqmEemL_ewJY9QP1g")]
        [DisplayName("Account Servicer")]
        [IsoXmlTag("AcctSvcr")]
        public required PartyIdentification195Choice_ AccountServicer { get; init; }

        /// <summary>
        /// Number of shares held by the responding intermediary on its own account.
        /// </summary>
        [IsoId("_tuVJIDqnEemL_ewJY9QP1g")]
        [DisplayName("Shareholding Balance On Own Account")]
        [IsoXmlTag("ShrhldgBalOnOwnAcct")]
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnOwnAccount { get; init; }

        /// <summary>
        /// Number of shares held by the responding intermediary on account of someone else.
        /// </summary>
        [IsoId("_61RxQDqnEemL_ewJY9QP1g")]
        [DisplayName("Shareholding Balance On Client Account")]
        [IsoXmlTag("ShrhldgBalOnClntAcct")]
        public required FinancialInstrumentQuantity18Choice_ ShareholdingBalanceOnClientAccount { get; init; }

        /// <summary>
        /// Total number of shares held by the responding intermediary.
        /// </summary>
        [IsoId("_B-KfgDqoEemL_ewJY9QP1g")]
        [DisplayName("Total Shareholding Balance")]
        [IsoXmlTag("TtlShrhldgBal")]
        public required FinancialInstrumentQuantity18Choice_ TotalShareholdingBalance { get; init; }

        /// <summary>
        /// Shareholdings information at account sub level.
        /// </summary>
        [IsoId("_ZKpiUDqqEemL_ewJY9QP1g")]
        [DisplayName("Account Sub Level")]
        [IsoXmlTag("AcctSubLvl")]
        public AccountSublevel21? AccountSubLevel { get; init; }
    }
}
