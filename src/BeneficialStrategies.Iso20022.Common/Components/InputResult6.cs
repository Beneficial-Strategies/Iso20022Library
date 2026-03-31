// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Input Result6.
/// </summary>
[IsoId("_A5p-sZFNEe6reqfAp4CunQ")]
[DisplayName("Input Result6")]
public record InputResult6
{
    /// <summary>
    /// Device Type.
    /// </summary>
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required SaleCapabilities2Code DeviceType { get; init; }

    /// <summary>
    /// Information Qualifier.
    /// </summary>
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; }

    /// <summary>
    /// Input Result Data.
    /// </summary>
    [DisplayName("Input Result Data")]
    [IsoXmlTag("InptRsltData")]
    public required InputResultData6 InputResultData { get; init; }
}
