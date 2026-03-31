// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data Set Identification11.
/// </summary>
[IsoId("_FXSyEJ9kEe-nbM0aSPcoiQ")]
[DisplayName("Data Set Identification11")]
public record DataSetIdentification11
{
    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax256Text? Name { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory20Code Type { get; init; }

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }
}
