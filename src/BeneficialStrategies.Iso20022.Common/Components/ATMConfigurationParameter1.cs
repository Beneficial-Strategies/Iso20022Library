// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameter version of the ATM.
/// </summary>
[IsoId("_Mv--sIn9EeShMpas3885ww")]
[DisplayName("ATM Configuration Parameter")]
public partial record ATMConfigurationParameter1
{
    #nullable enable
    
    /// <summary>
    /// Type of the ATM configuration.
    /// </summary>
    [IsoId("_MrLhwIn-EeShMpas3885ww")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DataSetCategory7Code Type { get; init; } 
    
    /// <summary>
    /// Active version of the configuration.
    /// </summary>
    [IsoId("_TcxKUIn-EeShMpas3885ww")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Version { get; init; } 
    
    
    #nullable disable
    
}
