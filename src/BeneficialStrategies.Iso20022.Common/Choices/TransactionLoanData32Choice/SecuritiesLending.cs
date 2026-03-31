// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData32Choice
{
    /// <summary>
    /// Details of the securities lending transaction.
    /// </summary>
    [IsoId("_KA3wlcz4EeufhKfUxzsnrQ")]
    [DisplayName("Securities Lending")]
    [IsoXmlTag("SctiesLndg")]
    public record SecuritiesLending : TransactionLoanData32Choice_
    {
        /// <summary>
        /// Specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
        /// </summary>
        [IsoId("_QWDxAcz4EeufhKfUxzsnrQ")]
        [DisplayName("Delivery By Value")]
        [IsoXmlTag("DlvryByVal")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator DeliveryByValue { get; init; }

        /// <summary>
        /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
        /// </summary>
        [IsoId("_QWDxA8z4EeufhKfUxzsnrQ")]
        [DisplayName("Collateral Delivery Method")]
        [IsoXmlTag("CollDlvryMtd")]
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

        /// <summary>
        /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
        /// </summary>
        [IsoId("_QWDxBcz4EeufhKfUxzsnrQ")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public ContractTerm7Choice_? Term { get; init; }

        /// <summary>
        /// Indication of the type of assets subject of the transaction.
        /// </summary>
        [IsoId("_QWDxB8z4EeufhKfUxzsnrQ")]
        [DisplayName("Asset Type")]
        [IsoXmlTag("AsstTp")]
        public required SecurityCommodity9 AssetType { get; init; }

        /// <summary>
        /// Interest rate (rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee) paid by the lender of the security or commodity to the borrower (positive rebate rate) or by the borrower to the lender (negative rebate rate) on the balance of the provided cash collateral.
        /// </summary>
        [IsoId("_QWDxCcz4EeufhKfUxzsnrQ")]
        [DisplayName("Rebate Rate")]
        [IsoXmlTag("RbtRate")]
        public InterestRate27Choice_? RebateRate { get; init; }

        /// <summary>
        /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
        /// </summary>
        [IsoId("_QWDxC8z4EeufhKfUxzsnrQ")]
        [DisplayName("Loan Value")]
        [IsoXmlTag("LnVal")]
        public required ActiveOrHistoricCurrencyAndAmount LoanValue { get; init; }

        /// <summary>
        /// Fee that the borrower of the security or commodity pays to the lender.
        /// </summary>
        [IsoId("_QWDxDcz4EeufhKfUxzsnrQ")]
        [DisplayName("Lending Fee")]
        [IsoXmlTag("LndgFee")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? LendingFee { get; init; }

        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_QWDxD8z4EeufhKfUxzsnrQ")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text UniqueTradeIdentifier { get; init; }

        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
        /// </summary>
        [IsoId("_QWDxEcz4EeufhKfUxzsnrQ")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; }

        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_QWDxE8z4EeufhKfUxzsnrQ")]
        [DisplayName("Clearing Status")]
        [IsoXmlTag("ClrSts")]
        public required Cleared16Choice_ ClearingStatus { get; init; }

        /// <summary>
        /// Venue of execution shall be identified by a unique code for this venue.
        /// </summary>
        [IsoId("_QWDxFcz4EeufhKfUxzsnrQ")]
        [DisplayName("Trading Venue")]
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier TradingVenue { get; init; }

        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_QWDxF8z4EeufhKfUxzsnrQ")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement7? MasterAgreement { get; init; }

        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_QWDxGcz4EeufhKfUxzsnrQ")]
        [DisplayName("Execution Date Time")]
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ExecutionDateTime { get; init; }

        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_QWDxG8z4EeufhKfUxzsnrQ")]
        [DisplayName("Value Date")]
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ValueDate { get; init; }

        /// <summary>
        /// Termination date in the case of a full early termination of the reported transaction.
        /// </summary>
        [IsoId("_QWDxHcz4EeufhKfUxzsnrQ")]
        [DisplayName("Termination Date")]
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? TerminationDate { get; init; }

        /// <summary>
        /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
        /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
        /// </summary>
        [IsoId("_QWDxH8z4EeufhKfUxzsnrQ")]
        [DisplayName("General Collateral")]
        [IsoXmlTag("GnlColl")]
        public SpecialCollateral1Code? GeneralCollateral { get; init; }
    }
}
