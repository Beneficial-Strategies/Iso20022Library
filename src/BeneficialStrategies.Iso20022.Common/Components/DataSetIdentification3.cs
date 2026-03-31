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
[IsoId("_AP3oUSmsEeKIjpr--01h3Q")]
[DisplayName("Data Set Identification")]
public record DataSetIdentification3
{
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_AcERQSmsEeKIjpr--01h3Q")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_AcERRSmsEeKIjpr--01h3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory3Code Type { get; init; }

    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_AcERSSmsEeKIjpr--01h3Q")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_AcERTSmsEeKIjpr--01h3Q")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
