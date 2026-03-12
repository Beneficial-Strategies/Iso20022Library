// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication information.
/// </summary>
[IsoId("_T0l-cXrqEeSz_of_1TY14A")]
[DisplayName("Communication Address")]
public partial record CommunicationAddress5
{
    #nullable enable
    
    /// <summary>
    /// Postal address of the entity.
    /// </summary>
    [IsoId("_MYhjkHrsEeSz_of_1TY14A")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress18? PostalAddress { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_UBtNYXrqEeSz_of_1TY14A")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example used over the www (HTTP) service.
    /// </summary>
    [IsoId("_UBtNa3rqEeSz_of_1TY14A")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_UBtNY3rqEeSz_of_1TY14A")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Phone { get; init; } 
    
    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_trLakHrtEeSz_of_1TY14A")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? CustomerService { get; init; } 
    
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_0cE8EHrsEeSz_of_1TY14A")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; } 
    
    
    #nullable disable
    
}
