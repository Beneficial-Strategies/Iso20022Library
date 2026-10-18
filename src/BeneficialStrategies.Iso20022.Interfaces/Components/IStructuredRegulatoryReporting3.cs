// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed due to regulatory and statutory requirements.
/// </summary>
[IsoId("_SnhZ4tp-Ed-ak6NoX_4Aeg_797411932")]
public interface IStructuredRegulatoryReporting3 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of the information supplied in the regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ49p-Ed-ak6NoX_4Aeg_-237266117")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IsoMax35Text? Type { get; }

    /// <summary>
    /// Date related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ5Np-Ed-ak6NoX_4Aeg_63801781")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    IsoISODate? Date { get; }

    /// <summary>
    /// Country related to the specified type of regulatory reporting details.
    /// </summary>
    [IsoId("_SnhZ5dp-Ed-ak6NoX_4Aeg_123830660")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }

    /// <summary>
    /// Specifies the nature, purpose, and reason for the transaction to be reported for regulatory and statutory requirements in a coded form.
    /// </summary>
    [IsoId("_SnhZ5tp-Ed-ak6NoX_4Aeg_797412241")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    IsoMax10Text? Code { get; }

    /// <summary>
    /// Amount of money to be reported for regulatory and statutory requirements.
    /// </summary>
    [IsoId("_SnhZ59p-Ed-ak6NoX_4Aeg_797412303")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount? Amount { get; }

    /// <summary>
    /// Additional details that cater for specific domestic regulatory requirements.
    /// </summary>
    [IsoId("_SnhZ6Np-Ed-ak6NoX_4Aeg_797412333")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    IEnumerable<IsoMax35Text> Information { get; }
}
