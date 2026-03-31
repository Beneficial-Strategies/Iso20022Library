// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData31Choice
{
    /// <summary>
    /// Details of the repurchase trade transaction.
    /// </summary>
    [IsoId("_lod1IczsEeux2uvSBFU54Q")]
    [DisplayName("Repurchase Trade")]
    [IsoXmlTag("RpTrad")]
    public record RepurchaseTrade : TransactionLoanData31Choice_
    {
        /// <summary>
        /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_lp9C48zsEeux2uvSBFU54Q")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? UniqueTradeIdentifier { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_lp9C5czsEeux2uvSBFU54Q")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? EventDate { get; init; }

        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_lp9C58zsEeux2uvSBFU54Q")]
        [DisplayName("Execution Date Time")]
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ExecutionDateTime { get; init; }

        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_lp9C6czsEeux2uvSBFU54Q")]
        [DisplayName("Clearing Status")]
        [IsoXmlTag("ClrSts")]
        public Cleared16Choice_? ClearingStatus { get; init; }

        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_lp9C68zsEeux2uvSBFU54Q")]
        [DisplayName("Trading Venue")]
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? TradingVenue { get; init; }

        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_lp9C7czsEeux2uvSBFU54Q")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement7? MasterAgreement { get; init; }

        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_lp9C78zsEeux2uvSBFU54Q")]
        [DisplayName("Value Date")]
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValueDate { get; init; }

        /// <summary>
        /// Minimum number of business days that one of the counterparties has to inform about the termination of the transaction.
        /// </summary>
        [IsoId("_lp9C8czsEeux2uvSBFU54Q")]
        [DisplayName("Minimum Notice Period")]
        [IsoXmlTag("MinNtcePrd")]
        [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
        public IsoMax20PositiveNumber? MinimumNoticePeriod { get; init; }

        /// <summary>
        /// Earliest date that the cash lender has the right to call back a portion of the amount of money or to terminate the transaction.
        /// </summary>
        [IsoId("_lp9C88zsEeux2uvSBFU54Q")]
        [DisplayName("Earliest Call Back Date")]
        [IsoXmlTag("EarlstCallBckDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? EarliestCallBackDate { get; init; }

        /// <summary>
        /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
        /// </summary>
        [IsoId("_lp9C9czsEeux2uvSBFU54Q")]
        [DisplayName("General Collateral")]
        [IsoXmlTag("GnlColl")]
        public SpecialCollateral1Code? GeneralCollateral { get; init; }

        /// <summary>
        /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
        /// </summary>
        [IsoId("_lp9C98zsEeux2uvSBFU54Q")]
        [DisplayName("Delivery By Value")]
        [IsoXmlTag("DlvryByVal")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? DeliveryByValue { get; init; }

        /// <summary>
        /// Delivery method of the collateral.
        /// </summary>
        [IsoId("_lp9C-czsEeux2uvSBFU54Q")]
        [DisplayName("Collateral Delivery Method")]
        [IsoXmlTag("CollDlvryMtd")]
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

        /// <summary>
        /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
        /// </summary>
        [IsoId("_lp9C-8zsEeux2uvSBFU54Q")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public ContractTerm7Choice_? Term { get; init; }

        /// <summary>
        /// Interest rate of the loan.
        /// </summary>
        [IsoId("_lp9C_czsEeux2uvSBFU54Q")]
        [DisplayName("Interest Rate")]
        [IsoXmlTag("IntrstRate")]
        public InterestRate27Choice_? InterestRate { get; init; }

        /// <summary>
        /// Amount of money to be settled as of the start date and maturity date of the transaction.
        /// </summary>
        [IsoId("_lp9C_8zsEeux2uvSBFU54Q")]
        [DisplayName("Principal Amount")]
        [IsoXmlTag("PrncplAmt")]
        public PrincipalAmount3? PrincipalAmount { get; init; }

        /// <summary>
        /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
        /// </summary>
        [IsoId("_lp9DAczsEeux2uvSBFU54Q")]
        [DisplayName("Termination Date")]
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? TerminationDate { get; init; }
    }
}
