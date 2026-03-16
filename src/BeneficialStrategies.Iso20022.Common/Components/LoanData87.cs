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
[IsoId("_16F6aa1KEemojPqsRBB5Lg")]
[DisplayName("Loan Data")]
public record LoanData87
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_2C1msa1KEemojPqsRBB5Lg")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_2C1ms61KEemojPqsRBB5Lg")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_2C2Nwa1KEemojPqsRBB5Lg")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_2C2Nw61KEemojPqsRBB5Lg")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public Cleared10Choice_? ClearingStatus { get; init; }

    /// <summary>
    /// Identification of the venue where the transaction was executed.
    /// </summary>
    [IsoId("_2C2Nxa1KEemojPqsRBB5Lg")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_2C2Nx61KEemojPqsRBB5Lg")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement6? MasterAgreement { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_2C2Nya1KEemojPqsRBB5Lg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general collateral arrangement.
    /// </summary>
    [IsoId("_2C2Ny61KEemojPqsRBB5Lg")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// This field specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_2C2Nza1KEemojPqsRBB5Lg")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; }

    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_2C2Nz61KEemojPqsRBB5Lg")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("_2C2N0a1KEemojPqsRBB5Lg")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ContractTerm3Choice_? Term { get; init; }

    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    [IsoId("_2C2N061KEemojPqsRBB5Lg")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public SecurityCommodity8? AssetType { get; init; }

    /// <summary>
    /// Specifies loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_2C2N1a1KEemojPqsRBB5Lg")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; }

    /// <summary>
    /// Rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee.
    /// </summary>
    [IsoId("_2C2N161KEemojPqsRBB5Lg")]
    [DisplayName("Rebate Rate")]
    [IsoXmlTag("RbtRate")]
    public InterestRate20Choice_? RebateRate { get; init; }

    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_2C2N2a1KEemojPqsRBB5Lg")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LendingFee { get; init; }

    /// <summary>
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    [IsoId("_2C2N3a1KEemojPqsRBB5Lg")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }
}
