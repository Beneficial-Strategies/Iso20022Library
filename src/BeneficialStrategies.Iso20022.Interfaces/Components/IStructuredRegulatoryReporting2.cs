// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
[IsoId("_SnOe_9p-Ed-ak6NoX_4Aeg_699509907")]
public interface IStructuredRegulatoryReporting2 : IIsoComponent
{
    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_SnYP8Np-Ed-ak6NoX_4Aeg_766002068")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    IsoMax3Text? Code { get; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_SnYP8dp-Ed-ak6NoX_4Aeg_766002103")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    CurrencyAndAmount? Amount { get; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.||Usage: Information is used to provide details that are not catered for in the Code or/and Amount elements.
    /// </summary>
    [IsoId("_SnYP8tp-Ed-ak6NoX_4Aeg_766002145")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    IsoMax35Text? Information { get; }
}
