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
[IsoId("_fidxgdX4Eeia9rtBTv_9KA")]
[DisplayName("Application Parameters")]
public record ApplicationParameters8
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_fsB9MdX4Eeia9rtBTv_9KA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_fsB9M9X4Eeia9rtBTv_9KA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_fsB9NdX4Eeia9rtBTv_9KA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; }

    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_FGrPMdX4Eeia9rtBTv_9KA")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_fsB9N9X4Eeia9rtBTv_9KA")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Parameters { get; init; }

    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_fsB9OdX4Eeia9rtBTv_9KA")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType17? EncryptedParameters { get; init; }
}
