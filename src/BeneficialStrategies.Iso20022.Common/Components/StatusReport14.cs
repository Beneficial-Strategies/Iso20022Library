// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status Report14.
/// </summary>
[IsoId("_uhMgIaE8Ee-MRKYsaX6JDg")]
[DisplayName("Status Report14")]
public record StatusReport14
{
    /// <summary>
    /// Data Set.
    /// </summary>
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required StatusReportDataSetRequest6 DataSet { get; init; }

    /// <summary>
    /// Initiating Trigger.
    /// </summary>
    [DisplayName("Initiating Trigger")]
    [IsoXmlTag("InitgTrggr")]
    public TriggerInformation2? InitiatingTrigger { get; init; }

    /// <summary>
    /// POI Identification.
    /// </summary>
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Terminal Manager Identification.
    /// </summary>
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }
}
