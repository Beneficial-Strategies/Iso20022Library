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
[IsoId("_yOk-QVEIEeyApZmLzm74zA")]
[DisplayName("Acceptor Configuration Data Set")]
public record AcceptorConfigurationDataSet3
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_yVVGgVEIEeyApZmLzm74zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification9 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_yVVGg1EIEeyApZmLzm74zA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Indication of the last sequence in case of split messages.
    /// </summary>
    [IsoId("_yVVGhVEIEeyApZmLzm74zA")]
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LastSequence { get; init; }

    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_yVVGh1EIEeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification176? POIIdentification { get; init; }

    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_yVVGiVEIEeyApZmLzm74zA")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_yVVGi1EIEeyApZmLzm74zA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent11 Content { get; init; }
}
