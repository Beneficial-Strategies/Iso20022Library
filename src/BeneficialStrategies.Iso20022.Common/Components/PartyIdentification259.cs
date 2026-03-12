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
[IsoId("_nNGsIcWjEeuhguwJmlgagQ")]
[DisplayName("Party Identification")]
public partial record PartyIdentification259
{
    #nullable enable
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_nRrDEcWjEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the customer.
    /// </summary>
    [IsoId("_nRrDE8WjEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification258? Identification { get; init; } 
    
    /// <summary>
    /// Address of the customer.
    /// </summary>
    [IsoId("_nRrDFcWjEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_nRrDF8WjEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact3? Contact { get; init; } 
    
    /// <summary>
    /// Identification of the customer recognized by the taxation authority.
    /// </summary>
    [IsoId("_nRrDGcWjEeuhguwJmlgagQ")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? TaxRegistrationIdentification { get; init; } 
    
    /// <summary>
    /// Additional information about the seller. 
    /// </summary>
    [IsoId("_nRrDG8WjEeuhguwJmlgagQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
