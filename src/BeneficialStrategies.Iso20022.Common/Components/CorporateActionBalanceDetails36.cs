// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
[IsoId("_ctP_Z5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Balance Details")]
public partial record CorporateActionBalanceDetails36
{
    #nullable enable
    
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [IsoId("_ctP_a5KQEeWHWpTQn1FFVg")]
    [DisplayName("Total Eligible Balance")]
    [IsoXmlTag("TtlElgblBal")]
    public TotalEligibleBalanceFormat9? TotalEligibleBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_ctP_c5KQEeWHWpTQn1FFVg")]
    [DisplayName("Blocked Balance")]
    [IsoXmlTag("BlckdBal")]
    public BalanceFormat7Choice_? BlockedBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_ctP_e5KQEeWHWpTQn1FFVg")]
    [DisplayName("Borrowed Balance")]
    [IsoXmlTag("BrrwdBal")]
    public BalanceFormat7Choice_? BorrowedBalance { get; init; } 
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_ctP_g5KQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral In Balance")]
    [IsoXmlTag("CollInBal")]
    public BalanceFormat7Choice_? CollateralInBalance { get; init; } 
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_ctP_i5KQEeWHWpTQn1FFVg")]
    [DisplayName("Collateral Out Balance")]
    [IsoXmlTag("CollOutBal")]
    public BalanceFormat7Choice_? CollateralOutBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_ctP_k5KQEeWHWpTQn1FFVg")]
    [DisplayName("On Loan Balance")]
    [IsoXmlTag("OnLnBal")]
    public BalanceFormat7Choice_? OnLoanBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_ctP_m5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Delivery Balance")]
    [IsoXmlTag("PdgDlvryBal")]
    public BalanceFormat10Choice_? PendingDeliveryBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_ctP_o5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Receipt Balance")]
    [IsoXmlTag("PdgRctBal")]
    public BalanceFormat10Choice_? PendingReceiptBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_ctP_q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Out For Registration Balance")]
    [IsoXmlTag("OutForRegnBal")]
    public BalanceFormat7Choice_? OutForRegistrationBalance { get; init; } 
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_ctP_s5KQEeWHWpTQn1FFVg")]
    [DisplayName("Settlement Position Balance")]
    [IsoXmlTag("SttlmPosBal")]
    public BalanceFormat10Choice_? SettlementPositionBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_ctP_u5KQEeWHWpTQn1FFVg")]
    [DisplayName("Street Position Balance")]
    [IsoXmlTag("StrtPosBal")]
    public BalanceFormat7Choice_? StreetPositionBalance { get; init; } 
    
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_ctQlwZKQEeWHWpTQn1FFVg")]
    [DisplayName("Trade Date Position Balance")]
    [IsoXmlTag("TradDtPosBal")]
    public BalanceFormat7Choice_? TradeDatePositionBalance { get; init; } 
    
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_ctQlyZKQEeWHWpTQn1FFVg")]
    [DisplayName("In Transshipment Balance")]
    [IsoXmlTag("InTrnsShipmntBal")]
    public BalanceFormat7Choice_? InTransshipmentBalance { get; init; } 
    
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_ctQl0ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Registered Balance")]
    [IsoXmlTag("RegdBal")]
    public BalanceFormat7Choice_? RegisteredBalance { get; init; } 
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_ctQl2ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Obligated Balance")]
    [IsoXmlTag("OblgtdBal")]
    public BalanceFormat7Choice_? ObligatedBalance { get; init; } 
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_ctQl4ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat7Choice_? UninstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_ctQl6ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat7Choice_? InstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    [IsoId("_ctQl8ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Affected Balance")]
    [IsoXmlTag("AfctdBal")]
    public BalanceFormat7Choice_? AffectedBalance { get; init; } 
    
    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// </summary>
    [IsoId("_ctQl-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Unaffected Balance")]
    [IsoXmlTag("UafctdBal")]
    public BalanceFormat7Choice_? UnaffectedBalance { get; init; } 
    
    
    #nullable disable
    
}
