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
[IsoId("dc9e6b08-8884-4c4d-a910-abcaf5dab61e")]
[DisplayName("Total Fees And Taxes45")]
public record TotalFeesAndTaxes45
{
    [IsoId("b31ecc36-858f-44a5-8338-ca5657118a0b")]
    [DisplayName("Total Overhead Applied")]
    [IsoXmlTag("TtlOvrhdApld")]
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; }

    [IsoId("43ecb918-7a53-47ba-88d2-fc9e2a2cd990")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; }

    [IsoId("b33a0973-1909-42af-a3ff-76ec35748896")]
    [DisplayName("Total Taxes")]
    [IsoXmlTag("TtlTaxs")]
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; }

    [IsoId("fa973eea-5daf-45e7-9811-5d717474149f")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    [IsoId("0a040089-6796-4a3b-8303-2f425a5aed8a")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee11> IndividualFee { get; init; } = [];

    [IsoId("1221f8fb-eff5-478e-8655-98d7d9c0e00d")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax35> IndividualTax { get; init; } = [];

    [IsoId("3f196001-64f8-41d2-8622-76c265b31467")]
    [DisplayName("Digital Network Fee")]
    [IsoXmlTag("DgtlNtwkFee")]
    public ValueList<DigitalPaymentSettlement3> DigitalNetworkFee { get; init; } = [];
}
