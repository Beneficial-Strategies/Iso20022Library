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
/// Identification of the stored value account or the stored value card (Prepaid card).
/// </summary>
[IsoId("_QMJNsNtcEeipuvJHTHIw9A")]
[DisplayName("Stored Value Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StoredValueAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of stored value account.
    /// </summary>
    [IsoId("_dQGzQNtcEeipuvJHTHIw9A")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccountType1Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccountType1Code? AccountType { get; init; } 
    #else
    public StoredValueAccountType1Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identification for this Stored Value Account.
    /// </summary>
    [IsoId("_AXDAcNtgEeipuvJHTHIw9A")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardIdentificationType1Code? IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardIdentificationType1Code? IdentificationType { get; init; } 
    #else
    public CardIdentificationType1Code? IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of Stored Value Account.
    /// </summary>
    [IsoId("_R7WSwNtiEeipuvJHTHIw9A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_WhYpwNtiEeipuvJHTHIw9A")]
    [DisplayName("Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnd")]
    #endif
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Brand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Brand { get; init; } 
    #else
    public System.String? Brand { get; set; } 
    #endif
    
    /// <summary>
    /// Provider of the Stored Value Account.
    /// </summary>
    [IsoId("_dARYwNtiEeipuvJHTHIw9A")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Provider { get; init; } 
    #else
    public System.String? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_kEd0QNtiEeipuvJHTHIw9A")]
    [DisplayName("Owner Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrNm")]
    #endif
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax45Text? OwnerName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OwnerName { get; init; } 
    #else
    public System.String? OwnerName { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the account of card.
    /// </summary>
    [IsoId("_p1McwNtiEeipuvJHTHIw9A")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExpiryDate { get; init; } 
    #else
    public System.String? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Standard or last entry mode to access the Stored Value account or card.
    /// </summary>
    [IsoId("_s84xANtjEeipuvJHTHIw9A")]
    [DisplayName("Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryMd")]
    #endif
    [IsoXmlTag("NtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading6Code? EntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading6Code? EntryMode { get; init; } 
    #else
    public CardDataReading6Code? EntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the Stored Value account.
    /// </summary>
    [IsoId("_yE6awNtjEeipuvJHTHIw9A")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Current balance of the Stored Value account.
    /// </summary>
    [IsoId("_28EW8NtjEeipuvJHTHIw9A")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Balance { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Balance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
