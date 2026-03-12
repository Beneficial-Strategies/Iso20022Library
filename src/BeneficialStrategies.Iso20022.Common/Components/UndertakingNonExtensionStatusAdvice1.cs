// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a non-extension advice.
/// </summary>
[IsoId("_-GdIZ3ltEeG7BsjMvd1mEw_177542708")]
[DisplayName("Undertaking Non Extension Status Advice")]
public partial record UndertakingNonExtensionStatusAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the notifying party.
    /// </summary>
    [IsoId("_-GdIaHltEeG7BsjMvd1mEw_313669436")]
    [DisplayName("Notifying Party")]
    [IsoXmlTag("NtifngPty")]
    public required PartyIdentification43 NotifyingParty { get; init; } 
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Gm5YHltEeG7BsjMvd1mEw_1749872346")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking7 UndertakingIdentification { get; init; } 
    
    
    #nullable disable
    
}
