// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("426b7bdb-6721-4368-b82d-1a21fc0ea3a0")]
[DisplayName("Fee And Tax2")]
public record FeeAndTax2
{
    /// <summary>
    /// Reference to the agreement established between the fund and another party.
    /// </summary>
    [IsoId("309735a8-11c6-4071-b94f-8db089a88177")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("8fea999a-2580-4162-9617-203ebe810964")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee9> IndividualFee { get; init; } = [];

    /// <summary>
    /// Individual tax amount.
    /// </summary>
    [IsoId("28521ada-c637-44fa-b002-3cf3d60f2ae6")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax42> IndividualTax { get; init; } = [];

    /// <summary>
    /// Digital payment settlement information or digital network fee assigned to a transaction.
    /// </summary>
    [IsoId("c928b762-d025-402d-b2d2-0940d4a0bfa4")]
    [DisplayName("Digital Network Fee")]
    [IsoXmlTag("DgtlNtwkFee")]
    public ValueList<DigitalPaymentSettlement3> DigitalNetworkFee { get; init; } = [];
}
