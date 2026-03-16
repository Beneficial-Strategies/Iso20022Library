// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account43.
/// </summary>
[IsoId("_w3t9QTEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account43")]
public record CashAccount43
{
    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification4Choice_? Identification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Owner.
    /// </summary>
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification272? Owner { get; init; }

    /// <summary>
    /// Proxy.
    /// </summary>
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }

    /// <summary>
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification8? Servicer { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }
}
