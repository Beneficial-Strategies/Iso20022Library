// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on business information.
/// </summary>
[IsoId("_1mEoCZlZEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Information Return Criteria")]
public record GeneralBusinessInformationReturnCriteria1
{
    /// <summary>
    /// Indicates whether the qualifier is requested.
    /// </summary>
    [IsoId("_1t_N4ZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Qualifier Indicator")]
    [IsoXmlTag("QlfrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? QualifierIndicator { get; init; }

    /// <summary>
    /// Indicates whether the subject is requested.
    /// </summary>
    [IsoId("_1t_N45lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject Indicator")]
    [IsoXmlTag("SbjtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SubjectIndicator { get; init; }

    /// <summary>
    /// Indicates whether the subject details are requested.
    /// </summary>
    [IsoId("_1t_N5ZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject Details Indicator")]
    [IsoXmlTag("SbjtDtlsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SubjectDetailsIndicator { get; init; }
}
