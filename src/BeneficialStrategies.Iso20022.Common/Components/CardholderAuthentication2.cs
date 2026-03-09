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
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_SqbqyQEcEeCQm6a_G2yO_w_-1688249611")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderAuthentication2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderAuthentication2( AuthenticationMethod1Code reqAuthenticationMethod,AuthenticationEntity1Code reqAuthenticationEntity )
    {
        AuthenticationMethod = reqAuthenticationMethod;
        AuthenticationEntity = reqAuthenticationEntity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to authenticate the cardholder.
    /// </summary>
    [IsoId("_SqbqygEcEeCQm6a_G2yO_w_-169558028")]
    [DisplayName("Authentication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnMtd")]
    #endif
    [IsoXmlTag("AuthntcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationMethod1Code AuthenticationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationMethod1Code AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod1Code AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod1Code AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Entity or object in charge of verifying the cardholder authenticity.
    /// </summary>
    [IsoId("_SqbqywEcEeCQm6a_G2yO_w_-1371836971")]
    [DisplayName("Authentication Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnNtty")]
    #endif
    [IsoXmlTag("AuthntcnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationEntity1Code AuthenticationEntity { get; init; } 
    #else
    public AuthenticationEntity1Code AuthenticationEntity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
