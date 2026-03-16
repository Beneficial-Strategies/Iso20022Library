// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the input.
/// </summary>
[IsoId("_hGhtERBsEeqgJK7e3n_EXA")]
[DisplayName("Input Result")]
public record InputResult2
{
    /// <summary>
    /// Type of Input device.
    /// </summary>
    [IsoId("_hRaHYRBsEeqgJK7e3n_EXA")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; }

    /// <summary>
    /// Qualifies the type of given information.
    /// </summary>
    [IsoId("_hRaHYxBsEeqgJK7e3n_EXA")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; }

    /// <summary>
    /// Data resulting of input after POI or Sale processing.
    /// </summary>
    [IsoId("_hRaHZRBsEeqgJK7e3n_EXA")]
    [DisplayName("Input Result Data")]
    [IsoXmlTag("InptRsltData")]
    public required InputResultData2 InputResultData { get; init; }
}
