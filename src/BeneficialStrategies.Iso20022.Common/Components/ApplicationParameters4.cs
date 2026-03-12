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
[IsoId("_LxhfoWpyEeSMqvBfBY1c9A")]
[DisplayName("Application Parameters")]
public partial record ApplicationParameters4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_L-MCoWpyEeSMqvBfBY1c9A")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_L-MCo2pyEeSMqvBfBY1c9A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_L-MCpWpyEeSMqvBfBY1c9A")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Parameters { get; init; } 
    
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_L-MCp2pyEeSMqvBfBY1c9A")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType10? EncryptedParameters { get; init; } 
    
    
    #nullable disable
    
}
