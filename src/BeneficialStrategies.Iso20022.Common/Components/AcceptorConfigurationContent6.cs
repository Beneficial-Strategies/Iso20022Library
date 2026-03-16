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
[IsoId("_CyJ6AbAGEeah1_v59tW6Rg")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent6
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_C9LeQbAGEeah1_v59tW6Rg")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_C9LeQ7AGEeah1_v59tW6Rg")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public TMSProtocolParameters2? TMSProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_C9LeRbAGEeah1_v59tW6Rg")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters10? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_C9LeR7AGEeah1_v59tW6Rg")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public MerchantConfigurationParameters3? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_C9LeSbAGEeah1_v59tW6Rg")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters4? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_C9LeS7AGEeah1_v59tW6Rg")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters6? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_C9MFUbAGEeah1_v59tW6Rg")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter4? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_C9MFU7AGEeah1_v59tW6Rg")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters6? SecurityParameters { get; init; }
}
