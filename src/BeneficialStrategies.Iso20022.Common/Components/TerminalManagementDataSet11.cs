// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
[IsoId("_qEJuETZ7EeOP_KvUKe29ng")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet11
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_qV0F0TZ7EeOP_KvUKe29ng")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification3 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_qV0F0zZ7EeOP_KvUKe29ng")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_qV0F1TZ7EeOP_KvUKe29ng")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent3 Content { get; init; }
}
