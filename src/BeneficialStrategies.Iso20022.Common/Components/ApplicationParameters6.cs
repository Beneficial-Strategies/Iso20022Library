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
[IsoId("_y1j6cbAFEeah1_v59tW6Rg")]
[DisplayName("Application Parameters")]
public record ApplicationParameters6
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_zA0IMbAFEeah1_v59tW6Rg")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_zA0IM7AFEeah1_v59tW6Rg")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_zA0INbAFEeah1_v59tW6Rg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_zA0IN7AFEeah1_v59tW6Rg")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public SimpleValueList<IsoMax100KBinary> Parameters { get; init; } = [];

    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_zA0IObAFEeah1_v59tW6Rg")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType10? EncryptedParameters { get; init; }
}
