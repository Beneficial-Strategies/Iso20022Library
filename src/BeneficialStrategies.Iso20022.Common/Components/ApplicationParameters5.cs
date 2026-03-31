// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[IsoId("_AWZaEY3_EeWRwov1g9WL_A")]
[DisplayName("Application Parameters")]
public record ApplicationParameters5
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_JyCOEI3_EeWRwov1g9WL_A")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_AidgIY3_EeWRwov1g9WL_A")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_AidgI43_EeWRwov1g9WL_A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_AidgJY3_EeWRwov1g9WL_A")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public SimpleValueList<IsoMax100KBinary> Parameters { get; init; } = [];

    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_AidgJ43_EeWRwov1g9WL_A")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType10? EncryptedParameters { get; init; }
}
