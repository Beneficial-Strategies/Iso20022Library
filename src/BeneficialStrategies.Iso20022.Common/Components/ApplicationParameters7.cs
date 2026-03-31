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
[IsoId("_gCnL8dtXEee9e6xduATmQg")]
[DisplayName("Application Parameters")]
public record ApplicationParameters7
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_gLhQUdtXEee9e6xduATmQg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_gLhQU9tXEee9e6xduATmQg")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_gLhQVdtXEee9e6xduATmQg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_gLhQV9tXEee9e6xduATmQg")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public SimpleValueList<IsoMax100KBinary> Parameters { get; init; } = [];

    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_gLhQWdtXEee9e6xduATmQg")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType17? EncryptedParameters { get; init; }
}
