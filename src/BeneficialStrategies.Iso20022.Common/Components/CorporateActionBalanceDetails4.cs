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
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
[IsoId("_R9gMiNp-Ed-ak6NoX_4Aeg_-783579312")]
[DisplayName("Corporate Action Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionBalanceDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionBalanceDetails4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionBalanceDetails4( Quantity3Choice_ reqTotalEligibleBalance,BalanceFormat1Choice_ reqUninstructedBalance,InstructedBalanceDetails1 reqTotalInstructedBalanceDetails )
    {
        TotalEligibleBalance = reqTotalEligibleBalance;
        UninstructedBalance = reqUninstructedBalance;
        TotalInstructedBalanceDetails = reqTotalInstructedBalanceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_R9gMidp-Ed-ak6NoX_4Aeg_-783579303")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity3Choice_ TotalEligibleBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity3Choice_ TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3Choice_ TotalEligibleBalance { get; init; } 
    #else
    public Quantity3Choice_ TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R9gMitp-Ed-ak6NoX_4Aeg_-1262823646")]
    [DisplayName("Uninstructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UinstdBal")]
    #endif
    [IsoXmlTag("UinstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat1Choice_ UninstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat1Choice_ UninstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_ UninstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_ UninstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_R9p9gNp-Ed-ak6NoX_4Aeg_1501211296")]
    [DisplayName("Total Instructed Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBalDtls")]
    #endif
    [IsoXmlTag("TtlInstdBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructedBalanceDetails1 TotalInstructedBalanceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructedBalanceDetails1 TotalInstructedBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedBalanceDetails1 TotalInstructedBalanceDetails { get; init; } 
    #else
    public InstructedBalanceDetails1 TotalInstructedBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_R9p9gdp-Ed-ak6NoX_4Aeg_-783579281")]
    [DisplayName("Blocked Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdBal")]
    #endif
    [IsoXmlTag("BlckdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? BlockedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? BlockedBalance { get; init; } 
    #else
    public SignedQuantityFormat2? BlockedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_R9p9gtp-Ed-ak6NoX_4Aeg_-783579220")]
    [DisplayName("Borrowed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwdBal")]
    #endif
    [IsoXmlTag("BrrwdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? BorrowedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? BorrowedBalance { get; init; } 
    #else
    public SignedQuantityFormat2? BorrowedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_R9p9g9p-Ed-ak6NoX_4Aeg_-783578941")]
    [DisplayName("Collateral In Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInBal")]
    #endif
    [IsoXmlTag("CollInBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? CollateralInBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? CollateralInBalance { get; init; } 
    #else
    public SignedQuantityFormat2? CollateralInBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_R9p9hNp-Ed-ak6NoX_4Aeg_-783578880")]
    [DisplayName("Collateral Out Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOutBal")]
    #endif
    [IsoXmlTag("CollOutBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? CollateralOutBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? CollateralOutBalance { get; init; } 
    #else
    public SignedQuantityFormat2? CollateralOutBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_R9p9hdp-Ed-ak6NoX_4Aeg_-783578849")]
    [DisplayName("On Loan Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLnBal")]
    #endif
    [IsoXmlTag("OnLnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? OnLoanBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? OnLoanBalance { get; init; } 
    #else
    public SignedQuantityFormat2? OnLoanBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_R9p9htp-Ed-ak6NoX_4Aeg_-783578757")]
    [DisplayName("Out For Registration Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutForRegnBal")]
    #endif
    [IsoXmlTag("OutForRegnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? OutForRegistrationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? OutForRegistrationBalance { get; init; } 
    #else
    public SignedQuantityFormat2? OutForRegistrationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_R9p9h9p-Ed-ak6NoX_4Aeg_-783578727")]
    [DisplayName("Settlement Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPosBal")]
    #endif
    [IsoXmlTag("SttlmPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? SettlementPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? SettlementPositionBalance { get; init; } 
    #else
    public SignedQuantityFormat2? SettlementPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_R9p9iNp-Ed-ak6NoX_4Aeg_-783578696")]
    [DisplayName("Street Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtPosBal")]
    #endif
    [IsoXmlTag("StrtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? StreetPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? StreetPositionBalance { get; init; } 
    #else
    public SignedQuantityFormat2? StreetPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_R9p9idp-Ed-ak6NoX_4Aeg_-783578666")]
    [DisplayName("Trade Date Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtPosBal")]
    #endif
    [IsoXmlTag("TradDtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? TradeDatePositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? TradeDatePositionBalance { get; init; } 
    #else
    public SignedQuantityFormat2? TradeDatePositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_R9zHcNp-Ed-ak6NoX_4Aeg_-783578418")]
    [DisplayName("In Transshipment Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InTrnsShipmntBal")]
    #endif
    [IsoXmlTag("InTrnsShipmntBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? InTransshipmentBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? InTransshipmentBalance { get; init; } 
    #else
    public SignedQuantityFormat2? InTransshipmentBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_R9zHcdp-Ed-ak6NoX_4Aeg_-783578387")]
    [DisplayName("Registered Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdBal")]
    #endif
    [IsoXmlTag("RegdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? RegisteredBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? RegisteredBalance { get; init; } 
    #else
    public SignedQuantityFormat2? RegisteredBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_R9zHctp-Ed-ak6NoX_4Aeg_-783578386")]
    [DisplayName("Obligated Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtdBal")]
    #endif
    [IsoXmlTag("OblgtdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat2? ObligatedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat2? ObligatedBalance { get; init; } 
    #else
    public SignedQuantityFormat2? ObligatedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_R9zHc9p-Ed-ak6NoX_4Aeg_-1109432052")]
    [DisplayName("Pending Delivery Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgDlvryBal")]
    #endif
    [IsoXmlTag("PdgDlvryBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingBalance1? PendingDeliveryBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingBalance1? PendingDeliveryBalance { get; init; } 
    #else
    public PendingBalance1? PendingDeliveryBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_R9zHdNp-Ed-ak6NoX_4Aeg_-1051250167")]
    [DisplayName("Pending Receipt Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgRctBal")]
    #endif
    [IsoXmlTag("PdgRctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingBalance1? PendingReceiptBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingBalance1? PendingReceiptBalance { get; init; } 
    #else
    public PendingBalance1? PendingReceiptBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
