// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
[IsoId("_4Eg3F__qEemm3skPVSMJQg")]
[DisplayName("Loan Data")]
public partial record LoanData98
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    [IsoId("_4Iibcf_qEemm3skPVSMJQg")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    [IsoId("_4Iibc__qEemm3skPVSMJQg")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    
    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("_4Iibdf_qEemm3skPVSMJQg")]
    [DisplayName("Term")]
    [IsoXmlTag("Term")]
    public ContractTerm3Choice_? Term { get; init; } 
    
    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    [IsoId("_4Iibd__qEemm3skPVSMJQg")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public required SecurityCommodity8 AssetType { get; init; } 
    
    /// <summary>
    /// Interest rate (rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee) paid by the lender of the security or commodity to the borrower (positive rebate rate) or by the borrower to the lender (negative rebate rate) on the balance of the provided cash collateral.
    /// </summary>
    [IsoId("_4Iibef_qEemm3skPVSMJQg")]
    [DisplayName("Rebate Rate")]
    [IsoXmlTag("RbtRate")]
    public required InterestRate20Choice_ RebateRate { get; init; } 
    
    /// <summary>
    /// Specifies loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    [IsoId("_4Iibe__qEemm3skPVSMJQg")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public required ActiveOrHistoricCurrencyAndAmount LoanValue { get; init; } 
    
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_4Iibff_qEemm3skPVSMJQg")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LendingFee { get; init; } 
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_4Iibf__qEemm3skPVSMJQg")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_4Iibgf_qEemm3skPVSMJQg")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; } 
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_4Iibg__qEemm3skPVSMJQg")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public required Cleared10Choice_ ClearingStatus { get; init; } 
    
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    [IsoId("_4Iibhf_qEemm3skPVSMJQg")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier TradingVenue { get; init; } 
    
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    [IsoId("_4Iibh__qEemm3skPVSMJQg")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement6? MasterAgreement { get; init; } 
    
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_4Iibif_qEemm3skPVSMJQg")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_4Iibi__qEemm3skPVSMJQg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    [IsoId("_4Iibjf_qEemm3skPVSMJQg")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; } 
    
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    [IsoId("_4Iibj__qEemm3skPVSMJQg")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    
    
    #nullable disable
    
}
