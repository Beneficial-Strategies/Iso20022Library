// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details the date and reason for a non working day.
/// </summary>
[IsoId("_FHAXAGxNEeWD9e8QDBgUOw")]
[DisplayName("Securities Non Trading Day")]
public partial record SecuritiesNonTradingDay1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_C4Fo0b7VEeW_FPJ0tzugkw")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Non-working date.
    /// </summary>
    [IsoId("_NBJjEGxNEeWD9e8QDBgUOw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    /// <summary>
    /// Reason code for the non-working day.
    /// </summary>
    [IsoId("_jdWqYGxNEeWD9e8QDBgUOw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public NonTradingDayReason1Code? Reason { get; init; } 
    
    
    #nullable disable
    
}
