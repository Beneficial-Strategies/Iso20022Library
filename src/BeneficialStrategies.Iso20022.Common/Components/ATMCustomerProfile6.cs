// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Customer Profile6.
/// </summary>
[IsoId("_iVZ6QajzEe--FqfI7l8ySw")]
[DisplayName("ATM Customer Profile6")]
public record ATMCustomerProfile6
{
    /// <summary>
    /// Customer Identification.
    /// </summary>
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    public IsoMax35Text? CustomerIdentification { get; init; }

    /// <summary>
    /// Preferred Language.
    /// </summary>
    [DisplayName("Preferred Language")]
    [IsoXmlTag("PrefrdLang")]
    public LanguageCode? PreferredLanguage { get; init; }

    /// <summary>
    /// Profile Reference.
    /// </summary>
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    public IsoMax35Text? ProfileReference { get; init; }

    /// <summary>
    /// Retrieval Mode.
    /// </summary>
    [DisplayName("Retrieval Mode")]
    [IsoXmlTag("RtrvlMd")]
    public required ATMCustomerProfile1Code RetrievalMode { get; init; }
}
