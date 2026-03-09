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
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_bGwbsIoYEeSirOZJBRz_nA")]
[DisplayName("ATM Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCustomer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the withdrawal.
    /// </summary>
    [IsoId("_KMy_gIoZEeSirOZJBRz_nA")]
    [DisplayName("Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prfl")]
    #endif
    [IsoXmlTag("Prfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCustomerProfile1? Profile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomerProfile1? Profile { get; init; } 
    #else
    public ATMCustomerProfile1? Profile { get; set; } 
    #endif
    
    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_DnJrwIoaEeSirOZJBRz_nA")]
    [DisplayName("Selected Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SelctdLang")]
    #endif
    [IsoXmlTag("SelctdLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? SelectedLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SelectedLanguage { get; init; } 
    #else
    public string? SelectedLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer and its card.
    /// </summary>
    [IsoId("_eMgZwIoaEeSirOZJBRz_nA")]
    [DisplayName("Authentication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authntcn")]
    #endif
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication8> Authentication { get; init; } = new ValueList<CardholderAuthentication8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _eMgZwIoaEeSirOZJBRz_nA
    
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_DxkrsIodEeSirOZJBRz_nA")]
    [DisplayName("Authentication Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnRslt")]
    #endif
    [IsoXmlTag("AuthntcnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    #else
    public TransactionVerificationResult5? AuthenticationResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
