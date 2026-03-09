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
/// Data related to the result of a processed loyalty transaction.
/// </summary>
[IsoId("_UWZZANxLEeioifFt1dhnJA")]
[DisplayName("Loyalty Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoyaltyResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoyaltyResult1( LoyaltyAccount1 reqAccount )
    {
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account managing the Loyalty.
    /// </summary>
    [IsoId("_jkTGkNxLEeioifFt1dhnJA")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LoyaltyAccount1 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LoyaltyAccount1 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount1 Account { get; init; } 
    #else
    public LoyaltyAccount1 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Amount.
    /// </summary>
    [IsoId("_uuQdkNxLEeioifFt1dhnJA")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAmount1? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAmount1? Amount { get; init; } 
    #else
    public LoyaltyAmount1? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Data sent by the Loyalty server.
    /// </summary>
    [IsoId("_x6aQgNxLEeioifFt1dhnJA")]
    [DisplayName("Server Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrData")]
    #endif
    [IsoXmlTag("SvrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyServerData1? ServerData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyServerData1? ServerData { get; init; } 
    #else
    public LoyaltyServerData1? ServerData { get; set; } 
    #endif
    
    /// <summary>
    /// Rebate information.
    /// </summary>
    [IsoId("_IBz6kNxOEeioifFt1dhnJA")]
    [DisplayName("Rebates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rbts")]
    #endif
    [IsoXmlTag("Rbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRebates1? Rebates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRebates1? Rebates { get; init; } 
    #else
    public LoyaltyRebates1? Rebates { get; set; } 
    #endif
    
    
    #nullable disable
    
}
