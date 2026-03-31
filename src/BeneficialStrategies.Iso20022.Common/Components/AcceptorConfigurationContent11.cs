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
[IsoId("_UmbBQVFCEeyApZmLzm74zA")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent11
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_Us_jUVFCEeyApZmLzm74zA")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_Us_jU1FCEeyApZmLzm74zA")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public ValueList<TMSProtocolParameters6> TMSProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_Us_jVVFCEeyApZmLzm74zA")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public ValueList<AcquirerProtocolParameters15> AcquirerProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a service provider.
    /// </summary>
    [IsoId("_Us_jV1FCEeyApZmLzm74zA")]
    [DisplayName("Service Provider Parameters")]
    [IsoXmlTag("SvcPrvdrParams")]
    public ValueList<ServiceProviderParameters2> ServiceProviderParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_Us_jWVFCEeyApZmLzm74zA")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public ValueList<MerchantConfigurationParameters6> MerchantParameters { get; init; } = [];

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_Us_jW1FCEeyApZmLzm74zA")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public ValueList<PaymentTerminalParameters8> TerminalParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_Us_jXVFCEeyApZmLzm74zA")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ValueList<ApplicationParameters11> ApplicationParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_Us_jX1FCEeyApZmLzm74zA")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public ValueList<HostCommunicationParameter6> HostCommunicationParameters { get; init; } = [];

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_Us_jYVFCEeyApZmLzm74zA")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public ValueList<SecurityParameters14> SecurityParameters { get; init; } = [];

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_Us_jY1FCEeyApZmLzm74zA")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public ValueList<SaleToPOIProtocolParameter2> SaleToPOIParameters { get; init; } = [];

    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_Us_jZVFCEeyApZmLzm74zA")]
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public ValueList<TerminalPackageType3> TerminalPackage { get; init; } = [];
}
