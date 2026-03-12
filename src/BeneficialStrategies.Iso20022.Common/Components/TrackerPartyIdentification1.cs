// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of a person or an organisation.
/// </summary>
[IsoId("_XaC4YfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Party Identification")]
public partial record TrackerPartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_XaC4a_WfEemtd4wHZYvFUQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TrackerParty1 Identification { get; init; } 
    
    
    #nullable disable
    
}
