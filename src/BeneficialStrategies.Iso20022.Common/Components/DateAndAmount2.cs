// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and amount.
/// </summary>
[IsoId("_ByTSIU31EeiQHa-q1Uephw")]
[DisplayName("Date And Amount")]
public partial record DateAndAmount2
{
    #nullable enable
    
    /// <summary>
    /// Date on which the amount is declared or registered.
    /// </summary>
    [IsoId("_CB7CgU31EeiQHa-q1Uephw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Amount of money.
    /// </summary>
    [IsoId("_CB7Cg031EeiQHa-q1Uephw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
