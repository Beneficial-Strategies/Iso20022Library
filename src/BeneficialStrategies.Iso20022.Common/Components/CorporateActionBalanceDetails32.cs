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
[IsoId("_MkECOzq5EeWQ1Y7f8kds2A")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails32
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_Mv9vsTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public Quantity17Choice_? TotalEligibleBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_Mv9vuTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public BalanceFormat5Choice_? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_Mv9vwTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public BalanceFormat5Choice_? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_Mv9vyTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public BalanceFormat5Choice_? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_Mv9v0Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public BalanceFormat5Choice_? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_Mv9v2Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public BalanceFormat5Choice_? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_Mv9v4Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<BalanceFormat5Choice_> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_Mv9v6Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<BalanceFormat5Choice_> PendingReceiptBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_Mv9v8Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public BalanceFormat5Choice_? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_Mv9v-Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public BalanceFormat5Choice_? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_Mv9wATq5EeWQ1Y7f8kds2A")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public BalanceFormat5Choice_? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_Mv9wCTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public BalanceFormat5Choice_? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_Mv9wETq5EeWQ1Y7f8kds2A")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public BalanceFormat5Choice_? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_Mv9wGTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public BalanceFormat5Choice_? RegisteredBalance { get; init; }
}
