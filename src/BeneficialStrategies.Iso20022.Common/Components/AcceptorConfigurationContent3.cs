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
[IsoId("_k7tqETZ6EeOP_KvUKe29ng")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent3
{
    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_lNuAETZ6EeOP_KvUKe29ng")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters6? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_lNuAEzZ6EeOP_KvUKe29ng")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_lNuAFTZ6EeOP_KvUKe29ng")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters1? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_lNuAFzZ6EeOP_KvUKe29ng")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters3? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host.
    /// </summary>
    [IsoId("_lNuAGTZ6EeOP_KvUKe29ng")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter2? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_lNuAGzZ6EeOP_KvUKe29ng")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters2? SecurityParameters { get; init; }
}
