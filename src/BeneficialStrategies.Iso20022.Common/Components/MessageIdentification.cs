// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
/// </summary>
[IsoId("_Q6l-Cdp-Ed-ak6NoX_4Aeg_1451391033")]
[DisplayName("Message Identification")]
public partial record MessageIdentification
{
    #nullable enable
    
    /// <summary>
    /// String of characters that uniquely identifies a message.
    /// </summary>
    [IsoId("_Q6vvANp-Ed-ak6NoX_4Aeg_1505878618")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
