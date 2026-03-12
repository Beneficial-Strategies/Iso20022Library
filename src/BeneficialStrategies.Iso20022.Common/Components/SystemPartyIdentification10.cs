// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification to unambiguously identify the party within the system.
/// </summary>
[IsoId("_90Gi0b10Eeiut6mmSKzDFQ")]
[DisplayName("System Party Identification")]
public partial record SystemPartyIdentification10
{
    #nullable enable
    
    /// <summary>
    /// Starting date from which the identification is valid.
    /// </summary>
    [IsoId("_-AKB0b10Eeiut6mmSKzDFQ")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous way to identify a system party.
    /// </summary>
    [IsoId("_-AKB0710Eeiut6mmSKzDFQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification136? Identification { get; init; } 
    
    
    #nullable disable
    
}
