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
[IsoId("_Tp4sqPPWEeihCvvpsmGI2w")]
[DisplayName("Party Identification")]
public partial record PartyIdentification207
{
    #nullable enable
    
    /// <summary>
    /// Contains an agency code or name.
    /// </summary>
    [IsoId("_Tp6h1vPWEeihCvvpsmGI2w")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Code { get; init; } 
    
    /// <summary>
    /// Assigner of the code.
    /// </summary>
    [IsoId("_Tp6h1PPWEeihCvvpsmGI2w")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Contains the International Air Transport Association (IATA) code identifying the company that purchased the ticket. 
    /// </summary>
    [IsoId("_Tp6h0fPWEeihCvvpsmGI2w")]
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IATACode { get; init; } 
    
    /// <summary>
    /// Name of the company.
    /// </summary>
    [IsoId("_Nw8t4_PXEeihCvvpsmGI2w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Short name of the company.
    /// </summary>
    [IsoId("_Nw8t4vPXEeihCvvpsmGI2w")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Address of the customer.
    /// </summary>
    [IsoId("_Tp6h1fPWEeihCvvpsmGI2w")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; } 
    
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_Tp6h0PPWEeihCvvpsmGI2w")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; } 
    
    
    #nullable disable
    
}
