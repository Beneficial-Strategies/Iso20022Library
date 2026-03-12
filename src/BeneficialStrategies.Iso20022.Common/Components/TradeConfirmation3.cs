// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies time and type of contract confirmation.
/// </summary>
[IsoId("_4dfWIQFXEeaDfK-zDSyB6A")]
[DisplayName("Trade Confirmation")]
public partial record TradeConfirmation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the contract was confirmed electronically or non-electronically.
    /// </summary>
    [IsoId("_41eYUQFXEeaDfK-zDSyB6A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TradeConfirmationType1Code? Type { get; init; } 
    
    /// <summary>
    /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
    /// </summary>
    [IsoId("_41eYUwFXEeaDfK-zDSyB6A")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TimeStamp { get; init; } 
    
    
    #nullable disable
    
}
