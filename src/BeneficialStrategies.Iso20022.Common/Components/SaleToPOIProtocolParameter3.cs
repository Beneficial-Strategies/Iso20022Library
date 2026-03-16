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
[IsoId("_tmvvQXIVEe2OqYulmHWukQ")]
[DisplayName("Sale To POI Protocol Parameter")]
public record SaleToPOIProtocolParameter3
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_ttnzUXIVEe2OqYulmHWukQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_ttnzU3IVEe2OqYulmHWukQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public Organisation26? MerchantIdentification { get; init; }

    /// <summary>
    /// Version of the parameters.
    /// </summary>
    [IsoId("_ttnzVXIVEe2OqYulmHWukQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    [IsoId("_ttnzV3IVEe2OqYulmHWukQ")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    [IsoId("_ttnzWXIVEe2OqYulmHWukQ")]
    [DisplayName("Merchant POI Identification")]
    [IsoXmlTag("MrchntPOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantPOIIdentification { get; init; }

    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    [IsoId("_ttnzW3IVEe2OqYulmHWukQ")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identify a message that a Sale system could send to the POI system.
    /// </summary>
    [IsoId("_3C5rMHIWEe2OqYulmHWukQ")]
    [DisplayName("Allowed Sale Message")]
    [IsoXmlTag("AllwdSaleMsg")]
    public RetailerMessage1Code? AllowedSaleMessage { get; init; }

    /// <summary>
    /// Identify a message that a POI system could send to the Sale system.
    /// </summary>
    [IsoId("_js7fkHIXEe2OqYulmHWukQ")]
    [DisplayName("Allowed POI Message")]
    [IsoXmlTag("AllwdPOIMsg")]
    public RetailerMessage1Code? AllowedPOIMessage { get; init; }

    /// <summary>
    /// Identify a service that a POI system could support to the Sale system.
    /// </summary>
    [IsoId("_RC-scHIYEe2OqYulmHWukQ")]
    [DisplayName("Allowed POI Service")]
    [IsoXmlTag("AllwdPOISvc")]
    public RetailerService2Code? AllowedPOIService { get; init; }

    /// <summary>
    /// Identify a device request that a Sale system could ask to the POI system.
    /// </summary>
    [IsoId("__D-60HIYEe2OqYulmHWukQ")]
    [DisplayName("Allowed Sale Device")]
    [IsoXmlTag("AllwdSaleDvc")]
    public RetailerService8Code? AllowedSaleDevice { get; init; }

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_ttnzXXIVEe2OqYulmHWukQ")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ExternallyTypeSupported { get; init; }
}
