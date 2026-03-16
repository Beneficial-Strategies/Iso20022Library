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
[IsoId("_F5K64XIiEe299ZbWCkdR_w")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent12
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_GDPc4XIiEe299ZbWCkdR_w")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_GDPc43IiEe299ZbWCkdR_w")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public TMSProtocolParameters7? TMSProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_GDPc5XIiEe299ZbWCkdR_w")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters16? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    [IsoId("_GDPc53IiEe299ZbWCkdR_w")]
    [DisplayName("Service Provider Parameters")]
    [IsoXmlTag("SvcPrvdrParams")]
    public ServiceProviderParameters3? ServiceProviderParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_GDPc6XIiEe299ZbWCkdR_w")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public MerchantConfigurationParameters6? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_GDPc63IiEe299ZbWCkdR_w")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters8? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_GDQD8XIiEe299ZbWCkdR_w")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters12? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_GDQD83IiEe299ZbWCkdR_w")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter6? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_GDQD9XIiEe299ZbWCkdR_w")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters15? SecurityParameters { get; init; }

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_GDQD93IiEe299ZbWCkdR_w")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public SaleToPOIProtocolParameter3? SaleToPOIParameters { get; init; }

    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_GDQrAXIiEe299ZbWCkdR_w")]
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public TerminalPackageType4? TerminalPackage { get; init; }
}
