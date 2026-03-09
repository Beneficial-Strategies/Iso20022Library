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
/// Identifier of a token provider requestor.
/// </summary>
[IsoId("_PxXUcGkhEeSTIuB9A-QJ6g")]
[DisplayName("Payment Token Identifiers")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTokenIdentifiers1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTokenIdentifiers1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTokenIdentifiers1( System.String reqProviderIdentification,System.String reqRequestorIdentification )
    {
        ProviderIdentification = reqProviderIdentification;
        RequestorIdentification = reqRequestorIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the token provider.
    /// </summary>
    [IsoId("_XWGRMGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Provider Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvdrId")]
    #endif
    [IsoXmlTag("PrvdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ProviderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProviderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProviderIdentification { get; init; } 
    #else
    public System.String ProviderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the token requestor.
    /// </summary>
    [IsoId("_eIqKIGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Requestor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstrId")]
    #endif
    [IsoXmlTag("RqstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RequestorIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestorIdentification { get; init; } 
    #else
    public System.String RequestorIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
