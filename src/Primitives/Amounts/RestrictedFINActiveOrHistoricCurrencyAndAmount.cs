// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// Number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217.
/// </summary>
public record RestrictedFINActiveOrHistoricCurrencyAndAmount : IIsoAmount
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_XY_k3tp-Ed-ak6NoX_4Aeg_1054967173_Currency")]
    [DisplayName("Restricted FIN Active Or Historic Currency And Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_XY_k3tp-Ed-ak6NoX_4Aeg_1054967173_Amount")]
    [DisplayName("Restricted FIN Active Or Historic Currency And Amount _ Amount")]
    [IsoXmlTag("Amount")]
    [IsoAmount(14, 5)]
    public required decimal Amount
    {
        get => _amount;
        init => _amount = IsoAmountFacets.Check(typeof(RestrictedFINActiveOrHistoricCurrencyAndAmount), nameof(Amount), value);
    }

    private decimal _amount;
}
