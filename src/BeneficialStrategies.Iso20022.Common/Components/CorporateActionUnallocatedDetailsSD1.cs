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
/// Provides additional information regarding the corporate action event.
/// </summary>
[IsoId("_1YlrQDL3EeKU9IrkkToqcw_1723135962")]
[DisplayName("Corporate Action Unallocated Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionUnallocatedDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionUnallocatedDetailsSD1( System.String reqSafekeepingAccount )
    {
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_1YlrQTL3EeKU9IrkkToqcw_-434487002")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SafekeepingAccount { get; init; } 
    #else
    public System.String SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Type of Participants positions balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrQjL3EeKU9IrkkToqcw_1011922619")]
    [DisplayName("Unallocated Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdBal")]
    #endif
    [IsoXmlTag("UallctdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrQzL3EeKU9IrkkToqcw_-1811501059")]
    [DisplayName("Unallocated Securities Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdSctiesTxDtls")]
    #endif
    [IsoXmlTag("UallctdSctiesTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD1? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD1? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD1? UnallocatedSecuritiesTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_1YlrRDL3EeKU9IrkkToqcw_883092187")]
    [DisplayName("Unallocated Cash Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdCshTxDtls")]
    #endif
    [IsoXmlTag("UallctdCshTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedCashTransactionDetailsSD1? UnallocatedCashTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedCashTransactionDetailsSD1? UnallocatedCashTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedCashTransactionDetailsSD1? UnallocatedCashTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
