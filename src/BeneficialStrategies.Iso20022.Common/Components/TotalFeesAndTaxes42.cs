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
[IsoId("_fzmwQZECEem7fvtoGpNpow")]
[DisplayName("Total Fees And Taxes")]
public record TotalFeesAndTaxes42
{
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_gHZO9ZECEem7fvtoGpNpow")]
    [DisplayName("Total Overhead Applied")]
    [IsoXmlTag("TtlOvrhdApld")]
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; }

    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_gHZO95ECEem7fvtoGpNpow")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; }

    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_gHZO-ZECEem7fvtoGpNpow")]
    [DisplayName("Total Taxes")]
    [IsoXmlTag("TtlTaxs")]
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; }

    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_gHZO-5ECEem7fvtoGpNpow")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_gHZO_ZECEem7fvtoGpNpow")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee5> IndividualFee { get; init; } = [];

    /// <summary>
    /// Individual tax.
    /// </summary>
    [IsoId("_gHZO_5ECEem7fvtoGpNpow")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax35> IndividualTax { get; init; } = [];
}
