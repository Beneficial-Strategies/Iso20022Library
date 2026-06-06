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
[IsoId("40a8094c-09d2-4a85-834a-3f5683f23c67")]
[DisplayName("Total Fees And Taxes44")]
public record TotalFeesAndTaxes44
{
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("52b65f4e-0960-4ff3-bec3-dde1307350fe")]
    [DisplayName("Total Overhead Applied")]
    [IsoXmlTag("TtlOvrhdApld")]
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; }

    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("b396cba3-6455-4399-a8fa-2cf33b05a9cf")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; }

    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("237c116d-f172-4447-987f-97463a317b2d")]
    [DisplayName("Total Taxes")]
    [IsoXmlTag("TtlTaxs")]
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; }

    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("01d5de7f-e187-4da2-9a5d-71709059cb29")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("b67e970a-57e2-4a41-8c63-d8f68b1aaf0a")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee11> IndividualFee { get; init; } = [];

    /// <summary>
    /// Individual tax.
    /// </summary>
    [IsoId("e54c8b75-f41b-4c96-baa4-0324090c653a")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax35> IndividualTax { get; init; } = [];

    /// <summary>
    /// Digital network fee assigned to a transaction.
    /// </summary>
    [IsoId("3c0a1f3d-b5cf-479b-90a3-1607bdd1b5c4")]
    [DisplayName("Digital Network Fee")]
    [IsoXmlTag("DgtlNtwkFee")]
    public ValueList<DigitalPaymentSettlement3> DigitalNetworkFee { get; init; } = [];
}
