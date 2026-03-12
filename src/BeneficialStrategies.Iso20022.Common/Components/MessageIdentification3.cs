// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
/// </summary>
[IsoId("_WH7lotp-Ed-ak6NoX_4Aeg_-778866904")]
[DisplayName("Message Identification")]
public partial record MessageIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the message.
    /// </summary>
    [IsoId("_WH7lo9p-Ed-ak6NoX_4Aeg_-778866872")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINMax16Text Identification { get; init; } 
    
    /// <summary>
    /// Date of creation of the message.
    /// </summary>
    [IsoId("_WH7lpNp-Ed-ak6NoX_4Aeg_-778866812")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
