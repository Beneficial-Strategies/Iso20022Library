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
[IsoId("_4xNiEbOYEemDE9K-I5TT8Q")]
[DisplayName("Loan Data")]
public record LoanData95
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_43g-a7OYEemDE9K-I5TT8Q")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_43g-bbOYEemDE9K-I5TT8Q")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_43g-dbOYEemDE9K-I5TT8Q")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_43g-b7OYEemDE9K-I5TT8Q")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public required Cleared10Choice_ ClearingStatus { get; init; }

    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    [IsoId("_43g-cbOYEemDE9K-I5TT8Q")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier TradingVenue { get; init; }

    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_43g-c7OYEemDE9K-I5TT8Q")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement6? MasterAgreement { get; init; }

    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_43g-d7OYEemDE9K-I5TT8Q")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    [IsoId("_43g-e7OYEemDE9K-I5TT8Q")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; }

    /// <summary>
    /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_43g-YbOYEemDE9K-I5TT8Q")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; }

    /// <summary>
    /// Delivery method of the collateral.
    /// </summary>
    [IsoId("_43g-Y7OYEemDE9K-I5TT8Q")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term.
    /// </summary>
    [IsoId("_43g-ZbOYEemDE9K-I5TT8Q")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ContractTerm3Choice_? Term { get; init; }

    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_43g-Z7OYEemDE9K-I5TT8Q")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate20Choice_? InterestRate { get; init; }

    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    [IsoId("_43g-abOYEemDE9K-I5TT8Q")]
    [DisplayName("Principal Amount")]
    [IsoXmlTag("PrncplAmt")]
    public PrincipalAmount2? PrincipalAmount { get; init; }

    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    [IsoId("_43g-ebOYEemDE9K-I5TT8Q")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }

    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    [IsoId("_43g-fbOYEemDE9K-I5TT8Q")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; }
}
