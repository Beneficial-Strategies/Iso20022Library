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
[IsoId("_VMUz4S1sEeuZtpnZJ4v-5Q")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent10
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_Va-68S1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_Va-68y1sEeuZtpnZJ4v-5Q")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public TMSProtocolParameters5? TMSProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_Va-69S1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters14? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    [IsoId("_ZBVdIDAKEeugIJ3Gvoevmg")]
    [DisplayName("Service Provider Parameters")]
    [IsoXmlTag("SvcPrvdrParams")]
    public ServiceProviderParameters1? ServiceProviderParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_Va-69y1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public MerchantConfigurationParameters6? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_Va-6-S1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters8? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_Va-6-y1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters10? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_Va-6_S1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter6? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_Va-6_y1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters13? SecurityParameters { get; init; }

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_Va-7AS1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public SaleToPOIProtocolParameter1? SaleToPOIParameters { get; init; }

    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_Va-7Ay1sEeuZtpnZJ4v-5Q")]
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public TerminalPackageType2? TerminalPackage { get; init; }
}
