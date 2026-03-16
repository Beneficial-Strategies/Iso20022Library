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
[IsoId("_8CiyQXGYEe2TbaNWBpRZpQ")]
[DisplayName("Data Set Identification")]
public record DataSetIdentification10
{
    /// <summary>
    /// Name of the data set.
    /// </summary>
    [IsoId("_8Kz9cXGYEe2TbaNWBpRZpQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Category of data set.
    /// </summary>
    [IsoId("_8Kz9c3GYEe2TbaNWBpRZpQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory18Code Type { get; init; }

    /// <summary>
    /// Version of the data set.
    /// </summary>
    [IsoId("_8Kz9dXGYEe2TbaNWBpRZpQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Date and time of creation of the data set.
    /// </summary>
    [IsoId("_8Kz9d3GYEe2TbaNWBpRZpQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }
}
