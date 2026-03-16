// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError8Choice
{
    /// <summary>
    /// Requested information on the account.
    /// </summary>
    [IsoId("_edTg0dcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order")]
    public record StandingOrder : StandingOrderOrError8Choice_
    {
        /// <summary>
        /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
        /// </summary>
        [IsoId("_ef46wdcZEeqRFcf2R4bPBw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required Amount2Choice_ Amount { get; init; }

        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_ef46w9cZEeqRFcf2R4bPBw")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public required CreditDebitCode CreditDebitIndicator { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_ef46xdcZEeqRFcf2R4bPBw")]
        [DisplayName("Currency")]
        [IsoXmlTag("Ccy")]
        public ActiveCurrencyCode? Currency { get; init; }

        /// <summary>
        /// Type of the standing order.
        /// </summary>
        [IsoId("_ef46x9cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public StandingOrderType1Choice_? Type { get; init; }

        /// <summary>
        /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
        /// </summary>
        [IsoId("_ef46ydcZEeqRFcf2R4bPBw")]
        [DisplayName("Associated Pool Account")]
        [IsoXmlTag("AssoctdPoolAcct")]
        public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_ef46y9cZEeqRFcf2R4bPBw")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Reference { get; init; }

        /// <summary>
        /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
        /// </summary>
        [IsoId("_ef46zdcZEeqRFcf2R4bPBw")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency2Code? Frequency { get; init; }

        /// <summary>
        /// Dates during which the standing order is in effect.
        /// </summary>
        [IsoId("_ef46z9cZEeqRFcf2R4bPBw")]
        [DisplayName("Validity Period")]
        [IsoXmlTag("VldtyPrd")]
        public DatePeriod3? ValidityPeriod { get; init; }

        /// <summary>
        /// Specifies if the account is debited or credited by the standing order.
        /// </summary>
        [IsoId("_ef460dcZEeqRFcf2R4bPBw")]
        [DisplayName("System Member")]
        [IsoXmlTag("SysMmb")]
        public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_ef4609cZEeqRFcf2R4bPBw")]
        [DisplayName("Responsible Party")]
        [IsoXmlTag("RspnsblPty")]
        public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; }

        /// <summary>
        /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
        /// </summary>
        [IsoId("_ef461dcZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Identification")]
        [IsoXmlTag("LkSetId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? LinkSetIdentification { get; init; }

        /// <summary>
        /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
        /// </summary>
        [IsoId("_ef4619cZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Order Identification")]
        [IsoXmlTag("LkSetOrdrId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? LinkSetOrderIdentification { get; init; }

        /// <summary>
        /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
        /// </summary>
        [IsoId("_ef462dcZEeqRFcf2R4bPBw")]
        [DisplayName("Link Set Order Sequence")]
        [IsoXmlTag("LkSetOrdrSeq")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? LinkSetOrderSequence { get; init; }

        /// <summary>
        /// Defines whether the standing order is executed through a time-based or an event-based trigger.
        /// </summary>
        [IsoId("_ef4629cZEeqRFcf2R4bPBw")]
        [DisplayName("Execution Type")]
        [IsoXmlTag("ExctnTp")]
        public ExecutionType1Choice_? ExecutionType { get; init; }

        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_ef463dcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; }

        /// <summary>
        /// Cash account credited from a standing order mechanism.
        /// </summary>
        [IsoId("_ef4639cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount40? CreditorAccount { get; init; }

        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_ef464dcZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; }

        /// <summary>
        /// Cash account debited from a standing order mechanism.
        /// </summary>
        [IsoId("_ef4649cZEeqRFcf2R4bPBw")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount40? DebtorAccount { get; init; }

        /// <summary>
        /// Overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
        /// </summary>
        [IsoId("_ef465dcZEeqRFcf2R4bPBw")]
        [DisplayName("Totals Per Standing Order")]
        [IsoXmlTag("TtlsPerStgOrdr")]
        public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; }

        /// <summary>
        /// Indicates whether the liquidity transfer standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
        /// </summary>
        [IsoId("_ef4659cZEeqRFcf2R4bPBw")]
        [DisplayName("Zero Sweep Indicator")]
        [IsoXmlTag("ZeroSweepInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
    }
}
