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
/// Balance of the account involved in the card transaction.
/// </summary>
[IsoId("_K3LGsaycEeupy7O5H7ITjQ")]
[DisplayName("Account Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountBalance2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountBalance2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountBalance2( string reqAccountType )
    {
        AccountType = reqAccountType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account for which a balance is sought.
    /// This code list is maintained by the ISO 8583/MA (maintenance agency).
    /// </summary>
    [IsoId("_K7YRQaycEeupy7O5H7ITjQ")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO8583AccountTypeCode AccountType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string AccountType { get; init; } 
    #else
    public string AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_K7YRQ6ycEeupy7O5H7ITjQ")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Balance28? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance28? Balance { get; init; } 
    #else
    public Balance28? Balance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
