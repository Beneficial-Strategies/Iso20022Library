// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Configuration Content13.
/// </summary>
[IsoId("_mXeR4ZI7Ee6RsYhlPIxpVw")]
[DisplayName("Acceptor Configuration Content13")]
public record AcceptorConfigurationContent13
{
    /// <summary>
    /// Acquirer Protocol Parameters.
    /// </summary>
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public ValueList<AcquirerProtocolParameters16> AcquirerProtocolParameters { get; init; } = [];

    /// <summary>
    /// Application Parameters.
    /// </summary>
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ValueList<ApplicationParameters13> ApplicationParameters { get; init; } = [];

    /// <summary>
    /// Host Communication Parameters.
    /// </summary>
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public ValueList<HostCommunicationParameter6> HostCommunicationParameters { get; init; } = [];

    /// <summary>
    /// Merchant Parameters.
    /// </summary>
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public ValueList<MerchantConfigurationParameters6> MerchantParameters { get; init; } = [];

    /// <summary>
    /// Replace Configuration.
    /// </summary>
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Sale To POI Parameters.
    /// </summary>
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public ValueList<SaleToPOIProtocolParameter3> SaleToPOIParameters { get; init; } = [];

    /// <summary>
    /// Security Parameters.
    /// </summary>
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public ValueList<SecurityParameters16> SecurityParameters { get; init; } = [];

    /// <summary>
    /// Service Provider Parameters.
    /// </summary>
    [DisplayName("Service Provider Parameters")]
    [IsoXmlTag("SvcPrvdrParams")]
    public ValueList<ServiceProviderParameters3> ServiceProviderParameters { get; init; } = [];

    /// <summary>
    /// Terminal Package.
    /// </summary>
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public ValueList<TerminalPackageType5> TerminalPackage { get; init; } = [];

    /// <summary>
    /// Terminal Parameters.
    /// </summary>
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public ValueList<PaymentTerminalParameters8> TerminalParameters { get; init; } = [];

    /// <summary>
    /// TMS Protocol Parameters.
    /// </summary>
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public ValueList<TMSProtocolParameters7> TMSProtocolParameters { get; init; } = [];
}
