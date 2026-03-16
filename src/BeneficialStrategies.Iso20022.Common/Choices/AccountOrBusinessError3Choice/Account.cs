// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOrBusinessError3Choice
{
    /// <summary>
    /// Requested information on the account.
    /// </summary>
    [IsoId("_fowVcZ-WEee28J7y9KlTWg")]
    [DisplayName("Account")]
    public record Account : AccountOrBusinessError3Choice_
    {
        /// <summary>
        /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
        /// </summary>
        [IsoId("_fzXqBZ-WEee28J7y9KlTWg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public IsoMax70Text? Name { get; init; }

        /// <summary>
        /// Specifies the nature, or use, of the cash account.
        /// </summary>
        [IsoId("_fzXqB5-WEee28J7y9KlTWg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public CashAccountType2Choice_? Type { get; init; }

        /// <summary>
        /// Specifies the currency of the cash account.
        /// </summary>
        [IsoId("_fzYREZ-WEee28J7y9KlTWg")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveOrHistoricCurrencyCode? Currency { get; init; }

        /// <summary>
        /// Maximum amount value applied to or by a participant versus a set of counterparts. The multilateral system is taken into account by the transaction administrator to contain the risk in the system.|With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for whom no bilateral limit was set.
        /// </summary>
        [IsoId("_fzYRE5-WEee28J7y9KlTWg")]
        [DisplayName("Current Multilateral Limit")]
        [IsoXmlTag("CurMulLmt")]
        public Limit5? CurrentMultilateralLimit { get; init; }

        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_fzYRFZ-WEee28J7y9KlTWg")]
        [DisplayName("Owner")]
        [IsoXmlTag("Ownr")]
        public PartyIdentification125? Owner { get; init; }

        /// <summary>
        /// Servicer of the account which is being queried.
        /// </summary>
        [IsoId("_fzYRF5-WEee28J7y9KlTWg")]
        [DisplayName("Servicer")]
        [IsoXmlTag("Svcr")]
        public BranchAndFinancialInstitutionIdentification5? Servicer { get; init; }

        /// <summary>
        /// Balance is calculated with regard to many members in the system.
        /// </summary>
        [IsoId("_fzYRGZ-WEee28J7y9KlTWg")]
        [DisplayName("Multilateral Balance")]
        [IsoXmlTag("MulBal")]
        public CashBalance10? MultilateralBalance { get; init; }

        /// <summary>
        /// Limit fixed by a party A with regard to a specific counterparty B and corresponding to the maximum amount of traffic that party A may send to party B. The bilateral limit can be expressed as a debit limit or a credit limit. |With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
        /// </summary>
        [IsoId("_fzYRG5-WEee28J7y9KlTWg")]
        [DisplayName("Current Bilateral Limit")]
        [IsoXmlTag("CurBilLmt")]
        public BilateralLimit2? CurrentBilateralLimit { get; init; }

        /// <summary>
        /// Instruction given by a party that has explicit authority to instruct a debit on the account, that is either the debtor or originating party, to the debtor agent, to process liquidity transfers at specified intervals during an implicit or explicit period of time. A standing order is given once and is valid for an open or closed period of time.
        /// </summary>
        [IsoId("_fzYRHZ-WEee28J7y9KlTWg")]
        [DisplayName("Standing Order")]
        [IsoXmlTag("StgOrdr")]
        public StandingOrder2? StandingOrder { get; init; }
    }
}
