// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters for an Isabel reporting file.
/// </summary>
[IsoId("_I2fmp8m6EeWAGphE2LvqeA")]
[DisplayName("Isabel File")]
public partial record IsabelFile4
{
    #nullable enable
    
    /// <summary>
    /// Format of the file.
    /// </summary>
    [IsoId("_I2fmq8m6EeWAGphE2LvqeA")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text Format { get; init; } 
    
    /// <summary>
    /// Name of the mime file.
    /// </summary>
    [IsoId("_I2fmqsm6EeWAGphE2LvqeA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max100AlphaNumericUnderscoreText)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100AlphaNumericUnderscoreText? Name { get; init; } 
    
    /// <summary>
    /// Type of the mime file.
    /// </summary>
    [IsoId("_I2fmrMm6EeWAGphE2LvqeA")]
    [DisplayName("MIME Type")]
    [IsoXmlTag("MIMETp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? MIMEType { get; init; } 
    
    
    #nullable disable
    
}
