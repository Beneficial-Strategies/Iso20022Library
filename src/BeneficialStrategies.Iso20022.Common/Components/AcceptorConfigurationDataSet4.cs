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
[IsoId("_aNbsAXInEe299ZbWCkdR_w")]
[DisplayName("Acceptor Configuration Data Set")]
public record AcceptorConfigurationDataSet4
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_aUNpcXInEe299ZbWCkdR_w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification10 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_aUNpc3InEe299ZbWCkdR_w")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_aUNpdXInEe299ZbWCkdR_w")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_aUNpd3InEe299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public ValueList<GenericIdentification176> POIIdentification { get; init; } = [];

    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_aUNpeXInEe299ZbWCkdR_w")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_aUNpe3InEe299ZbWCkdR_w")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent12 Content { get; init; }
}
