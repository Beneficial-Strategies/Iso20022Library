// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Balance50.
/// </summary>
[IsoId("_kUdGdYVQEe-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Balance50")]
public partial record CorporateActionBalance50
{
    #nullable enable

    /// <summary>
    /// Blocked Balance.
    /// </summary>
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public SignedQuantityFormat10? BlockedBalance { get; init; } 

    /// <summary>
    /// Borrowed Balance.
    /// </summary>
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public SignedQuantityFormat10? BorrowedBalance { get; init; } 

    /// <summary>
    /// Collateral In Balance.
    /// </summary>
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public SignedQuantityFormat10? CollateralInBalance { get; init; } 

    /// <summary>
    /// Collateral Out Balance.
    /// </summary>
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public SignedQuantityFormat10? CollateralOutBalance { get; init; } 

    /// <summary>
    /// In Transshipment Balance.
    /// </summary>
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public SignedQuantityFormat10? InTransshipmentBalance { get; init; } 

    /// <summary>
    /// Obligated Balance.
    /// </summary>
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat10? ObligatedBalance { get; init; } 

    /// <summary>
    /// On Loan Balance.
    /// </summary>
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public SignedQuantityFormat10? OnLoanBalance { get; init; } 

    /// <summary>
    /// Out For Registration Balance.
    /// </summary>
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public SignedQuantityFormat10? OutForRegistrationBalance { get; init; } 

    /// <summary>
    /// Pending Delivery Balance.
    /// </summary>
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<PendingBalance7> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Pending Receipt Balance.
    /// </summary>
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<PendingBalance7> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Registered Balance.
    /// </summary>
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public SignedQuantityFormat10? RegisteredBalance { get; init; } 

    /// <summary>
    /// Settlement Position Balance.
    /// </summary>
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public SignedQuantityFormat10? SettlementPositionBalance { get; init; } 

    /// <summary>
    /// Street Position Balance.
    /// </summary>
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public SignedQuantityFormat10? StreetPositionBalance { get; init; } 

    /// <summary>
    /// Total Eligible Balance.
    /// </summary>
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public required Quantity49Choice_ TotalEligibleBalance { get; init; } 

    /// <summary>
    /// Total Instructed Balance Details.
    /// </summary>
    [DisplayName("Total Instructed Balance Details")]
    [IsoXmlTag("TtlInstdBalDtls")]
    public required InstructedBalance20 TotalInstructedBalanceDetails { get; init; } 

    /// <summary>
    /// Trade Date Position Balance.
    /// </summary>
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public SignedQuantityFormat10? TradeDatePositionBalance { get; init; } 

    /// <summary>
    /// Uninstructed Balance.
    /// </summary>
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public required BalanceFormat11Choice_ UninstructedBalance { get; init; } 

    
    #nullable disable
    
}
