// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a correction has occurred.
/// </summary>
[IsoId("_H32DoJb3Eeuc6pwKtqbEVQ")]
[DisplayName("Correction Identification")]
public partial record CorrectionIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the message contains an updated version of a message that was previously sent.
    /// </summary>
    [IsoId("_6niOsJb3Eeuc6pwKtqbEVQ")]
    [DisplayName("Indicator")]
    [IsoXmlTag("Ind")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Indicator { get; init; } 
    
    /// <summary>
    /// Contains the date of the update.
    /// </summary>
    [IsoId("_ObTUIJb4Eeuc6pwKtqbEVQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Contains the time of the update.
    /// </summary>
    [IsoId("_Tm2zAJb4Eeuc6pwKtqbEVQ")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    
    #nullable disable
    
}
