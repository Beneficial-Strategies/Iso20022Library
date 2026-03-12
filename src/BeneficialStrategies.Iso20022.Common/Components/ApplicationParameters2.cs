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
[IsoId("_ynX-UQvbEeK9Xewg3qiFQA")]
[DisplayName("Application Parameters")]
public partial record ApplicationParameters2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_yzIiYQvbEeK9Xewg3qiFQA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_yzIiZQvbEeK9Xewg3qiFQA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text Version { get; init; } 
    
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_yzIiaQvbEeK9Xewg3qiFQA")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? Parameters { get; init; } 
    
    /// <summary>
    /// Sensitive parameters (sequence of Parameters including the enveloppes) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_yzIibQvbEeK9Xewg3qiFQA")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType5? EncryptedParameters { get; init; } 
    
    
    #nullable disable
    
}
