// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Management Plan12.
/// </summary>
[IsoId("_nQ-48ZRNEe6mHLZGMDWxvg")]
[DisplayName("Management Plan12")]
public record ManagementPlan12
{
    /// <summary>
    /// Data Set.
    /// </summary>
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required TerminalManagementDataSet33 DataSet { get; init; }

    /// <summary>
    /// POI Identification.
    /// </summary>
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification176? POIIdentification { get; init; }

    /// <summary>
    /// Terminal Manager Identification.
    /// </summary>
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }
}
