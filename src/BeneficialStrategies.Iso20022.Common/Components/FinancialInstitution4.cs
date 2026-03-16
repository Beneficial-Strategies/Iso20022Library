// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a financial institution required by business or regulation (for example, in money or funds transfer).
/// </summary>
[IsoId("_SIxmoEB9EeeXpbqDpLawug")]
[DisplayName("Financial Institution")]
public record FinancialInstitution4
{
    /// <summary>
    /// Identification of the financial institution.
    /// </summary>
    [IsoId("_sUzOoEB9EeeXpbqDpLawug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Name of the financial institution.
    /// </summary>
    [IsoId("_we4CYEB9EeeXpbqDpLawug")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Address of the financial institution.
    /// </summary>
    [IsoId("_1z2jAEB9EeeXpbqDpLawug")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Electronic mail address of the financial institution.
    /// </summary>
    [IsoId("_IsGbYEB-EeeXpbqDpLawug")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address of the financial institution.
    /// </summary>
    [IsoId("_P-j8YEB-EeeXpbqDpLawug")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_YqCewEB-EeeXpbqDpLawug")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer services.
    /// </summary>
    [IsoId("_gBJ2QEB-EeeXpbqDpLawug")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the financial institution, for instance dispute manager name.
    /// </summary>
    [IsoId("_pUb_gEB-EeeXpbqDpLawug")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalContactInformation { get; init; }
}
