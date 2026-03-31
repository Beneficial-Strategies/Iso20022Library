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
[IsoId("_D2hlATWBEeODSIIQsYYKhw")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet10
{
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_EG48QTWBEeODSIIQsYYKhw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification3 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_EG48QzWBEeODSIIQsYYKhw")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_EG48RTWBEeODSIIQsYYKhw")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent3? Content { get; init; }
}
