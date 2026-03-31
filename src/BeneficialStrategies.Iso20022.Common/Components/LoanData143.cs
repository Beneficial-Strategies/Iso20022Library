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
[IsoId("_KA3wl8z4EeufhKfUxzsnrQ")]
[DisplayName("Loan Data")]
public record LoanData143
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_KCPpkcz4EeufhKfUxzsnrQ")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_KCPpk8z4EeufhKfUxzsnrQ")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_KCPplcz4EeufhKfUxzsnrQ")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_KCPpl8z4EeufhKfUxzsnrQ")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public required Cleared16Choice_ ClearingStatus { get; init; }

    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    [IsoId("_KCPpmcz4EeufhKfUxzsnrQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier TradingVenue { get; init; }

    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_KCPpm8z4EeufhKfUxzsnrQ")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement7? MasterAgreement { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_KCPpncz4EeufhKfUxzsnrQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    [IsoId("_KCPpn8z4EeufhKfUxzsnrQ")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_KCPpocz4EeufhKfUxzsnrQ")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; }

    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    [IsoId("_KCPpo8z4EeufhKfUxzsnrQ")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
    /// </summary>
    [IsoId("_KCPppcz4EeufhKfUxzsnrQ")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ValueList<ContractTerm7Choice_> Term { get; init; } = [];

    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_KCPpp8z4EeufhKfUxzsnrQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate27Choice_? InterestRate { get; init; }

    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_KCPpqcz4EeufhKfUxzsnrQ")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public PrincipalAmount3? PrincipalAmount { get; init; }

    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    [IsoId("_KCPpq8z4EeufhKfUxzsnrQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }

    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    [IsoId("_KCPprcz4EeufhKfUxzsnrQ")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; }
}
