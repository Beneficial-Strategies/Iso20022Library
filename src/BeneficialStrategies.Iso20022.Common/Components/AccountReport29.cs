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
/// Reports either on the account information or on a business error.
/// </summary>
[IsoId("_fCEawdcZEeqRFcf2R4bPBw")]
[DisplayName("Account Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountReport29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountReport29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountReport29( AccountIdentification4Choice_ reqAccountIdentification,AccountOrBusinessError5Choice_ reqAccountOrError )
    {
        AccountIdentification = reqAccountIdentification;
        AccountOrError = reqAccountOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_fDmEwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_ AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_ AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the account or business error when information has not been found.
    /// </summary>
    [IsoId("_fDmEw9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOrErr")]
    #endif
    [IsoXmlTag("AcctOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountOrBusinessError5Choice_ AccountOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountOrBusinessError5Choice_ AccountOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountOrBusinessError5Choice_ AccountOrError { get; init; } 
    #else
    public AccountOrBusinessError5Choice_ AccountOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
