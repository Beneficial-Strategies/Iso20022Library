// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit account used by the central counterparty to make payments to and from its clearing members.
/// </summary>
[IsoId("_hzT7oKp5EeamNLogr5TkIQ")]
[DisplayName("Settlement Account")]
public partial record SettlementAccount1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the settlement account.
    /// </summary>
    [IsoId("_s6JGIKp5EeamNLogr5TkIQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification165 Identification { get; init; } 
    
    /// <summary>
    /// Total value of initial margin to be called or returned to clearing member the morning following end of day. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_1J_ccKp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Initial Margin Called")]
    [IsoXmlTag("EndOfDayInitlMrgnClld")]
    public required AmountAndDirection102 EndOfDayInitialMarginCalled { get; init; } 
    
    /// <summary>
    /// Total cash receivable (or payable) in the relevant currency based on changes in the mark-to-market of a clearing member’s positions, including liabilities (or credits) relating to option premiums, upfront fees or cash calls to cover other mark-to-market exposures where such exposures create a cash payable / receivable from the member. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_5BG38Kp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Variation Margin Called")]
    [IsoXmlTag("EndOfDayVartnMrgnClld")]
    public required AmountAndDirection102 EndOfDayVariationMarginCalled { get; init; } 
    
    /// <summary>
    /// Total net cash receivable (payable) in the relevant currency that will be called to cover default fund requirements. DF receipts from clearing members are positive, payments to members are negative. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_8ZkokKp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Default Fund Called")]
    [IsoXmlTag("EndOfDayDfltFndClld")]
    public required AmountAndDirection102 EndOfDayDefaultFundCalled { get; init; } 
    
    /// <summary>
    /// Total cash receivable (or payable) in the relevant currency arising from settlement or delivery obligations of a Clearing Member positions where such obligations arise in the payment system of the CCP. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_At16IKp6EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Settlement Called")]
    [IsoXmlTag("EndOfDaySttlmClld")]
    public required AmountAndDirection102 EndOfDaySettlementCalled { get; init; } 
    
    /// <summary>
    /// Other cash receivable (payables) in the relevant currency that will be called from or paid to the Clearing Member by the CCP. Such obligations may include exchange/clearing fees, and interest on margin interest on mark-to-market, coupon payments (including such payments called and settled by a securities settlement system). Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_Gb0woKp6EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Other Called")]
    [IsoXmlTag("EndOfDayOthrClld")]
    public required AmountAndDirection102 EndOfDayOtherCalled { get; init; } 
    
    /// <summary>
    /// Net cash receivables (payable) that will be called/paid by the CCP to the clearing member in the relevant currency. If the amount represents a credit for the clearing member, the net cash amount due to be delivered on the reporting date and/or returnable on demand by the Clearing Member. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_6b5MYOoeEeadseq5W5YLvQ")]
    [DisplayName("End Of Day Liquidity Called")]
    [IsoXmlTag("EndOfDayLqdtyClld")]
    public required AmountAndDirection102 EndOfDayLiquidityCalled { get; init; } 
    
    
    #nullable disable
    
}
