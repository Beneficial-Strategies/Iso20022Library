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
[IsoId("_19_w8fogEeC7qvRLUh5UBA")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails9
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_1-Jh8fogEeC7qvRLUh5UBA")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public required Quantity3Choice_ TotalEligibleBalance { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_1-Jh-_ogEeC7qvRLUh5UBA")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public required BalanceFormat1Choice_ UninstructedBalance { get; init; }

    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_1-JiBfogEeC7qvRLUh5UBA")]
    [DisplayName("Total Instructed Balance Details")]
    [IsoXmlTag("TtlInstdBalDtls")]
    public required InstructedBalanceDetails3 TotalInstructedBalanceDetails { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_1-JiCfogEeC7qvRLUh5UBA")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public SignedQuantityFormat2? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_1-JiE_ogEeC7qvRLUh5UBA")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public SignedQuantityFormat2? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_1-JiHfogEeC7qvRLUh5UBA")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public SignedQuantityFormat2? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_1-JiJ_ogEeC7qvRLUh5UBA")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public SignedQuantityFormat2? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_1-JiMfogEeC7qvRLUh5UBA")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public SignedQuantityFormat2? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_1-JiO_ogEeC7qvRLUh5UBA")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public SignedQuantityFormat2? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_1-JiRfogEeC7qvRLUh5UBA")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public SignedQuantityFormat2? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_1-JiT_ogEeC7qvRLUh5UBA")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public SignedQuantityFormat2? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_1-JiWfogEeC7qvRLUh5UBA")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public SignedQuantityFormat2? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_1-JiY_ogEeC7qvRLUh5UBA")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public SignedQuantityFormat2? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_1-JibfogEeC7qvRLUh5UBA")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public SignedQuantityFormat2? RegisteredBalance { get; init; }

    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_1-Jid_ogEeC7qvRLUh5UBA")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat2? ObligatedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_1-JigfogEeC7qvRLUh5UBA")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<PendingBalance1> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_1-Jii_ogEeC7qvRLUh5UBA")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<PendingBalance1> PendingReceiptBalance { get; init; } = [];
}
