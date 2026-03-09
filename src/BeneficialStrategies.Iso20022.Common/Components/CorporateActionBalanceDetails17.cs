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
[IsoId("_yZkMwxFREeKp2ZN13DI_pA")]
[DisplayName("Corporate Action Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionBalanceDetails17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_yuR4VRFREeKp2ZN13DI_pA")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3Choice_? TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3Choice_? TotalEligibleBalance { get; init; } 
    #else
    public Quantity3Choice_? TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_yuR4XxFREeKp2ZN13DI_pA")]
    [DisplayName("Blocked Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdBal")]
    #endif
    [IsoXmlTag("BlckdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? BlockedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? BlockedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? BlockedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_yuR4aRFREeKp2ZN13DI_pA")]
    [DisplayName("Borrowed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwdBal")]
    #endif
    [IsoXmlTag("BrrwdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? BorrowedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? BorrowedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? BorrowedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_yuR4cxFREeKp2ZN13DI_pA")]
    [DisplayName("Collateral In Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInBal")]
    #endif
    [IsoXmlTag("CollInBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? CollateralInBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? CollateralInBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? CollateralInBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_yuR4fRFREeKp2ZN13DI_pA")]
    [DisplayName("Collateral Out Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOutBal")]
    #endif
    [IsoXmlTag("CollOutBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? CollateralOutBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? CollateralOutBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? CollateralOutBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_yuR4hxFREeKp2ZN13DI_pA")]
    [DisplayName("On Loan Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLnBal")]
    #endif
    [IsoXmlTag("OnLnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? OnLoanBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? OnLoanBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? OnLoanBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_yuR4kRFREeKp2ZN13DI_pA")]
    [DisplayName("Pending Delivery Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgDlvryBal")]
    #endif
    [IsoXmlTag("PdgDlvryBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat3Choice_? PendingDeliveryBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat3Choice_? PendingDeliveryBalance { get; init; } 
    #else
    public BalanceFormat3Choice_? PendingDeliveryBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_yuR4mxFREeKp2ZN13DI_pA")]
    [DisplayName("Pending Receipt Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgRctBal")]
    #endif
    [IsoXmlTag("PdgRctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat3Choice_? PendingReceiptBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat3Choice_? PendingReceiptBalance { get; init; } 
    #else
    public BalanceFormat3Choice_? PendingReceiptBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_yuR4pRFREeKp2ZN13DI_pA")]
    [DisplayName("Out For Registration Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutForRegnBal")]
    #endif
    [IsoXmlTag("OutForRegnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? OutForRegistrationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? OutForRegistrationBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? OutForRegistrationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_yuR4rxFREeKp2ZN13DI_pA")]
    [DisplayName("Settlement Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPosBal")]
    #endif
    [IsoXmlTag("SttlmPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat3Choice_? SettlementPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat3Choice_? SettlementPositionBalance { get; init; } 
    #else
    public BalanceFormat3Choice_? SettlementPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_yuR4uRFREeKp2ZN13DI_pA")]
    [DisplayName("Street Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtPosBal")]
    #endif
    [IsoXmlTag("StrtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? StreetPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? StreetPositionBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? StreetPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_yuR4wxFREeKp2ZN13DI_pA")]
    [DisplayName("Trade Date Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtPosBal")]
    #endif
    [IsoXmlTag("TradDtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? TradeDatePositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? TradeDatePositionBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? TradeDatePositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_yuR4zRFREeKp2ZN13DI_pA")]
    [DisplayName("In Transshipment Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InTrnsShipmntBal")]
    #endif
    [IsoXmlTag("InTrnsShipmntBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? InTransshipmentBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? InTransshipmentBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? InTransshipmentBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_yuR41xFREeKp2ZN13DI_pA")]
    [DisplayName("Registered Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdBal")]
    #endif
    [IsoXmlTag("RegdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? RegisteredBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? RegisteredBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? RegisteredBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_yuR44RFREeKp2ZN13DI_pA")]
    [DisplayName("Obligated Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtdBal")]
    #endif
    [IsoXmlTag("OblgtdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? ObligatedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? ObligatedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? ObligatedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_yuR46xFREeKp2ZN13DI_pA")]
    [DisplayName("Uninstructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UinstdBal")]
    #endif
    [IsoXmlTag("UinstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? UninstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_yuR49RFREeKp2ZN13DI_pA")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    [IsoId("_yuR4_xFREeKp2ZN13DI_pA")]
    [DisplayName("Affected Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AfctdBal")]
    #endif
    [IsoXmlTag("AfctdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? AffectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? AffectedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? AffectedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// </summary>
    [IsoId("_yuR5CRFREeKp2ZN13DI_pA")]
    [DisplayName("Unaffected Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UafctdBal")]
    #endif
    [IsoXmlTag("UafctdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? UnaffectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? UnaffectedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? UnaffectedBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
