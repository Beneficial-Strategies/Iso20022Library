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
/// Structure to encrypt data elements.
/// </summary>
[IsoId("_5yR_YMVvEeem1auQ2bBhWw")]
[DisplayName("Encrypted Data Element")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EncryptedDataElement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EncryptedDataElement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EncryptedDataElement1( EncryptedData1Choice_ reqEncryptedData )
    {
        EncryptedData = reqEncryptedData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the element that has been encrypted.
    /// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
    /// </summary>
    [IsoId("_CVXScE4kEeqJcrFc0K-9yg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalEncryptedElementIdentification1Code? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalEncryptedElementIdentification1Code? Identification { get; init; } 
    #else
    public ExternalEncryptedElementIdentification1Code? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Other identification scheme for identifying the element that has been encrypted.
    /// </summary>
    [IsoId("_KZY7kMVwEeem1auQ2bBhWw")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherIdentification { get; init; } 
    #else
    public System.String? OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted data element.
    /// </summary>
    [IsoId("_RW6HUMVwEeem1auQ2bBhWw")]
    [DisplayName("Encrypted Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdData")]
    #endif
    [IsoXmlTag("NcrptdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EncryptedData1Choice_ EncryptedData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EncryptedData1Choice_ EncryptedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptedData1Choice_ EncryptedData { get; init; } 
    #else
    public EncryptedData1Choice_ EncryptedData { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the raw data prior to encryption.
    /// </summary>
    [IsoId("_PCUMwAHwEeiJObvChJn-OA")]
    [DisplayName("Clear Text Data Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClearTxtDataFrmt")]
    #endif
    [IsoXmlTag("ClearTxtDataFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncryptedDataFormat1Code? ClearTextDataFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptedDataFormat1Code? ClearTextDataFormat { get; init; } 
    #else
    public EncryptedDataFormat1Code? ClearTextDataFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Other national or private format of the raw data prior to encryption.
    /// </summary>
    [IsoId("_KH4C8E4YEeqJcrFc0K-9yg")]
    [DisplayName("Other Clear Text Data Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrClearTxtDataFrmt")]
    #endif
    [IsoXmlTag("OthrClearTxtDataFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherClearTextDataFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherClearTextDataFormat { get; init; } 
    #else
    public System.String? OtherClearTextDataFormat { get; set; } 
    #endif
    
    
    #nullable disable
    
}
