// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_qwdTMTAUEeOKib24wnHaFg")]
[DisplayName("Charges Details")]
public partial record ChargesDetails4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    [IsoId("_vR6FIDAUEeOKib24wnHaFg")]
    [DisplayName("Charges Type")]
    [IsoXmlTag("ChrgsTp")]
    public required ChargesType1Choice_ ChargesType { get; init; } 
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_rMz4BzAUEeOKib24wnHaFg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
