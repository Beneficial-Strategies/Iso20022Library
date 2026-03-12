// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the processing.
/// </summary>
[IsoId("_0KZ7kZf2Eee-7IkMvqfAcA")]
[DisplayName("Result Data")]
public partial record ResultData5
{
    #nullable enable
    
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_0WWF0Zf2Eee-7IkMvqfAcA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Response8Code? Result { get; init; } 
    
    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_kZn_0Zi5EeefZKJHxQTztg")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; } 
    
    /// <summary>
    /// Detailed results of the processing.
    /// ISO 8583:1987 bit 39, response code list
    /// </summary>
    [IsoId("_OpmzoZi6EeefZKJHxQTztg")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText ResultDetails { get; init; } 
    
    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_0WWF15f2Eee-7IkMvqfAcA")]
    [DisplayName("Additional Result Information")]
    [IsoXmlTag("AddtlRsltInf")]
    public AdditionalData1? AdditionalResultInformation { get; init; } 
    
    
    #nullable disable
    
}
