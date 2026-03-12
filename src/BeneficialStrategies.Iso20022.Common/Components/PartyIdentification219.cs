// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_aF_Eo1VCEembSPFgeLJ9eg")]
[DisplayName("Party Identification")]
public partial record PartyIdentification219
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_aF_EpVVCEembSPFgeLJ9eg")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName2 NameAndAddress { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_aF_EpFVCEembSPFgeLJ9eg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification195Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identifies the contact person by its name, given name and address.
    /// </summary>
    [IsoId("_SlZLkVVDEembSPFgeLJ9eg")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; } 
    
    
    #nullable disable
    
}
