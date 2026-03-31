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
[IsoId("_52vI0dXzEeia9rtBTv_9KA")]
[DisplayName("Acceptor Configuration Content")]
public record AcceptorConfigurationContent8
{
    /// <summary>
    /// True if the whole configuration related to the terminal manager has to be replaced by the configuration included in the message content.
    /// </summary>
    [IsoId("_6AvZYdXzEeia9rtBTv_9KA")]
    [DisplayName("Replace Configuration")]
    [IsoXmlTag("RplcCfgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplaceConfiguration { get; init; }

    /// <summary>
    /// Configuration parameters of the TMS protocol between a POI and a terminal manager.
    /// </summary>
    [IsoId("_6AvZY9XzEeia9rtBTv_9KA")]
    [DisplayName("TMS Protocol Parameters")]
    [IsoXmlTag("TMSPrtcolParams")]
    public ValueList<TMSProtocolParameters4> TMSProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to an acquirer protocol.
    /// </summary>
    [IsoId("_6AvZZdXzEeia9rtBTv_9KA")]
    [DisplayName("Acquirer Protocol Parameters")]
    [IsoXmlTag("AcqrrPrtcolParams")]
    public ValueList<AcquirerProtocolParameters12> AcquirerProtocolParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the merchant.
    /// </summary>
    [IsoId("_6AvZZ9XzEeia9rtBTv_9KA")]
    [DisplayName("Merchant Parameters")]
    [IsoXmlTag("MrchntParams")]
    public ValueList<MerchantConfigurationParameters4> MerchantParameters { get; init; } = [];

    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_6AvZadXzEeia9rtBTv_9KA")]
    [DisplayName("Terminal Parameters")]
    [IsoXmlTag("TermnlParams")]
    public ValueList<PaymentTerminalParameters6> TerminalParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to a payment application of the point of interaction.
    /// </summary>
    [IsoId("_6AvZa9XzEeia9rtBTv_9KA")]
    [DisplayName("Application Parameters")]
    [IsoXmlTag("ApplParams")]
    public ValueList<ApplicationParameters8> ApplicationParameters { get; init; } = [];

    /// <summary>
    /// Acceptor parameters dedicated to the communication with an acquirer host or a terminal manager host.
    /// </summary>
    [IsoId("_6AvZbdXzEeia9rtBTv_9KA")]
    [DisplayName("Host Communication Parameters")]
    [IsoXmlTag("HstComParams")]
    public ValueList<HostCommunicationParameter5> HostCommunicationParameters { get; init; } = [];

    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// </summary>
    [IsoId("_6AwAcdXzEeia9rtBTv_9KA")]
    [DisplayName("Security Parameters")]
    [IsoXmlTag("SctyParams")]
    public ValueList<SecurityParameters11> SecurityParameters { get; init; } = [];

    /// <summary>
    /// Parameters dedicated to protocols between a sale system and the POI.
    /// </summary>
    [IsoId("_6AwAc9XzEeia9rtBTv_9KA")]
    [DisplayName("Sale To POI Parameters")]
    [IsoXmlTag("SaleToPOIParams")]
    public ValueList<SaleToPOIProtocolParameter1> SaleToPOIParameters { get; init; } = [];
}
