// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the system and its currency.
/// </summary>
[IsoId("_HcKF0Im6Eeipw6hHPgB4Sw")]
[DisplayName("System And Currency")]
public partial record SystemAndCurrency1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the system, as assigned by the system administrator.
    /// </summary>
    [IsoId("_dWTB4om6Eeipw6hHPgB4Sw")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public required SystemIdentification2Choice_ SystemIdentification { get; init; } 
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_dWTB44m6Eeipw6hHPgB4Sw")]
    [DisplayName("System Currency")]
    [IsoXmlTag("SysCcy")]
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    
    
    #nullable disable
    
}
