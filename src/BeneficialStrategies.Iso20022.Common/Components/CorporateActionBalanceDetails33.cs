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
[IsoId("_cfrdhZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Balance Details")]
public record CorporateActionBalanceDetails33
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_cfsD0ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public required Quantity22Choice_ TotalEligibleBalance { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_cfsD2ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public required BalanceFormat7Choice_ UninstructedBalance { get; init; }

    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_cfsD4ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Total Instructed Balance Details")]
    [IsoXmlTag("TtlInstdBalDtls")]
    public required InstructedBalanceDetails6 TotalInstructedBalanceDetails { get; init; }

    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_cfsD45KQEeWHWpTQn1FFVg")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public SignedQuantityFormat9? BlockedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_cfsD65KQEeWHWpTQn1FFVg")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public SignedQuantityFormat9? BorrowedBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_cfsD85KQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public SignedQuantityFormat9? CollateralInBalance { get; init; }

    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_cfsD-5KQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public SignedQuantityFormat9? CollateralOutBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_cfsEA5KQEeWHWpTQn1FFVg")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public SignedQuantityFormat9? OnLoanBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_cfsEC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public SignedQuantityFormat9? OutForRegistrationBalance { get; init; }

    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_cfsEE5KQEeWHWpTQn1FFVg")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public SignedQuantityFormat9? SettlementPositionBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_cfsEG5KQEeWHWpTQn1FFVg")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public SignedQuantityFormat9? StreetPositionBalance { get; init; }

    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_cfsEI5KQEeWHWpTQn1FFVg")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public SignedQuantityFormat9? TradeDatePositionBalance { get; init; }

    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_cfsEK5KQEeWHWpTQn1FFVg")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public SignedQuantityFormat9? InTransshipmentBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_cfsEM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public SignedQuantityFormat9? RegisteredBalance { get; init; }

    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_cfsEO5KQEeWHWpTQn1FFVg")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public SignedQuantityFormat9? ObligatedBalance { get; init; }

    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_cfsEQ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public ValueList<PendingBalance4> PendingDeliveryBalance { get; init; } = [];

    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_cfsES5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public ValueList<PendingBalance4> PendingReceiptBalance { get; init; } = [];
}
