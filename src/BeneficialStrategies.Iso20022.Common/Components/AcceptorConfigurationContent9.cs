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
[IsoId("_No_w0QufEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent9
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_NzqvwQufEeqw5uEXxQ9H4g")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_NzqvwwufEeqw5uEXxQ9H4g")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public ValueList<TMSProtocolParameters5> TMSProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_NzqvxQufEeqw5uEXxQ9H4g")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public ValueList<AcquirerProtocolParameters13> AcquirerProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_NzqvxwufEeqw5uEXxQ9H4g")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public ValueList<MerchantConfigurationParameters5> MerchantParameters { get; init; } = [];

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_NzqvyQufEeqw5uEXxQ9H4g")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public ValueList<PaymentTerminalParameters7> TerminalParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_NzqvywufEeqw5uEXxQ9H4g")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ValueList<ApplicationParameters9> ApplicationParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_NzqvzQufEeqw5uEXxQ9H4g")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public ValueList<HostCommunicationParameter6> HostCommunicationParameters { get; init; } = [];

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_NzqvzwufEeqw5uEXxQ9H4g")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public ValueList<SecurityParameters12> SecurityParameters { get; init; } = [];

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_Nzqv0QufEeqw5uEXxQ9H4g")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public ValueList<SaleToPOIProtocolParameter1> SaleToPOIParameters { get; init; } = [];

    /// <summary>
    /// Group of software packages to transfer to a group of POIComponent of the POI System.
    /// </summary>
    [IsoId("_np21MAugEeqw5uEXxQ9H4g")]
    [DisplayName("Terminal Package")]
    [IsoXmlTag("TermnlPackg")]
    public ValueList<TerminalPackageType1> TerminalPackage { get; init; } = [];
}
