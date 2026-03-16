// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The Custom Report message can be initiated by any party and received by any party (acquirer, agent, issuer or other party) connected to a network.
/// This message provides the capability to convey customized reports that are defined by bi-lateral agreement.
/// </summary>
[IsoId("_6o4MAMlLEeuJ35KoBRZFOg")]
[DisplayName("Custom Report")]
public record CustomReport1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_zbY1IclMEeuJ35KoBRZFOg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment33 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_FDkz0clNEeuJ35KoBRZFOg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Specifies the attributes of a report and its content.
    /// </summary>
    [IsoId("_7fW2IMlNEeuJ35KoBRZFOg")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public required ReportData6 Report { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Iw3vgclOEeuJ35KoBRZFOg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
