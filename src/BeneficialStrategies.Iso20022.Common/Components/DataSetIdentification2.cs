// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a data set.
/// </summary>
[IsoId("_K8wSMX1DEeCF8NjrBemJWQ_715456513")]
[DisplayName("Data Set Identification")]
public record DataSetIdentification2
{
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_K8wSMn1DEeCF8NjrBemJWQ_601617447")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_K8wSM31DEeCF8NjrBemJWQ_-395454906")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory2Code Type { get; init; }

    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_K8wSNH1DEeCF8NjrBemJWQ_-1392527259")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_K8wSNX1DEeCF8NjrBemJWQ_1905367684")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
