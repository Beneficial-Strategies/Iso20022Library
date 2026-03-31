// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData31Choice
{
    /// <summary>
    /// Details of the buy sell back transaction.
    /// </summary>
    [IsoId("_lod1I8zsEeux2uvSBFU54Q")]
    [DisplayName("Buy Sell Back")]
    [IsoXmlTag("BuySellBck")]
    public record BuySellBack : TransactionLoanData31Choice_
    {
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_pl4F4czsEeux2uvSBFU54Q")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public IsoMax52Text? UniqueTradeIdentifier { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_pl4F48zsEeux2uvSBFU54Q")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; }

        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_pl4F5czsEeux2uvSBFU54Q")]
        [DisplayName("Execution Date Time")]
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ExecutionDateTime { get; init; }

        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_pl4F58zsEeux2uvSBFU54Q")]
        [DisplayName("Clearing Status")]
        [IsoXmlTag("ClrSts")]
        public Cleared16Choice_? ClearingStatus { get; init; }

        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_pl4F6czsEeux2uvSBFU54Q")]
        [DisplayName("Trading Venue")]
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? TradingVenue { get; init; }

        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_pl4F68zsEeux2uvSBFU54Q")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement7? MasterAgreement { get; init; }

        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_pl4F7czsEeux2uvSBFU54Q")]
        [DisplayName("Value Date")]
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValueDate { get; init; }

        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the transaction.
        /// </summary>
        [IsoId("_pl4F78zsEeux2uvSBFU54Q")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? MaturityDate { get; init; }

        /// <summary>
        /// Indication whether the transaction is subject to a general collateral arrangement.
        /// </summary>
        [IsoId("_pl4F8czsEeux2uvSBFU54Q")]
        [DisplayName("General Collateral")]
        [IsoXmlTag("GnlColl")]
        public SpecialCollateral1Code? GeneralCollateral { get; init; }

        /// <summary>
        /// Amount of money to be settled as of the start date and maturity date of the transaction.
        /// </summary>
        [IsoId("_pl4F88zsEeux2uvSBFU54Q")]
        [DisplayName("Principal Amount")]
        [IsoXmlTag("PrncplAmt")]
        public PrincipalAmount3? PrincipalAmount { get; init; }

        /// <summary>
        /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
        /// </summary>
        [IsoId("_pl4F9czsEeux2uvSBFU54Q")]
        [DisplayName("Unit Price")]
        [IsoXmlTag("UnitPric")]
        public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; }

        /// <summary>
        /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
        /// </summary>
        [IsoId("_pl4F98zsEeux2uvSBFU54Q")]
        [DisplayName("Termination Date")]
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? TerminationDate { get; init; }
    }
}
