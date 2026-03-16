// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a repurchase trade transaction.
/// </summary>
[IsoId("_gHkCecg4Eeu4ecZgAYuz5w")]
[DisplayName("Loan Data")]
public record LoanData135
{
    /// <summary>
    /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_gI_l0cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_gI_l08g4Eeu4ecZgAYuz5w")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_gI_l1cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_gI_l18g4Eeu4ecZgAYuz5w")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public Cleared16Choice_? ClearingStatus { get; init; }

    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_gI_l2cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_gI_l28g4Eeu4ecZgAYuz5w")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_gI_l3cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Minimum number of business days that one of the counterparties has to inform about the termination of the transaction.
    /// </summary>
    [IsoId("_gI_l38g4Eeu4ecZgAYuz5w")]
    [DisplayName("Minimum Notice Period")]
    [IsoXmlTag("MinNtcePrd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public IsoMax20PositiveNumber? MinimumNoticePeriod { get; init; }

    /// <summary>
    /// Earliest date that the cash lender has the right to call back a portion of the amount of money or to terminate the transaction.
    /// </summary>
    [IsoId("_gI_l4cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarliestCallBackDate { get; init; }

    /// <summary>
    /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
    /// </summary>
    [IsoId("_gI_l48g4Eeu4ecZgAYuz5w")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_gI_l5cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeliveryByValue { get; init; }

    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    [IsoId("_gI_l58g4Eeu4ecZgAYuz5w")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
    /// </summary>
    [IsoId("_gI_l6cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ValueList<ContractTerm7Choice_> Term { get; init; } = [];

    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_gI_l68g4Eeu4ecZgAYuz5w")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate27Choice_? InterestRate { get; init; }

    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_gI_l7cg4Eeu4ecZgAYuz5w")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public PrincipalAmount3? PrincipalAmount { get; init; }

    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    [IsoId("_gI_l78g4Eeu4ecZgAYuz5w")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }
}
