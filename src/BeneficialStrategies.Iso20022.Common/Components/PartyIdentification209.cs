// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party
/// </summary>
[IsoId("_rY32KPcmEeiW-auGnDPZIw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification209
{
    #nullable enable
    
    /// <summary>
    /// Name of the party.
    /// </summary>
    [IsoId("_rY32KfcmEeiW-auGnDPZIw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Contains identification details.
    /// </summary>
    [IsoId("_rY32LfcmEeiW-auGnDPZIw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification197? Identification { get; init; } 
    
    /// <summary>
    /// Address of the customer.
    /// </summary>
    [IsoId("_rY32L_cmEeiW-auGnDPZIw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; } 
    
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_rY32KvcmEeiW-auGnDPZIw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; } 
    
    /// <summary>
    /// Special instructions. 
    /// </summary>
    [IsoId("_rY32LvcmEeiW-auGnDPZIw")]
    [DisplayName("Instructions")]
    [IsoXmlTag("Instrs")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Instructions { get; init; } 
    
    
    #nullable disable
    
}
