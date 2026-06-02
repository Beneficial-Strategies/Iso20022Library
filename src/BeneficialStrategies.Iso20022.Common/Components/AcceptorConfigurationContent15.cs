// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the acceptor configuration.
/// </summary>
[IsoId("_qRsFYbZzEfCUZfsQO4rYeA")]
[DisplayName("Acceptor Configuration Content15")]
public record AcceptorConfigurationContent15
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_qSy4p7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_qSy4rbZzEfCUZfsQO4rYeA")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public ValueList<TMSProtocolParameters8> TMSProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_qSy4s7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public ValueList<AcquirerProtocolParameters18> AcquirerProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    [IsoId("_qSy4ubZzEfCUZfsQO4rYeA")]
    [DisplayName("Service Provider Parameters")]
    [IsoXmlTag("SvcPrvdrParams")]
    public ValueList<ServiceProviderParameters5> ServiceProviderParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_qSy4v7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public ValueList<MerchantConfigurationParameters6> MerchantParameters { get; init; } = [];

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_qSy4xbZzEfCUZfsQO4rYeA")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public ValueList<PaymentTerminalParameters8> TerminalParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_qSy4y7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ValueList<ApplicationParameters13> ApplicationParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_qSy40bZzEfCUZfsQO4rYeA")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public ValueList<HostCommunicationParameter8> HostCommunicationParameters { get; init; } = [];

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_qSy417ZzEfCUZfsQO4rYeA")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public ValueList<SecurityParameters17> SecurityParameters { get; init; } = [];

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_qSy43bZzEfCUZfsQO4rYeA")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public ValueList<SaleToPOIProtocolParameter4> SaleToPOIParameters { get; init; } = [];

    /// <summary>
    /// Group of software packages to transfer to a group of POI.
    /// </summary>
    [IsoId("_qSy447ZzEfCUZfsQO4rYeA")]
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public ValueList<TerminalPackageType5> TerminalPackage { get; init; } = [];
}
