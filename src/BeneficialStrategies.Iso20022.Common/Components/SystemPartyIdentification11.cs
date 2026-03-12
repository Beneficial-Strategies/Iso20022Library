// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a party within a system.
/// </summary>
[IsoId("_A3a-4TpxEemk2e6qGBk8IQ")]
[DisplayName("System Party Identification")]
public partial record SystemPartyIdentification11
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_FdkqoDpxEemk2e6qGBk8IQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_BCmUITpxEemk2e6qGBk8IQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; } 
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_BCmUIzpxEemk2e6qGBk8IQ")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
