// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service Provider Parameters4.
/// </summary>
[IsoId("_KiXH8Z-UEe-nbM0aSPcoiQ")]
[DisplayName("Service Provider Parameters4")]
public record ServiceProviderParameters4
{
    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Application Identification.
    /// </summary>
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public ValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    /// <summary>
    /// Host.
    /// </summary>
    [DisplayName("Host")]
    [IsoXmlTag("Hst")]
    public ValueList<AcquirerHostConfiguration10> Host { get; init; } = [];

    /// <summary>
    /// Non Financial Action Supported.
    /// </summary>
    [DisplayName("Non Financial Action Supported")]
    [IsoXmlTag("NonFinActnSpprtd")]
    public ValueList<NonFinancialRequestType2Code> NonFinancialActionSupported { get; init; } = [];

    /// <summary>
    /// Service Provider Identification.
    /// </summary>
    [DisplayName("Service Provider Identification")]
    [IsoXmlTag("SvcPrvdrId")]
    public ValueList<GenericIdentification176> ServiceProviderIdentification { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }
}
