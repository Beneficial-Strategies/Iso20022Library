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
[IsoId("_8pTf0VFMEeyApZmLzm74zA")]
[DisplayName("Sale To POI Protocol Parameter")]
public record SaleToPOIProtocolParameter2
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_8vwtIVFMEeyApZmLzm74zA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_8vwtI1FMEeyApZmLzm74zA")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public Organisation26? MerchantIdentification { get; init; }

    /// <summary>
    /// Version of the parameters.
    /// </summary>
    [IsoId("_8vwtJVFMEeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    [IsoId("_8vwtJ1FMEeyApZmLzm74zA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    [IsoId("_8vwtKVFMEeyApZmLzm74zA")]
    [DisplayName("Merchant POI Identification")]
    [IsoXmlTag("MrchntPOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantPOIIdentification { get; init; }

    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    [IsoId("_8vwtK1FMEeyApZmLzm74zA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_vrXpwVFMEeyApZmLzm74zA")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    public SimpleValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];
}
