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
[IsoId("_wIUhkbZzEfCUZfsQO4rYeA")]
[DisplayName("Acceptor Configuration Data Set7")]
public record AcceptorConfigurationDataSet7
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_wJPHlbZzEfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification11 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_wJPHm7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_wJPHobZzEfCUZfsQO4rYeA")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_wJPHp7ZzEfCUZfsQO4rYeA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public ValueList<GenericIdentification176> POIIdentification { get; init; } = [];

    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_wJPHrbZzEfCUZfsQO4rYeA")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_wJPHs7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent15 Content { get; init; }
}
