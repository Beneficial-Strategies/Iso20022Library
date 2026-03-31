// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the status report of a point of interaction (POI).
/// </summary>
[IsoId("_JmPTASi1Eeurkfo6MpvKDA")]
[DisplayName("Status Report Data Set Request")]
public record StatusReportDataSetRequest2
{
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_J0H-ASi1Eeurkfo6MpvKDA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification8 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_J0H-Ayi1Eeurkfo6MpvKDA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_NEEKITAbEeugIJ3Gvoevmg")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Content of the status report.
    /// </summary>
    [IsoId("_J0H-BSi1Eeurkfo6MpvKDA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent10 Content { get; init; }
}
