// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_g-WN8IHEEeSY3ulMDfpmvA")]
[DisplayName("Party Identification")]
public partial record PartyIdentification78
{
    #nullable enable
    
    /// <summary>
    /// Indicate the source of the party.
    /// </summary>
    [IsoId("_6TOykIHEEeSY3ulMDfpmvA")]
    [DisplayName("Party Source")]
    [IsoXmlTag("PtySrc")]
    public IdentificationType1Code? PartySource { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Hr2ZgIHFEeSY3ulMDfpmvA")]
    [DisplayName("Trade Party Identification")]
    [IsoXmlTag("TradPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradePartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
