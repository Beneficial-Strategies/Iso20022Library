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
/// Identification of requested data set.
/// </summary>
[IsoId("_BS2goTV8EeODSIIQsYYKhw")]
[DisplayName("Terminal Management Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalManagementDataSet8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TerminalManagementDataSet8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TerminalManagementDataSet8( DataSetIdentification3 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    [IsoId("_BjXo4TV8EeODSIIQsYYKhw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification3 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification3 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification3 Identification { get; init; } 
    #else
    public DataSetIdentification3 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_BjXo4zV8EeODSIIQsYYKhw")]
    [DisplayName("POI Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIChllng")]
    #endif
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? POIChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? POIChallenge { get; init; } 
    #else
    public System.Byte[]? POIChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_BjXo5TV8EeODSIIQsYYKhw")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Transport key encrypted by the TM (Terminal manager) key encryption RSA key.
    /// </summary>
    [IsoId("_BjXo5zV8EeODSIIQsYYKhw")]
    [DisplayName("Encrypted Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdKey")]
    #endif
    [IsoXmlTag("NcrptdKey")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType7? EncryptedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType7? EncryptedKey { get; init; } 
    #else
    public ContentInformationType7? EncryptedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
