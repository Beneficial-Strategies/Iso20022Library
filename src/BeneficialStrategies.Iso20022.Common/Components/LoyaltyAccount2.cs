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
/// Loyalty Account description.
/// </summary>
[IsoId("_RXUREQxtEeqdx6buGpCCQw")]
[DisplayName("Loyalty Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyAccount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of Loyalty Account.
    /// </summary>
    [IsoId("_RiHL0QxtEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyId")]
    #endif
    [IsoXmlTag("LltyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LoyaltyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LoyaltyIdentification { get; init; } 
    #else
    public System.String? LoyaltyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Standard or last entry mode to access the Loyalty account or card.
    /// </summary>
    [IsoId("_RiHL0wxtEeqdx6buGpCCQw")]
    [DisplayName("Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryMd")]
    #endif
    [IsoXmlTag("NtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? EntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? EntryMode { get; init; } 
    #else
    public CardDataReading8Code? EntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identification for this Loyalty Account.
    /// </summary>
    [IsoId("_RiHL1QxtEeqdx6buGpCCQw")]
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
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_RiHL1wxtEeqdx6buGpCCQw")]
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
    /// Provider of the Loyalty Account.
    /// </summary>
    [IsoId("_RiHL2QxtEeqdx6buGpCCQw")]
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
    [IsoId("_RiHL2wxtEeqdx6buGpCCQw")]
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
    /// Unit of a Loyalty Account (Point or Currency).
    /// </summary>
    [IsoId("_RiHL3QxtEeqdx6buGpCCQw")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountUnit1Code? Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountUnit1Code? Unit { get; init; } 
    #else
    public AmountUnit1Code? Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of a Loyalty Account if any.
    /// </summary>
    [IsoId("_RiHL3wxtEeqdx6buGpCCQw")]
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
    /// Balance of a Loyalty Account.
    /// </summary>
    [IsoId("_RiHL4QxtEeqdx6buGpCCQw")]
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
