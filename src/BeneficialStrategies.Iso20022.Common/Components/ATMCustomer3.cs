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
[IsoId("_RIosoYqPEeSRT5rEzcAHEw")]
[DisplayName("ATM Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCustomer3
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
    [IsoId("_RUtZwYqPEeSRT5rEzcAHEw")]
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
    [IsoId("_RUtZw4qPEeSRT5rEzcAHEw")]
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
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_RUtZxYqPEeSRT5rEzcAHEw")]
    [DisplayName("Authentication Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnRslt")]
    #endif
    [IsoXmlTag("AuthntcnRslt")]
    public ValueList<TransactionVerificationResult5> AuthenticationResult { get; init; } = new ValueList<TransactionVerificationResult5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RUtZxYqPEeSRT5rEzcAHEw
    
    
    #nullable disable
    
}
