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
[IsoId("_R9zHddp-Ed-ak6NoX_4Aeg_-947936531")]
[DisplayName("Corporate Action Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionBalanceDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionBalanceDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionBalanceDetails2( BalanceFormat1Choice_ reqConfirmedBalance )
    {
        ConfirmedBalance = reqConfirmedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [IsoId("_R9zHdtp-Ed-ak6NoX_4Aeg_-355301315")]
    [DisplayName("Confirmed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdBal")]
    #endif
    [IsoXmlTag("ConfdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    #else
    public BalanceFormat1Choice_ ConfirmedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_R9zHd9p-Ed-ak6NoX_4Aeg_-947936500")]
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
    [IsoId("_R9zHeNp-Ed-ak6NoX_4Aeg_-947936469")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R9zHedp-Ed-ak6NoX_4Aeg_-947936408")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984cNp-Ed-ak6NoX_4Aeg_-947936377")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984cdp-Ed-ak6NoX_4Aeg_-947936316")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984ctp-Ed-ak6NoX_4Aeg_-947936069")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984c9p-Ed-ak6NoX_4Aeg_-947936038")]
    [DisplayName("Pending Delivery Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgDlvryBal")]
    #endif
    [IsoXmlTag("PdgDlvryBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? PendingDeliveryBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? PendingDeliveryBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? PendingDeliveryBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984dNp-Ed-ak6NoX_4Aeg_-947936007")]
    [DisplayName("Pending Receipt Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgRctBal")]
    #endif
    [IsoXmlTag("PdgRctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? PendingReceiptBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? PendingReceiptBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? PendingReceiptBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984ddp-Ed-ak6NoX_4Aeg_-947935977")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984dtp-Ed-ak6NoX_4Aeg_-947935946")]
    [DisplayName("Settlement Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPosBal")]
    #endif
    [IsoXmlTag("SttlmPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceFormat1Choice_? SettlementPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat1Choice_? SettlementPositionBalance { get; init; } 
    #else
    public BalanceFormat1Choice_? SettlementPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984d9p-Ed-ak6NoX_4Aeg_-947935915")]
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
    [IsoId("_R984eNp-Ed-ak6NoX_4Aeg_-947935637")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R984edp-Ed-ak6NoX_4Aeg_-947935606")]
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
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_R-GCYNp-Ed-ak6NoX_4Aeg_-947935605")]
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
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    [IsoId("_R-GCYdp-Ed-ak6NoX_4Aeg_261287109")]
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
    [IsoId("_R-GCYtp-Ed-ak6NoX_4Aeg_1183836125")]
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
