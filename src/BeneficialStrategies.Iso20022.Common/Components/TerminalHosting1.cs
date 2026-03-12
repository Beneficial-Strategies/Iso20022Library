// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity hosting the ATM terminal.
/// </summary>
[IsoId("_gJenIIn2EeS9F4Qrq_eaVA")]
[DisplayName("Terminal Hosting")]
public partial record TerminalHosting1
{
    #nullable enable
    
    /// <summary>
    /// Type of ATM terminal hosting.
    /// </summary>
    [IsoId("_uyiiQIn2EeS9F4Qrq_eaVA")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public TransactionEnvironment3Code? Category { get; init; } 
    
    /// <summary>
    /// Identify the entity hosting the ATM.
    /// </summary>
    [IsoId("_8G24AIn2EeS9F4Qrq_eaVA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    
    #nullable disable
    
}
