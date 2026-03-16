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
[IsoId("_oaQqsY32EeWRwov1g9WL_A")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet19
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_omxcsY32EeWRwov1g9WL_A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification6 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_omxcs432EeWRwov1g9WL_A")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_0ypuQI33EeWRwov1g9WL_A")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification71? POIIdentification { get; init; }

    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_rhj9YI33EeWRwov1g9WL_A")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_omxctY32EeWRwov1g9WL_A")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent5 Content { get; init; }
}
