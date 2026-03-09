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
/// Specifies a record holding the LRCI required data related to a payment file.
/// </summary>
[IsoId("_2UOvYM_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel LRCI Payment Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelLRCIPaymentInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelLRCIPaymentInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelLRCIPaymentInformation1( System.Byte[] reqImageHash,System.Byte[] reqPaymentHash )
    {
        ImageHash = reqImageHash;
        PaymentHash = reqPaymentHash;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to the visual representation of a particular payment file.
    /// </summary>
    [IsoId("_Bz7F0M_bEeWjSMe6YTKHlQ")]
    [DisplayName("Image Hash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgHash")]
    #endif
    [IsoXmlTag("ImgHash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Binary ImageHash { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] ImageHash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] ImageHash { get; init; } 
    #else
    public System.Byte[] ImageHash { get; set; } 
    #endif
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to a particular payment file.
    /// </summary>
    [IsoId("_G9JpcM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Payment Hash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtHash")]
    #endif
    [IsoXmlTag("PmtHash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Binary PaymentHash { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] PaymentHash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] PaymentHash { get; init; } 
    #else
    public System.Byte[] PaymentHash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
