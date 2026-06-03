// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a sale system.
/// </summary>
[IsoId("_nn_tcKAFEfC4Q_xhaK1hdQ")]
[DisplayName("Sale To POI Protocol Parameter4")]
public record SaleToPOIProtocolParameter4
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_npneFaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_npneG6AFEfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public Organisation26? MerchantIdentification { get; init; }

    /// <summary>
    /// Version of the parameters.
    /// </summary>
    [IsoId("_npneIaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    [IsoId("_npneJ6AFEfC4Q_xhaK1hdQ")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Uniquely identifies the protocol version to use when using these parameters.
    /// </summary>
    [IsoId("_7PGP4KAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    public IsoMax8Text? ProtocolVersion { get; init; }

    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    [IsoId("_npneLaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Merchant POI Identification")]
    [IsoXmlTag("MrchntPOIId")]
    public IsoMax35Text? MerchantPOIIdentification { get; init; }

    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    [IsoId("_npneM6AFEfC4Q_xhaK1hdQ")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identify a message that a Sale system could send to the POI system.
    /// </summary>
    [IsoId("_npneOaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Allowed Sale Message")]
    [IsoXmlTag("AllwdSaleMsg")]
    public SimpleValueList<RetailerMessage1Code> AllowedSaleMessage { get; init; } = [];

    /// <summary>
    /// Identify a message that a POI system could send to the Sale system.
    /// </summary>
    [IsoId("_npneO6AFEfC4Q_xhaK1hdQ")]
    [DisplayName("Allowed POI Message")]
    [IsoXmlTag("AllwdPOIMsg")]
    public SimpleValueList<RetailerMessage1Code> AllowedPOIMessage { get; init; } = [];

    /// <summary>
    /// Identify a service that a POI system could support to the Sale system.
    /// </summary>
    [IsoId("_npnePaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Allowed POI Service")]
    [IsoXmlTag("AllwdPOISvc")]
    public SimpleValueList<RetailerService2Code> AllowedPOIService { get; init; } = [];

    /// <summary>
    /// Identify a device request that a Sale system could ask to the POI system.
    /// </summary>
    [IsoId("_npneP6AFEfC4Q_xhaK1hdQ")]
    [DisplayName("Allowed Sale Device")]
    [IsoXmlTag("AllwdSaleDvc")]
    public SimpleValueList<RetailerService8Code> AllowedSaleDevice { get; init; } = [];

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_npneQaAFEfC4Q_xhaK1hdQ")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    public SimpleValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];
}
