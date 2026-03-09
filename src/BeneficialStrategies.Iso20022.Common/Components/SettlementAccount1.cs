// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit account used by the central counterparty to make payments to and from its clearing members.
/// </summary>
[IsoId("_hzT7oKp5EeamNLogr5TkIQ")]
[DisplayName("Settlement Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementAccount1( GenericIdentification165 reqIdentification,AmountAndDirection102 reqEndOfDayInitialMarginCalled,AmountAndDirection102 reqEndOfDayVariationMarginCalled,AmountAndDirection102 reqEndOfDayDefaultFundCalled,AmountAndDirection102 reqEndOfDaySettlementCalled,AmountAndDirection102 reqEndOfDayOtherCalled,AmountAndDirection102 reqEndOfDayLiquidityCalled )
    {
        Identification = reqIdentification;
        EndOfDayInitialMarginCalled = reqEndOfDayInitialMarginCalled;
        EndOfDayVariationMarginCalled = reqEndOfDayVariationMarginCalled;
        EndOfDayDefaultFundCalled = reqEndOfDayDefaultFundCalled;
        EndOfDaySettlementCalled = reqEndOfDaySettlementCalled;
        EndOfDayOtherCalled = reqEndOfDayOtherCalled;
        EndOfDayLiquidityCalled = reqEndOfDayLiquidityCalled;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the settlement account.
    /// </summary>
    [IsoId("_s6JGIKp5EeamNLogr5TkIQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 Identification { get; init; } 
    #else
    public GenericIdentification165 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of initial margin to be called or returned to clearing member the morning following end of day. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_1J_ccKp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Initial Margin Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayInitlMrgnClld")]
    #endif
    [IsoXmlTag("EndOfDayInitlMrgnClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDayInitialMarginCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDayInitialMarginCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDayInitialMarginCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDayInitialMarginCalled { get; set; } 
    #endif
    
    /// <summary>
    /// Total cash receivable (or payable) in the relevant currency based on changes in the mark-to-market of a clearing member’s positions, including liabilities (or credits) relating to option premiums, upfront fees or cash calls to cover other mark-to-market exposures where such exposures create a cash payable / receivable from the member. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_5BG38Kp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Variation Margin Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayVartnMrgnClld")]
    #endif
    [IsoXmlTag("EndOfDayVartnMrgnClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDayVariationMarginCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDayVariationMarginCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDayVariationMarginCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDayVariationMarginCalled { get; set; } 
    #endif
    
    /// <summary>
    /// Total net cash receivable (payable) in the relevant currency that will be called to cover default fund requirements. DF receipts from clearing members are positive, payments to members are negative. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_8ZkokKp5EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Default Fund Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayDfltFndClld")]
    #endif
    [IsoXmlTag("EndOfDayDfltFndClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDayDefaultFundCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDayDefaultFundCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDayDefaultFundCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDayDefaultFundCalled { get; set; } 
    #endif
    
    /// <summary>
    /// Total cash receivable (or payable) in the relevant currency arising from settlement or delivery obligations of a Clearing Member positions where such obligations arise in the payment system of the CCP. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_At16IKp6EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Settlement Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDaySttlmClld")]
    #endif
    [IsoXmlTag("EndOfDaySttlmClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDaySettlementCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDaySettlementCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDaySettlementCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDaySettlementCalled { get; set; } 
    #endif
    
    /// <summary>
    /// Other cash receivable (payables) in the relevant currency that will be called from or paid to the Clearing Member by the CCP. Such obligations may include exchange/clearing fees, and interest on margin interest on mark-to-market, coupon payments (including such payments called and settled by a securities settlement system). Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_Gb0woKp6EeamNLogr5TkIQ")]
    [DisplayName("End Of Day Other Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayOthrClld")]
    #endif
    [IsoXmlTag("EndOfDayOthrClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDayOtherCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDayOtherCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDayOtherCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDayOtherCalled { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash receivables (payable) that will be called/paid by the CCP to the clearing member in the relevant currency. If the amount represents a credit for the clearing member, the net cash amount due to be delivered on the reporting date and/or returnable on demand by the Clearing Member. Indicates whether the clearing member has an obligation to deliver cash to the CCP (true) or receive cash from the CCP (false).
    /// </summary>
    [IsoId("_6b5MYOoeEeadseq5W5YLvQ")]
    [DisplayName("End Of Day Liquidity Called")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayLqdtyClld")]
    #endif
    [IsoXmlTag("EndOfDayLqdtyClld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 EndOfDayLiquidityCalled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 EndOfDayLiquidityCalled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 EndOfDayLiquidityCalled { get; init; } 
    #else
    public AmountAndDirection102 EndOfDayLiquidityCalled { get; set; } 
    #endif
    
    
    #nullable disable
    
}
