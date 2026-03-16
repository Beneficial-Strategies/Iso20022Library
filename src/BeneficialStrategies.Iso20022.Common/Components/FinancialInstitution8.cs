// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Institution8.
/// </summary>
[IsoId("_NYBroW9mEe6DxcrvCrq6hQ")]
[DisplayName("Financial Institution8")]
public record FinancialInstitution8
{
    /// <summary>
    /// Additional Contact.
    /// </summary>
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Customer Service.
    /// </summary>
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData10? LocalData { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Phone.
    /// </summary>
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoMax35Text? Phone { get; init; }

    /// <summary>
    /// URL.
    /// </summary>
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }
}
