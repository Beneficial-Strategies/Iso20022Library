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
[IsoId("_76B1cQvbEeK9Xewg3qiFQA")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent2
{
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_8LlfgQvbEeK9Xewg3qiFQA")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters3? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_8LlfhQvbEeK9Xewg3qiFQA")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_SrV3YCmnEeKIjpr--01h3Q")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_8LlfiQvbEeK9Xewg3qiFQA")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters2? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    [IsoId("_8LlfjQvbEeK9Xewg3qiFQA")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter2? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_o360ACm3EeKIjpr--01h3Q")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters1? SecurityParameters { get; init; }
}
