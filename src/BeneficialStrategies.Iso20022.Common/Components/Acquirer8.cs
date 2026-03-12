// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Institution in charge of managing the ATM.
/// </summary>
[IsoId("_zpnMMYp1EeS3NqNpgnMh2w")]
[DisplayName("Acquirer")]
public partial record Acquirer8
{
    #nullable enable
    
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_z3nL8Yp1EeS3NqNpgnMh2w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Software version of the application.
    /// </summary>
    [IsoId("_z3nL84p1EeS3NqNpgnMh2w")]
    [DisplayName("Application Version")]
    [IsoXmlTag("ApplVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ApplicationVersion { get; init; } 
    
    
    #nullable disable
    
}
