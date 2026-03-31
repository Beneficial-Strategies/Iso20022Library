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
[IsoId("_XN-vwxFSEeKp2ZN13DI_pA")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails18
{
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_Xj4uJRFSEeKp2ZN13DI_pA")]
    [DisplayName("Confirmed Balance")]
    [IsoXmlTag("ConfdBal")]
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; }

    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_Xj4uLxFSEeKp2ZN13DI_pA")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public Quantity3Choice_? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_Xj4uORFSEeKp2ZN13DI_pA")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public BalanceFormat1Choice_? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_Xj4uQxFSEeKp2ZN13DI_pA")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public BalanceFormat1Choice_? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_Xj4uTRFSEeKp2ZN13DI_pA")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public BalanceFormat1Choice_? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_Xj4uVxFSEeKp2ZN13DI_pA")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public BalanceFormat1Choice_? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_Xj4uYRFSEeKp2ZN13DI_pA")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public BalanceFormat1Choice_? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_Xj4uaxFSEeKp2ZN13DI_pA")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<BalanceFormat3Choice_> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_Xj4udRFSEeKp2ZN13DI_pA")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<BalanceFormat3Choice_> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_Xj4ufxFSEeKp2ZN13DI_pA")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public BalanceFormat1Choice_? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_Xj4uiRFSEeKp2ZN13DI_pA")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public ValueList<BalanceFormat3Choice_> SettlementPositionBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_Xj4ukxFSEeKp2ZN13DI_pA")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public BalanceFormat1Choice_? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_Xj4unRFSEeKp2ZN13DI_pA")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public BalanceFormat1Choice_? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_Xj4upxFSEeKp2ZN13DI_pA")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public BalanceFormat1Choice_? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_Xj4usRFSEeKp2ZN13DI_pA")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public BalanceFormat1Choice_? RegisteredBalance { get; init; }

    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    [IsoId("_Xj4uuxFSEeKp2ZN13DI_pA")]
    [DisplayName("Affected Balance")]
    [IsoXmlTag("AfctdBal")]
    public BalanceFormat1Choice_? AffectedBalance { get; init; }

    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// </summary>
    [IsoId("_Xj4uxRFSEeKp2ZN13DI_pA")]
    [DisplayName("Unaffected Balance")]
    [IsoXmlTag("UafctdBal")]
    public BalanceFormat1Choice_? UnaffectedBalance { get; init; }
}
