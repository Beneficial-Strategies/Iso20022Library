// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice;

/// <summary>
/// Amount expressed as an amount of money.
/// </summary>
[IsoId("_Q-Uncdp-Ed-ak6NoX_4Aeg_512767945")]
public interface IAmount : IAmountOrRate1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Currency")]
    [DisplayName("Active Currency And Amount _ Currency")]
    [IsoXmlTag("Currency")]
    ActiveCurrencyCode Currency { get; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoXmlTag("Amount")]
    decimal Value { get; }
}
