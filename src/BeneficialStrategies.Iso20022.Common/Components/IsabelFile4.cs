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
/// Specifies the parameters for an Isabel reporting file.
/// </summary>
[IsoId("_I2fmp8m6EeWAGphE2LvqeA")]
[DisplayName("Isabel File")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelFile4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelFile4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelFile4( System.String reqFormat )
    {
        Format = reqFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Format of the file.
    /// </summary>
    [IsoId("_I2fmq8m6EeWAGphE2LvqeA")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text Format { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Format { get; init; } 
    #else
    public System.String Format { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the mime file.
    /// </summary>
    [IsoId("_I2fmqsm6EeWAGphE2LvqeA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max100AlphaNumericUnderscoreText)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100AlphaNumericUnderscoreText? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the mime file.
    /// </summary>
    [IsoId("_I2fmrMm6EeWAGphE2LvqeA")]
    [DisplayName("MIME Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MIMETp")]
    #endif
    [IsoXmlTag("MIMETp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? MIMEType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MIMEType { get; init; } 
    #else
    public System.String? MIMEType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
