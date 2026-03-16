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
[IsoId("_wWoDgdqHEeearpaEPXv9UA")]
[DisplayName("Terminal Management Data Set")]
public record TerminalManagementDataSet23
{
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_wfazIdqHEeearpaEPXv9UA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification7 Identification { get; init; }

    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_wfazI9qHEeearpaEPXv9UA")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; }

    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_wfazJdqHEeearpaEPXv9UA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification71? POIIdentification { get; init; }

    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_wfazJ9qHEeearpaEPXv9UA")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; }

    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_wfazKdqHEeearpaEPXv9UA")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent7 Content { get; init; }
}
