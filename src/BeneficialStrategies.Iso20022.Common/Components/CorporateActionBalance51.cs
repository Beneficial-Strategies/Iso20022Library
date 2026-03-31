// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Balance51.
/// </summary>
[IsoId("_j2C-f5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Balance51")]
public record CorporateActionBalance51
{
    /// <summary>
    /// Blocked Balance.
    /// </summary>
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public SignedQuantityFormat13? BlockedBalance { get; init; }

    /// <summary>
    /// Borrowed Balance.
    /// </summary>
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public SignedQuantityFormat13? BorrowedBalance { get; init; }

    /// <summary>
    /// Collateral In Balance.
    /// </summary>
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public SignedQuantityFormat13? CollateralInBalance { get; init; }

    /// <summary>
    /// Collateral Out Balance.
    /// </summary>
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public SignedQuantityFormat13? CollateralOutBalance { get; init; }

    /// <summary>
    /// In Transshipment Balance.
    /// </summary>
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public SignedQuantityFormat13? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Obligated Balance.
    /// </summary>
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat13? ObligatedBalance { get; init; }

    /// <summary>
    /// On Loan Balance.
    /// </summary>
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public SignedQuantityFormat13? OnLoanBalance { get; init; }

    /// <summary>
    /// Out For Registration Balance.
    /// </summary>
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public SignedQuantityFormat13? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Pending Delivery Balance.
    /// </summary>
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<PendingBalance8> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Pending Receipt Balance.
    /// </summary>
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<PendingBalance8> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Registered Balance.
    /// </summary>
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public SignedQuantityFormat13? RegisteredBalance { get; init; }

    /// <summary>
    /// Settlement Position Balance.
    /// </summary>
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public SignedQuantityFormat13? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Street Position Balance.
    /// </summary>
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public SignedQuantityFormat13? StreetPositionBalance { get; init; }

    /// <summary>
    /// Total Eligible Balance.
    /// </summary>
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public required Quantity80Choice_ TotalEligibleBalance { get; init; }

    /// <summary>
    /// Total Instructed Balance Details.
    /// </summary>
    [DisplayName("Total Instructed Balance Details")]
    [IsoXmlTag("TtlInstdBalDtls")]
    public required InstructedBalance21 TotalInstructedBalanceDetails { get; init; }

    /// <summary>
    /// Trade Date Position Balance.
    /// </summary>
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public SignedQuantityFormat13? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Uninstructed Balance.
    /// </summary>
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public required BalanceFormat14Choice_ UninstructedBalance { get; init; }
}
