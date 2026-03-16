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
[IsoId("_CqUosY34EeWRwov1g9WL_A")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent5
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_RZHYYI34EeWRwov1g9WL_A")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_C1WM8Y34EeWRwov1g9WL_A")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public TMSProtocolParameters2? TMSProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_C1WM8434EeWRwov1g9WL_A")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters9? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_C1WM9Y34EeWRwov1g9WL_A")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public MerchantConfigurationParameters2? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_C1WM9434EeWRwov1g9WL_A")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters3? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_C1WM-Y34EeWRwov1g9WL_A")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters5? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_C1WM-434EeWRwov1g9WL_A")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter4? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_C1WM_Y34EeWRwov1g9WL_A")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters6? SecurityParameters { get; init; }
}
