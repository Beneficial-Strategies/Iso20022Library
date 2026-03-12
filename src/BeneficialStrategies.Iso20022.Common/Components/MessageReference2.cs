// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message reference of relevance to the present message.
/// </summary>
[IsoId("_q3e2gQ1ZEeiuP6VVHwBG8A")]
[DisplayName("Message Reference")]
public partial record MessageReference2
{
    #nullable enable
    
    /// <summary>
    /// Business reference of the present message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    [IsoId("_rOMtYQ1ZEeiuP6VVHwBG8A")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    
    #nullable disable
    
}
