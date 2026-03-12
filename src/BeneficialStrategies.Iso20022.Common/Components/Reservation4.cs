// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liquidity set aside by the account owner for specific purposes.
/// </summary>
[IsoId("_hsth0ZliEeeE1Ya-LgRsuQ")]
[DisplayName("Reservation")]
public partial record Reservation4
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the reservation becomes effective.
    /// </summary>
    [IsoId("_h1AiM5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public DateAndDateTime2Choice_? StartDateTime { get; init; } 
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_h1AiNZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; } 
    
    
    #nullable disable
    
}
