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
[IsoId("_R3C1V52IEeW-bsa36JFb9A")]
[DisplayName("Corporate Action Unallocated Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedDetailsSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvYZ2IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Distribution Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdDstrbtnBal")]
    #endif
    [IsoXmlTag("UallctdDstrbtnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD2Choice_? UnallocatedDistributionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvaZ2IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Redemption Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdRedBal")]
    #endif
    [IsoXmlTag("UallctdRedBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD1? UnallocatedRedemptionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzva52IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Securities Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdSctiesTxDtls")]
    #endif
    [IsoXmlTag("UallctdSctiesTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD5? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD5? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD5? UnallocatedSecuritiesTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_SNzvc52IEeW-bsa36JFb9A")]
    [DisplayName("Unallocated Cash Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdCshTxDtls")]
    #endif
    [IsoXmlTag("UallctdCshTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedCashTransactionDetailsSD4? UnallocatedCashTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedCashTransactionDetailsSD4? UnallocatedCashTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedCashTransactionDetailsSD4? UnallocatedCashTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
