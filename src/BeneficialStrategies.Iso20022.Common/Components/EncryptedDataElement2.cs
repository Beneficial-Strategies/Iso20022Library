// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted Data Element2.
/// </summary>
[IsoId("_sJJtsXdBEe6YlIMyoxWMJA")]
[DisplayName("Encrypted Data Element2")]
public partial record EncryptedDataElement2
{
    #nullable enable

    /// <summary>
    /// Clear Text Format.
    /// </summary>
    [DisplayName("Clear Text Format")]
    [IsoXmlTag("ClearTxtFrmt")]
    public EncryptedDataFormat1Code? ClearTextFormat { get; init; } 

    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required EncryptedData2Choice_ Data { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; } 

    /// <summary>
    /// Other Clear Text Format.
    /// </summary>
    [DisplayName("Other Clear Text Format")]
    [IsoXmlTag("OthrClearTxtFrmt")]
    public IsoMax35Text? OtherClearTextFormat { get; init; } 

    
    #nullable disable
    
}
