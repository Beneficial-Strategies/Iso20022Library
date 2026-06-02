// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a financial institution required by business or regulation.
/// </summary>
[IsoId("_SH9dka8mEfCj8pUMKoRAjg")]
[DisplayName("Financial Institution10")]
public record FinancialInstitution10
{
    /// <summary>
    /// Identification of the financial institution.
    /// </summary>
    [IsoId("_SJ9osa8mEfCj8pUMKoRAjg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Name of the financial institution.
    /// </summary>
    [IsoId("_SJ9os68mEfCj8pUMKoRAjg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Address of the financial institution.
    /// </summary>
    [IsoId("_SJ9ota8mEfCj8pUMKoRAjg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Electronic mail address of the financial institution.
    /// </summary>
    [IsoId("_SJ9ot68mEfCj8pUMKoRAjg")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address of the financial institution.
    /// </summary>
    [IsoId("_SJ9oua8mEfCj8pUMKoRAjg")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_SJ9ou68mEfCj8pUMKoRAjg")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoMax35Text? Phone { get; init; }

    /// <summary>
    /// Phone number of the customer services.
    /// </summary>
    [IsoId("_SJ9ova8mEfCj8pUMKoRAjg")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the financial institution.
    /// </summary>
    [IsoId("_SJ9ov68mEfCj8pUMKoRAjg")]
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_SJ9owa8mEfCj8pUMKoRAjg")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData10? LocalData { get; init; }
}
