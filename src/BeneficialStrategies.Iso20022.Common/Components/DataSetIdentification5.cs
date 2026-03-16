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
[IsoId("_wt31kY3IEeWjkqXgn_0Imw")]
[DisplayName("Data Set Identification")]
public record DataSetIdentification5
{
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_w45Z0Y3IEeWjkqXgn_0Imw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Name { get; init; }

    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_w45Z043IEeWjkqXgn_0Imw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory8Code Type { get; init; }

    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_w45Z1Y3IEeWjkqXgn_0Imw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_w45Z143IEeWjkqXgn_0Imw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
