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
[IsoId("_92NJMWpOEeSR-ZWLvO-1dg")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet14
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_-DA2IWpOEeSR-ZWLvO-1dg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification4 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_-DA2I2pOEeSR-ZWLvO-1dg")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_-DA2JWpOEeSR-ZWLvO-1dg")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent4 Content { get; init; }
}
