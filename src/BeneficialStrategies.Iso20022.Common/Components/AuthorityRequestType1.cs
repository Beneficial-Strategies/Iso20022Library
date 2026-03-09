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
/// Specifies the authority request type.
/// </summary>
[IsoId("_1uJfwPG1EeGldvY3i8Fbvw")]
[DisplayName("Authority Request Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorityRequestType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorityRequestType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorityRequestType1( System.String reqMessageNameIdentification )
    {
        MessageNameIdentification = reqMessageNameIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the requested message name identifier.
    /// </summary>
    [IsoId("_8kjW4PG1EeGldvY3i8Fbvw")]
    [DisplayName("Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNmId")]
    #endif
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageNameIdentification { get; init; } 
    #else
    public System.String MessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the message name.
    /// </summary>
    [IsoId("_FsZFIPG2EeGldvY3i8Fbvw")]
    [DisplayName("Message Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNm")]
    #endif
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? MessageName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageName { get; init; } 
    #else
    public System.String? MessageName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
