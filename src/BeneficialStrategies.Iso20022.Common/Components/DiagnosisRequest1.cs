// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Diagnosis Request message.
/// </summary>
[IsoId("_76gkoN6JEeiwsev40qZGEQ")]
[DisplayName("Diagnosis Request")]
public record DiagnosisRequest1
{
    /// <summary>
    /// Indicates if Host Diagnosis are required.
    /// </summary>
    [IsoId("_BUIUsN6KEeiwsev40qZGEQ")]
    [DisplayName("Host Diagnosis Flag")]
    [IsoXmlTag("HstDgnssFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HostDiagnosisFlag { get; init; }

    /// <summary>
    /// Identification of the Acquirers.
    /// </summary>
    [IsoId("_ETK4sN6KEeiwsev40qZGEQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AcquirerIdentification { get; init; }
}
