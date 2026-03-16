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
[IsoId("_HaFgUSi8Eeurkfo6MpvKDA")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet30
{
    /// <summary>
    /// Identification of the data set containing the management plan.
    /// </summary>
    [IsoId("_HocscSi8Eeurkfo6MpvKDA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification8 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_Hocscyi8Eeurkfo6MpvKDA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_GR8vYDAWEeugIJ3Gvoevmg")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Content of the management plan.
    /// </summary>
    [IsoId("_HocsdSi8Eeurkfo6MpvKDA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public ManagementPlanContent9? Content { get; init; }
}
