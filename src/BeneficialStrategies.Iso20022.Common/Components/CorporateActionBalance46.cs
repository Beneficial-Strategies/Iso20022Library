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
[IsoId("_Io1y9xn1EeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionBalance46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionBalance46 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionBalance46( Quantity49Choice_ reqTotalEligibleBalance,BalanceFormat11Choice_ reqUninstructedBalance,InstructedBalance16 reqTotalInstructedBalanceDetails )
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
    [IsoId("_I-cPcRn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Eligible Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlElgblBal")]
    #endif
    [IsoXmlTag("TtlElgblBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity49Choice_ TotalEligibleBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity49Choice_ TotalEligibleBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity49Choice_ TotalEligibleBalance { get; init; } 
    #else
    public Quantity49Choice_ TotalEligibleBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_I-cPeRn1EeyroI8qKgB7Mg")]
    [DisplayName("Uninstructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UinstdBal")]
    #endif
    [IsoXmlTag("UinstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat11Choice_ UninstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat11Choice_ UninstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat11Choice_ UninstructedBalance { get; init; } 
    #else
    public BalanceFormat11Choice_ UninstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_I-cPgRn1EeyroI8qKgB7Mg")]
    [DisplayName("Total Instructed Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBalDtls")]
    #endif
    [IsoXmlTag("TtlInstdBalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructedBalance16 TotalInstructedBalanceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructedBalance16 TotalInstructedBalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedBalance16 TotalInstructedBalanceDetails { get; init; } 
    #else
    public InstructedBalance16 TotalInstructedBalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [IsoId("_I-cPgxn1EeyroI8qKgB7Mg")]
    [DisplayName("Blocked Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdBal")]
    #endif
    [IsoXmlTag("BlckdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? BlockedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? BlockedBalance { get; init; } 
    #else
    public SignedQuantityFormat10? BlockedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [IsoId("_I-cPixn1EeyroI8qKgB7Mg")]
    [DisplayName("Borrowed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwdBal")]
    #endif
    [IsoXmlTag("BrrwdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? BorrowedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? BorrowedBalance { get; init; } 
    #else
    public SignedQuantityFormat10? BorrowedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [IsoId("_I-cPkxn1EeyroI8qKgB7Mg")]
    [DisplayName("Collateral In Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInBal")]
    #endif
    [IsoXmlTag("CollInBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? CollateralInBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? CollateralInBalance { get; init; } 
    #else
    public SignedQuantityFormat10? CollateralInBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [IsoId("_I-cPmxn1EeyroI8qKgB7Mg")]
    [DisplayName("Collateral Out Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOutBal")]
    #endif
    [IsoXmlTag("CollOutBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? CollateralOutBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? CollateralOutBalance { get; init; } 
    #else
    public SignedQuantityFormat10? CollateralOutBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [IsoId("_I-cPoxn1EeyroI8qKgB7Mg")]
    [DisplayName("On Loan Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLnBal")]
    #endif
    [IsoXmlTag("OnLnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OnLoanBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OnLoanBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OnLoanBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [IsoId("_I-cPqxn1EeyroI8qKgB7Mg")]
    [DisplayName("Out For Registration Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutForRegnBal")]
    #endif
    [IsoXmlTag("OutForRegnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? OutForRegistrationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? OutForRegistrationBalance { get; init; } 
    #else
    public SignedQuantityFormat10? OutForRegistrationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [IsoId("_I-cPsxn1EeyroI8qKgB7Mg")]
    [DisplayName("Settlement Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPosBal")]
    #endif
    [IsoXmlTag("SttlmPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? SettlementPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? SettlementPositionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? SettlementPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [IsoId("_I-cPuxn1EeyroI8qKgB7Mg")]
    [DisplayName("Street Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtPosBal")]
    #endif
    [IsoXmlTag("StrtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? StreetPositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? StreetPositionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? StreetPositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [IsoId("_I-cPwxn1EeyroI8qKgB7Mg")]
    [DisplayName("Trade Date Position Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtPosBal")]
    #endif
    [IsoXmlTag("TradDtPosBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? TradeDatePositionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? TradeDatePositionBalance { get; init; } 
    #else
    public SignedQuantityFormat10? TradeDatePositionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [IsoId("_I-cPyxn1EeyroI8qKgB7Mg")]
    [DisplayName("In Transshipment Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InTrnsShipmntBal")]
    #endif
    [IsoXmlTag("InTrnsShipmntBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? InTransshipmentBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? InTransshipmentBalance { get; init; } 
    #else
    public SignedQuantityFormat10? InTransshipmentBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [IsoId("_I-cP0xn1EeyroI8qKgB7Mg")]
    [DisplayName("Registered Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdBal")]
    #endif
    [IsoXmlTag("RegdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? RegisteredBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? RegisteredBalance { get; init; } 
    #else
    public SignedQuantityFormat10? RegisteredBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [IsoId("_I-cP2xn1EeyroI8qKgB7Mg")]
    [DisplayName("Obligated Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtdBal")]
    #endif
    [IsoXmlTag("OblgtdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? ObligatedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? ObligatedBalance { get; init; } 
    #else
    public SignedQuantityFormat10? ObligatedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [IsoId("_I-cP4xn1EeyroI8qKgB7Mg")]
    [DisplayName("Pending Delivery Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgDlvryBal")]
    #endif
    [IsoXmlTag("PdgDlvryBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingBalance7? PendingDeliveryBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingBalance7? PendingDeliveryBalance { get; init; } 
    #else
    public PendingBalance7? PendingDeliveryBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [IsoId("_I-cP6xn1EeyroI8qKgB7Mg")]
    [DisplayName("Pending Receipt Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgRctBal")]
    #endif
    [IsoXmlTag("PdgRctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingBalance7? PendingReceiptBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingBalance7? PendingReceiptBalance { get; init; } 
    #else
    public PendingBalance7? PendingReceiptBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
