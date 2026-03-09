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
[IsoId("_pit8MTi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionBalanceDetails44
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
    [IsoId("_pit8Mzi7Eeydid5dcNPKvg")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity80Choice_? TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity80Choice_? TotalEligibleBalance { get; init; } 
    #else
    public Quantity80Choice_? TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_pit8Ozi7Eeydid5dcNPKvg")]
    [DisplayName("Blocked Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdBal")]
    #endif
    [IsoXmlTag("BlckdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? BlockedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? BlockedBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? BlockedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_pit8Qzi7Eeydid5dcNPKvg")]
    [DisplayName("Borrowed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwdBal")]
    #endif
    [IsoXmlTag("BrrwdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? BorrowedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? BorrowedBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? BorrowedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_pit8Szi7Eeydid5dcNPKvg")]
    [DisplayName("Collateral In Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInBal")]
    #endif
    [IsoXmlTag("CollInBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? CollateralInBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? CollateralInBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? CollateralInBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_pit8Uzi7Eeydid5dcNPKvg")]
    [DisplayName("Collateral Out Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOutBal")]
    #endif
    [IsoXmlTag("CollOutBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? CollateralOutBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? CollateralOutBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? CollateralOutBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_pit8Wzi7Eeydid5dcNPKvg")]
    [DisplayName("On Loan Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLnBal")]
    #endif
    [IsoXmlTag("OnLnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? OnLoanBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? OnLoanBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? OnLoanBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_piuiQTi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Delivery Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgDlvryBal")]
    #endif
    [IsoXmlTag("PdgDlvryBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? PendingDeliveryBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? PendingDeliveryBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? PendingDeliveryBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_piuiSTi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Receipt Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgRctBal")]
    #endif
    [IsoXmlTag("PdgRctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? PendingReceiptBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? PendingReceiptBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? PendingReceiptBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_piuiUTi7Eeydid5dcNPKvg")]
    [DisplayName("Out For Registration Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutForRegnBal")]
    #endif
    [IsoXmlTag("OutForRegnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? OutForRegistrationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? OutForRegistrationBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? OutForRegistrationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_piuiWTi7Eeydid5dcNPKvg")]
    [DisplayName("Settlement Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPosBal")]
    #endif
    [IsoXmlTag("SttlmPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? SettlementPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? SettlementPositionBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? SettlementPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_piuiYTi7Eeydid5dcNPKvg")]
    [DisplayName("Street Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtPosBal")]
    #endif
    [IsoXmlTag("StrtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? StreetPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? StreetPositionBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? StreetPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_piuiaTi7Eeydid5dcNPKvg")]
    [DisplayName("Trade Date Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtPosBal")]
    #endif
    [IsoXmlTag("TradDtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? TradeDatePositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? TradeDatePositionBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? TradeDatePositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_piuicTi7Eeydid5dcNPKvg")]
    [DisplayName("In Transshipment Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InTrnsShipmntBal")]
    #endif
    [IsoXmlTag("InTrnsShipmntBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? InTransshipmentBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? InTransshipmentBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? InTransshipmentBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_piuieTi7Eeydid5dcNPKvg")]
    [DisplayName("Registered Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdBal")]
    #endif
    [IsoXmlTag("RegdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat14Choice_? RegisteredBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat14Choice_? RegisteredBalance { get; init; } 
    #else
    public BalanceFormat14Choice_? RegisteredBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
