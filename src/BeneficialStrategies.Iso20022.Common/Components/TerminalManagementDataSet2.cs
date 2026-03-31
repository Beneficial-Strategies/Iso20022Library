// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the management plan of a point of interaction (POI).
/// </summary>
[IsoId("_K9WvJ31DEeCF8NjrBemJWQ_857793942")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet2
{
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_K9WvKH1DEeCF8NjrBemJWQ_302601640")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification2 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_K9f5EH1DEeCF8NjrBemJWQ_2098031265")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_K9f5EX1DEeCF8NjrBemJWQ_-1680843617")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent1? Content { get; init; }
}
