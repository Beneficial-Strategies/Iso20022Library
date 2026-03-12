// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[IsoId("_FjIo0S8qEeu125Ip9zFcsQ")]
[DisplayName("Application Parameters")]
public partial record ApplicationParameters10
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_FwAnMS8qEeu125Ip9zFcsQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_FwAnMy8qEeu125Ip9zFcsQ")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_FwAnNS8qEeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_FwAnNy8qEeu125Ip9zFcsQ")]
    [DisplayName("Parameter Format Identifier")]
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    
    /// <summary>
    /// Full length of parameters.
    /// </summary>
    [IsoId("_xQFF0zAaEeugIJ3Gvoevmg")]
    [DisplayName("Parameters Length")]
    [IsoXmlTag("ParamsLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? ParametersLength { get; init; } 
    
    /// <summary>
    /// Place of this  Block, beginning with 0, in the full parameters.
    /// </summary>
    [IsoId("_xQFF1DAaEeugIJ3Gvoevmg")]
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetStart { get; init; } 
    
    /// <summary>
    /// Following place of this Block in the full parameters.
    /// </summary>
    [IsoId("_xQFF1TAaEeugIJ3Gvoevmg")]
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_FwAnOS8qEeu125Ip9zFcsQ")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Parameters { get; init; } 
    
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_FwAnOy8qEeu125Ip9zFcsQ")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType28? EncryptedParameters { get; init; } 
    
    
    #nullable disable
    
}
