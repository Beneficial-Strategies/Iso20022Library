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
[IsoId("_ClzOYWpbEeS4r8z7dKyh1g")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent4
{
    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_Q5IxIGpbEeS4r8z7dKyh1g")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public TMSProtocolParameters1? TMSProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_CzEOUWpbEeS4r8z7dKyh1g")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public AcquirerProtocolParameters7? AcquirerProtocolParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_CzEOU2pbEeS4r8z7dKyh1g")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public MerchantConfigurationParameters1? MerchantParameters { get; init; }

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_CzEOVWpbEeS4r8z7dKyh1g")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public PaymentTerminalParameters2? TerminalParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_CzEOV2pbEeS4r8z7dKyh1g")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ApplicationParameters4? ApplicationParameters { get; init; }

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_CzEOWWpbEeS4r8z7dKyh1g")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public HostCommunicationParameter3? HostCommunicationParameters { get; init; }

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_CzEOW2pbEeS4r8z7dKyh1g")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public SecurityParameters3? SecurityParameters { get; init; }
}
