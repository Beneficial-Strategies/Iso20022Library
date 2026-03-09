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
/// Identification of the cardholder involved in a transaction.
/// </summary>
[IsoId("_SoWAKwEcEeCQm6a_G2yO_w_-1995265470")]
[DisplayName("Cardholder Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderIdentification1( System.String reqCardholderIdentificationValue,PersonIdentificationType4Code reqCardholderIdentificationType )
    {
        CardholderIdentificationValue = reqCardholderIdentificationValue;
        CardholderIdentificationType = reqCardholderIdentificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification value of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_SoWALAEcEeCQm6a_G2yO_w_596422852")]
    [DisplayName("Cardholder Identification Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrIdVal")]
    #endif
    [IsoXmlTag("CrdhldrIdVal")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CardholderIdentificationValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CardholderIdentificationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CardholderIdentificationValue { get; init; } 
    #else
    public System.String CardholderIdentificationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Type of identification used for identifying the cardholder.
    /// </summary>
    [IsoId("_SoWALQEcEeCQm6a_G2yO_w_-899306894")]
    [DisplayName("Cardholder Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrIdTp")]
    #endif
    [IsoXmlTag("CrdhldrIdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonIdentificationType4Code CardholderIdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonIdentificationType4Code CardholderIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentificationType4Code CardholderIdentificationType { get; init; } 
    #else
    public PersonIdentificationType4Code CardholderIdentificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
