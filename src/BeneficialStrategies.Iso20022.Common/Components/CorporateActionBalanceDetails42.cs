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
[IsoId("_Rko2BxuyEeyhRdHRjakS2w")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails42
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_R6ZDkRuyEeyhRdHRjakS2w")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public Quantity49Choice_? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_R6ZDmRuyEeyhRdHRjakS2w")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public BalanceFormat11Choice_? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_R6ZDoRuyEeyhRdHRjakS2w")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public BalanceFormat11Choice_? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_R6ZDqRuyEeyhRdHRjakS2w")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public BalanceFormat11Choice_? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_R6ZDsRuyEeyhRdHRjakS2w")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public BalanceFormat11Choice_? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_R6ZDuRuyEeyhRdHRjakS2w")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public BalanceFormat11Choice_? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_R6ZDwRuyEeyhRdHRjakS2w")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<BalanceFormat11Choice_> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_R6ZDyRuyEeyhRdHRjakS2w")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<BalanceFormat11Choice_> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_R6ZD0RuyEeyhRdHRjakS2w")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public BalanceFormat11Choice_? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_R6ZD2RuyEeyhRdHRjakS2w")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public BalanceFormat11Choice_? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_R6ZD4RuyEeyhRdHRjakS2w")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public BalanceFormat11Choice_? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_R6ZD6RuyEeyhRdHRjakS2w")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public BalanceFormat11Choice_? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_R6ZD8RuyEeyhRdHRjakS2w")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public BalanceFormat11Choice_? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_R6ZD-RuyEeyhRdHRjakS2w")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public BalanceFormat11Choice_? RegisteredBalance { get; init; }
}
