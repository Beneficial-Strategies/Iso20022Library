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
[IsoId("_QeZTYb-8Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Unallocated Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedDetailsSD6
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
    [IsoId("_QvgRgb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Distribution Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdDstrbtnBal")]
    #endif
    [IsoXmlTag("UallctdDstrbtnBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD3Choice_? UnallocatedDistributionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD3Choice_? UnallocatedDistributionBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD3Choice_? UnallocatedDistributionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRib-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Redemption Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdRedBal")]
    #endif
    [IsoXmlTag("UallctdRedBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD3? UnallocatedRedemptionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD3? UnallocatedRedemptionBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD3? UnallocatedRedemptionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Type of participants positions reorganisation balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRi7-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Reorganisation Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdReorgBal")]
    #endif
    [IsoXmlTag("UallctdReorgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedBalanceSD4? UnallocatedReorganisationBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedBalanceSD4? UnallocatedReorganisationBalance { get; init; } 
    #else
    public CorporateActionUnallocatedBalanceSD4? UnallocatedReorganisationBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRjb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Securities Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdSctiesTxDtls")]
    #endif
    [IsoXmlTag("UallctdSctiesTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD7? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD7? UnallocatedSecuritiesTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD7? UnallocatedSecuritiesTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRlb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Cash Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdCshTxDtls")]
    #endif
    [IsoXmlTag("UallctdCshTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionUnallocatedCashTransactionDetailsSD6? UnallocatedCashTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionUnallocatedCashTransactionDetailsSD6? UnallocatedCashTransactionDetails { get; init; } 
    #else
    public CorporateActionUnallocatedCashTransactionDetailsSD6? UnallocatedCashTransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
