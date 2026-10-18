// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Application Parameters13.
/// </summary>
[IsoId("_8uEKEZByEe6FLLjWp95ntQ")]
[DisplayName("Application Parameters13")]
public record ApplicationParameters13
{
    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Application Identification.
    /// </summary>
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public required Max35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public Max256Text? Version { get; init; }

    /// <summary>
    /// Parameter Format Identifier.
    /// </summary>
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    public Max8Text? ParameterFormatIdentifier { get; init; }

    /// <summary>
    /// Parameters Length.
    /// </summary>
    [DisplayName("Parameters Length")]
    [IsoXmlTag("ParamsLngth")]
    public PositiveNumber? ParametersLength { get; init; }

    /// <summary>
    /// Offset Start.
    /// </summary>
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    public PositiveNumber? OffsetStart { get; init; }

    /// <summary>
    /// Offset End.
    /// </summary>
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    public PositiveNumber? OffsetEnd { get; init; }

    /// <summary>
    /// Parameters.
    /// </summary>
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public ValueList<Max100KBinary> Parameters { get; init; } = [];

    /// <summary>
    /// Encrypted Parameters.
    /// </summary>
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType40? EncryptedParameters { get; init; }
}
