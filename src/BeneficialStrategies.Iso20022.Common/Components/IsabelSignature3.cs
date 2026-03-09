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
/// Specifies the signature of an Isabel file.
/// </summary>
[IsoId("_lknXcc_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel Signature")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelSignature3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelSignature3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelSignature3( IsabelSignatureHash1 reqHeader,System.String reqRandomBlock )
    {
        Header = reqHeader;
        RandomBlock = reqRandomBlock;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common signature elements applicable to all signature records.
    /// </summary>
    [IsoId("_l1lLoc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsabelSignatureHash1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IsabelSignatureHash1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelSignatureHash1 Header { get; init; } 
    #else
    public IsabelSignatureHash1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Individual record of the file signature.
    /// </summary>
    [IsoId("_l1lLo8_aEeWjSMe6YTKHlQ")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<IsabelSignatureRecord2> Record { get; init; } = new ValueList<IsabelSignatureRecord2>(){};
    
    /// <summary>
    /// Random data related to the signature.
    /// </summary>
    [IsoId("_l1lLpc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Random Block")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RandBlck")]
    #endif
    [IsoXmlTag("RandBlck")]
    [IsoSimpleType(IsoSimpleType.Max64Text)]
    [StringLength(maximumLength: 64 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax64Text RandomBlock { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RandomBlock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RandomBlock { get; init; } 
    #else
    public System.String RandomBlock { get; set; } 
    #endif
    
    
    #nullable disable
    
}
