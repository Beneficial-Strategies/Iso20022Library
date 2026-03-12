// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the close links as defined in the collateral reference data.
/// </summary>
[IsoId("_jAkKE-5NEeCisYr99QEiWA_1304238767")]
[DisplayName("Close Link")]
public partial record CloseLink1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_jAkKFO5NEeCisYr99QEiWA_358771106")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the party for which the close link is defined.
    /// </summary>
    [IsoId("_jAtUAO5NEeCisYr99QEiWA_-750399753")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification1Choice_ PartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
