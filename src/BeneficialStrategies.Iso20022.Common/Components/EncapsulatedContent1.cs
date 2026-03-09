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
/// Data to authenticate.
/// </summary>
[IsoId("_SwiSywEcEeCQm6a_G2yO_w_1932848830")]
[DisplayName("Encapsulated Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncapsulatedContent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncapsulatedContent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncapsulatedContent1( ContentType1Code reqContentType )
    {
        ContentType = reqContentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data which have been authenticated.
    /// </summary>
    [IsoId("_SwiSzAEcEeCQm6a_G2yO_w_88979841")]
    [DisplayName("Content Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttTp")]
    #endif
    [IsoXmlTag("CnttTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentType1Code ContentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentType1Code ContentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentType1Code ContentType { get; init; } 
    #else
    public ContentType1Code ContentType { get; set; } 
    #endif
    
    /// <summary>
    /// Actual data to authenticate.
    /// </summary>
    [IsoId("_SwiSzQEcEeCQm6a_G2yO_w_1303832263")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Content { get; init; } 
    #else
    public System.Byte[]? Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
