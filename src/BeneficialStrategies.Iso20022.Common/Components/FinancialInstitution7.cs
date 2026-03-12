// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a financial institution required by business or regulation (for example, in money or funds transfer).
/// </summary>
[IsoId("_emUNwcWpEeuhguwJmlgagQ")]
[DisplayName("Financial Institution")]
public partial record FinancialInstitution7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial institution.
    /// </summary>
    [IsoId("_equzscWpEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Name of the financial institution.
    /// </summary>
    [IsoId("_equzs8WpEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Address of the financial institution.
    /// </summary>
    [IsoId("_equztcWpEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Electronic mail address of the financial institution.
    /// </summary>
    [IsoId("_equzt8WpEeuhguwJmlgagQ")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Universal Resource Locator (URL) address of the financial institution.
    /// </summary>
    [IsoId("_equzucWpEeuhguwJmlgagQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_equzu8WpEeuhguwJmlgagQ")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; } 
    
    /// <summary>
    /// Phone number of the customer services.
    /// </summary>
    [IsoId("_equzvcWpEeuhguwJmlgagQ")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; } 
    
    /// <summary>
    /// Additional information used to facilitate contact with the financial institution, for instance dispute manager name.
    /// </summary>
    [IsoId("_equzv8WpEeuhguwJmlgagQ")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; } 
    
    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_JWkdEMWqEeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData2? LocalData { get; init; } 
    
    
    #nullable disable
    
}
