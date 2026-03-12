// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SGKyMeKNEeKM3LYZSgb7xw")]
[DisplayName("Pay In Schedule Items")]
public partial record PayInScheduleItems1
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount to be paid in.
    /// </summary>
    [IsoId("_SkklceKNEeKM3LYZSgb7xw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Time by which the amount must be paid in.
    /// </summary>
    [IsoId("_SkkldeKNEeKM3LYZSgb7xw")]
    [DisplayName("Deadline")]
    [IsoXmlTag("Ddln")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime Deadline { get; init; } 
    
    
    #nullable disable
    
}
