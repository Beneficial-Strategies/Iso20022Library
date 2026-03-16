// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
[IsoId("_Gj3jgTOnEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily Instrument")]
public record SettlementFailsDailyInstrument3
{
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    [IsoId("_Gko_kTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Equity")]
    [IsoXmlTag("Eqty")]
    public required SettlementFailsDailyTransactionType1Choice_ Equity { get; init; }

    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    [IsoId("_Gko_kzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Sovereign Debt")]
    [IsoXmlTag("SvrgnDebt")]
    public required SettlementFailsDailyTransactionType1Choice_ SovereignDebt { get; init; }

    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    [IsoId("_Gko_lTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Bond")]
    [IsoXmlTag("Bd")]
    public required SettlementFailsDailyTransactionType1Choice_ Bond { get; init; }

    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    [IsoId("_Gko_lzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Other Transferable Securities")]
    [IsoXmlTag("OthrTrfblScties")]
    public required SettlementFailsDailyTransactionType1Choice_ OtherTransferableSecurities { get; init; }

    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_Gko_mTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Exchange Traded Funds")]
    [IsoXmlTag("XchgTraddFnds")]
    public required SettlementFailsDailyTransactionType1Choice_ ExchangeTradedFunds { get; init; }

    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    [IsoId("_Gko_mzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Collective Investment Undertakings")]
    [IsoXmlTag("CllctvInvstmtUdrtkgs")]
    public required SettlementFailsDailyTransactionType1Choice_ CollectiveInvestmentUndertakings { get; init; }

    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    [IsoId("_Gko_nTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Money Market Instrument")]
    [IsoXmlTag("MnyMktInstrm")]
    public required SettlementFailsDailyTransactionType1Choice_ MoneyMarketInstrument { get; init; }

    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    [IsoId("_Gko_nzOnEeqX8uoQQ3KffQ")]
    [DisplayName("Emission Allowance")]
    [IsoXmlTag("EmssnAllwnc")]
    public required SettlementFailsDailyTransactionType1Choice_ EmissionAllowance { get; init; }

    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    [IsoId("_Gko_oTOnEeqX8uoQQ3KffQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public required SettlementFailsDailyTransactionType1Choice_ Other { get; init; }
}
