// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer
/// </summary>
[IsoId("_MOxDIcWzEeuhguwJmlgagQ")]
[DisplayName("Customer")]
public partial record Customer8
{
    #nullable enable
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_MTbgscWzEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Details of the party identification.
    /// </summary>
    [IsoId("_MTbgs8WzEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification208 Identification { get; init; } 
    
    /// <summary>
    /// Number or code assigned by an airline, company or other party to track or uniquely identify a person, department or project.
    /// </summary>
    [IsoId("_MTbgtcWzEeuhguwJmlgagQ")]
    [DisplayName("Customer File Reference Number")]
    [IsoXmlTag("CstmrFileRefNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; } 
    
    /// <summary>
    /// Age of the customer.
    /// </summary>
    [IsoId("_MTbgt8WzEeuhguwJmlgagQ")]
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Age { get; init; } 
    
    /// <summary>
    /// Address details of the customer.
    /// </summary>
    [IsoId("_MTbgucWzEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_MTbgu8WzEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; } 
    
    
    #nullable disable
    
}
