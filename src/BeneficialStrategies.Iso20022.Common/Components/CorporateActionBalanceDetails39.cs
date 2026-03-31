// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
[IsoId("_sORZK7tGEeilsanBGAzy4A")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails39
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_sga5EbtGEeilsanBGAzy4A")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public required Quantity17Choice_ TotalEligibleBalance { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_sga5GbtGEeilsanBGAzy4A")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public required BalanceFormat5Choice_ UninstructedBalance { get; init; }

    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_sga5IbtGEeilsanBGAzy4A")]
    [DisplayName("Total Instructed Balance Details")]
    [IsoXmlTag("TtlInstdBalDtls")]
    public required InstructedBalanceDetails9 TotalInstructedBalanceDetails { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_sga5I7tGEeilsanBGAzy4A")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public SignedQuantityFormat6? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_sga5K7tGEeilsanBGAzy4A")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public SignedQuantityFormat6? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_sga5M7tGEeilsanBGAzy4A")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public SignedQuantityFormat6? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_sga5O7tGEeilsanBGAzy4A")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public SignedQuantityFormat6? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_sga5Q7tGEeilsanBGAzy4A")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public SignedQuantityFormat6? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_sga5S7tGEeilsanBGAzy4A")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public SignedQuantityFormat6? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_sga5U7tGEeilsanBGAzy4A")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public SignedQuantityFormat6? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_sga5W7tGEeilsanBGAzy4A")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public SignedQuantityFormat6? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_sga5Y7tGEeilsanBGAzy4A")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public SignedQuantityFormat6? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_sga5a7tGEeilsanBGAzy4A")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public SignedQuantityFormat6? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_sga5c7tGEeilsanBGAzy4A")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public SignedQuantityFormat6? RegisteredBalance { get; init; }

    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_sga5e7tGEeilsanBGAzy4A")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat6? ObligatedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_sga5g7tGEeilsanBGAzy4A")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<PendingBalance5> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_sga5i7tGEeilsanBGAzy4A")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<PendingBalance5> PendingReceiptBalance { get; init; } = [];
}
