// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError6Choice
{
    /// <summary>
    /// Requested information on the account.
    /// </summary>
    [IsoId("_CtV4cW4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order")]
    [IsoXmlTag("StgOrdr")]
    public record StandingOrder : StandingOrderOrError6Choice_
    {
        /// <summary>
        /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
        /// </summary>
        [IsoId("_9GXo4249EeiU9cctagi5ow")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required Amount2Choice_ Amount { get; init; }

        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_9GXo5W49EeiU9cctagi5ow")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public required CreditDebitCode CreditDebitIndicator { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_9GXo5249EeiU9cctagi5ow")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveCurrencyCode? Currency { get; init; }

        /// <summary>
        /// Type of the standing order.
        /// </summary>
        [IsoId("_9GXo6W49EeiU9cctagi5ow")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public StandingOrderType1Choice_? Type { get; init; }

        /// <summary>
        /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
        /// </summary>
        [IsoId("_9GXo6249EeiU9cctagi5ow")]
        [DisplayName("Associated Pool Account")]
        [IsoXmlTag("AssoctdPoolAcct")]
        public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_9GXo7W49EeiU9cctagi5ow")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Reference { get; init; }

        /// <summary>
        /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
        /// </summary>
        [IsoId("_9GXo7249EeiU9cctagi5ow")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency2Code? Frequency { get; init; }

        /// <summary>
        /// Dates during which the standing order is in effect.
        /// </summary>
        [IsoId("_9GXo8W49EeiU9cctagi5ow")]
        [DisplayName("Validity Period")]
        [IsoXmlTag("VldtyPrd")]
        public DatePeriodDetails1? ValidityPeriod { get; init; }

        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_9GXo8249EeiU9cctagi5ow")]
        [DisplayName("System Member")]
        [IsoXmlTag("SysMmb")]
        public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_9GXo9W49EeiU9cctagi5ow")]
        [DisplayName("Responsible Party")]
        [IsoXmlTag("RspnsblPty")]
        public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; }

        /// <summary>
        /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
        /// </summary>
        [IsoId("_9GXo9249EeiU9cctagi5ow")]
        [DisplayName("Link Set Identification")]
        [IsoXmlTag("LkSetId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? LinkSetIdentification { get; init; }

        /// <summary>
        /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
        /// </summary>
        [IsoId("_9GXo-W49EeiU9cctagi5ow")]
        [DisplayName("Link Set Order Identification")]
        [IsoXmlTag("LkSetOrdrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? LinkSetOrderIdentification { get; init; }

        /// <summary>
        /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
        /// </summary>
        [IsoId("_9GXo-249EeiU9cctagi5ow")]
        [DisplayName("Link Set Order Sequence")]
        [IsoXmlTag("LkSetOrdrSeq")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? LinkSetOrderSequence { get; init; }

        /// <summary>
        /// Defines whether the standing order is executed through a time-based or an event-based trigger.
        /// </summary>
        [IsoId("_9GXo_W49EeiU9cctagi5ow")]
        [DisplayName("Execution Type")]
        [IsoXmlTag("ExctnTp")]
        public ExecutionType1Choice_? ExecutionType { get; init; }

        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_nr_wYnXwEei3jO6riKEVXg")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; }

        /// <summary>
        /// Cash account credited from a standing order mechanism.
        /// </summary>
        [IsoId("_9GXo_249EeiU9cctagi5ow")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount38? CreditorAccount { get; init; }

        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_nr_wY3XwEei3jO6riKEVXg")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; }

        /// <summary>
        /// Cash account debited from a standing order mechanism.
        /// </summary>
        [IsoId("_9GXpAW49EeiU9cctagi5ow")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount38? DebtorAccount { get; init; }

        /// <summary>
        /// Overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
        /// </summary>
        [IsoId("_9GXpA249EeiU9cctagi5ow")]
        [DisplayName("Totals Per Standing Order")]
        [IsoXmlTag("TtlsPerStgOrdr")]
        public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; }

        /// <summary>
        /// Indicates whether the liquidity transfer standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
        /// </summary>
        [IsoId("_9GXpBW49EeiU9cctagi5ow")]
        [DisplayName("Zero Sweep Indicator")]
        [IsoXmlTag("ZeroSweepInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
    }
}
