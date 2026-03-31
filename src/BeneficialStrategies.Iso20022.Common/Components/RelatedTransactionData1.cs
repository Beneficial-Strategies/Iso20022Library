// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Transaction Data1.
/// </summary>
[IsoId("_IdzH4FetEe6G45fhJISx6Q")]
[DisplayName("Related Transaction Data1")]
public record RelatedTransactionData1
{
    /// <summary>
    /// Master UETR.
    /// </summary>
    [DisplayName("Master UETR")]
    [IsoXmlTag("MstrUETR")]
    public IsoUUIDv4Identifier? MasterUETR { get; init; }

    /// <summary>
    /// Sub UETR.
    /// </summary>
    [DisplayName("Sub UETR")]
    [IsoXmlTag("SubUETR")]
    public ValueList<IsoUUIDv4Identifier> SubUETR { get; init; } = [];
}
