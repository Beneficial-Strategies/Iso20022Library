// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structure to encrypt data elements.
/// </summary>
[IsoId("_5yR_YMVvEeem1auQ2bBhWw")]
[DisplayName("Encrypted Data Element")]
public partial record EncryptedDataElement1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the element that has been encrypted.
    /// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
    /// </summary>
    [IsoId("_CVXScE4kEeqJcrFc0K-9yg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ExternalEncryptedElementIdentification1Code? Identification { get; init; } 
    
    /// <summary>
    /// Other identification scheme for identifying the element that has been encrypted.
    /// </summary>
    [IsoId("_KZY7kMVwEeem1auQ2bBhWw")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherIdentification { get; init; } 
    
    /// <summary>
    /// Encrypted data element.
    /// </summary>
    [IsoId("_RW6HUMVwEeem1auQ2bBhWw")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    public required EncryptedData1Choice_ EncryptedData { get; init; } 
    
    /// <summary>
    /// Format of the raw data prior to encryption.
    /// </summary>
    [IsoId("_PCUMwAHwEeiJObvChJn-OA")]
    [DisplayName("Clear Text Data Format")]
    [IsoXmlTag("ClearTxtDataFrmt")]
    public EncryptedDataFormat1Code? ClearTextDataFormat { get; init; } 
    
    /// <summary>
    /// Other national or private format of the raw data prior to encryption.
    /// </summary>
    [IsoId("_KH4C8E4YEeqJcrFc0K-9yg")]
    [DisplayName("Other Clear Text Data Format")]
    [IsoXmlTag("OthrClearTxtDataFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherClearTextDataFormat { get; init; } 
    
    
    #nullable disable
    
}
