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
[IsoId("_chWQ75KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails34
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_chWQ8ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public Quantity22Choice_? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_chWQ-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public BalanceFormat7Choice_? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_chWRAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public BalanceFormat7Choice_? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_chWRCZKQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public BalanceFormat7Choice_? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_chWREZKQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public BalanceFormat7Choice_? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_chWRGZKQEeWHWpTQn1FFVg")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public BalanceFormat7Choice_? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_chWRIZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<BalanceFormat7Choice_> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_chWRKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<BalanceFormat7Choice_> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_chWRMZKQEeWHWpTQn1FFVg")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public BalanceFormat7Choice_? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_chWROZKQEeWHWpTQn1FFVg")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public BalanceFormat7Choice_? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_chWRQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public BalanceFormat7Choice_? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_chWRSZKQEeWHWpTQn1FFVg")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public BalanceFormat7Choice_? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_chWRUZKQEeWHWpTQn1FFVg")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public BalanceFormat7Choice_? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_chWRWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public BalanceFormat7Choice_? RegisteredBalance { get; init; }
}
