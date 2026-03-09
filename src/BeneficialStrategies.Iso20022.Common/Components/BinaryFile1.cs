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
/// Computer file stored in a binary format.
/// </summary>
[IsoId("_SuAjOgEcEeCQm6a_G2yO_w_2121992872")]
[DisplayName("Binary File")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BinaryFile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code specifying the Multipurpose Internet Mail Extensions (MIME) type for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - MIME Media Types (www.iana.org/assignments/media-types).
    /// </summary>
    [IsoId("_SuAjOwEcEeCQm6a_G2yO_w_267897468")]
    [DisplayName("MIME Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MIMETp")]
    #endif
    [IsoXmlTag("MIMETp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MIMEType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MIMEType { get; init; } 
    #else
    public System.String? MIMEType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the encoding algorithm used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Transfer Encodings (www.iana.org/assignments/transfer-encodings).
    /// </summary>
    [IsoId("_SuAjPAEcEeCQm6a_G2yO_w_-122688032")]
    [DisplayName("Encoding Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcodgTp")]
    #endif
    [IsoXmlTag("NcodgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EncodingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EncodingType { get; init; } 
    #else
    public System.String? EncodingType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a code signifying the particular character set used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Character Sets (www.iana.org/assignments/character-sets).
    /// </summary>
    [IsoId("_SuAjPQEcEeCQm6a_G2yO_w_-1899360630")]
    [DisplayName("Character Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CharSet")]
    #endif
    [IsoXmlTag("CharSet")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CharacterSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CharacterSet { get; init; } 
    #else
    public System.String? CharacterSet { get; set; } 
    #endif
    
    /// <summary>
    /// Binary object included in this attached binary file.
    /// </summary>
    [IsoId("_SuAjPgEcEeCQm6a_G2yO_w_-1127180314")]
    [DisplayName("Included Binary Object")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InclBinryObjct")]
    #endif
    [IsoXmlTag("InclBinryObjct")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? IncludedBinaryObject { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? IncludedBinaryObject { get; init; } 
    #else
    public System.Byte[]? IncludedBinaryObject { get; set; } 
    #endif
    
    
    #nullable disable
    
}
