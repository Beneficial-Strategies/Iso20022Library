// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
[IsoId("_r0hHsczsEeux2uvSBFU54Q")]
[DisplayName("Loan Data")]
public record LoanData141
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_r2T3cczsEeux2uvSBFU54Q")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_r2T3c8zsEeux2uvSBFU54Q")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_r2T3dczsEeux2uvSBFU54Q")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_r2T3d8zsEeux2uvSBFU54Q")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public Cleared16Choice_? ClearingStatus { get; init; }

    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_r2T3eczsEeux2uvSBFU54Q")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_r2T3e8zsEeux2uvSBFU54Q")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_r2T3fczsEeux2uvSBFU54Q")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general collateral arrangement.
    /// </summary>
    [IsoId("_r2T3f8zsEeux2uvSBFU54Q")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// This field specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_r2T3gczsEeux2uvSBFU54Q")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; }

    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_r2T3g8zsEeux2uvSBFU54Q")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("_r2T3hczsEeux2uvSBFU54Q")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ContractTerm7Choice_? Term { get; init; }

    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    [IsoId("_r2T3h8zsEeux2uvSBFU54Q")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public SecurityCommodity9? AssetType { get; init; }

    /// <summary>
    /// Specifies the loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_r2T3iczsEeux2uvSBFU54Q")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; }

    /// <summary>
    /// Rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee.
    /// </summary>
    [IsoId("_r2T3i8zsEeux2uvSBFU54Q")]
    [DisplayName("Rebate Rate")]
    [IsoXmlTag("RbtRate")]
    public InterestRate27Choice_? RebateRate { get; init; }

    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_r2T3jczsEeux2uvSBFU54Q")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LendingFee { get; init; }

    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    [IsoId("_r2T3j8zsEeux2uvSBFU54Q")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }
}
