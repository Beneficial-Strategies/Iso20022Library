// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
[IsoId("_JZgRUO3nEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Financial Instrument")]
public partial record SettlementInternaliserFinancialInstrument1
{
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    [IsoId("_VHap8O3nEeaWjpoyrnG6Rw")]
    [DisplayName("Equity")]
    [IsoXmlTag("Eqty")]
    public required InternalisationData1 Equity { get; init; } 
    
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    [IsoId("_hI1NYO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Sovereign Debt")]
    [IsoXmlTag("SvrgnDebt")]
    public required InternalisationData1 SovereignDebt { get; init; } 
    
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    [IsoId("_n4s-sO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Bond")]
    [IsoXmlTag("Bd")]
    public required InternalisationData1 Bond { get; init; } 
    
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    [IsoId("_uPJjYO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Other Transferable Securities")]
    [IsoXmlTag("OthrTrfblScties")]
    public required InternalisationData1 OtherTransferableSecurities { get; init; } 
    
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_3soxgO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Exchange Trading Funds")]
    [IsoXmlTag("XchgTradgFnds")]
    public required InternalisationData1 ExchangeTradingFunds { get; init; } 
    
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    [IsoId("_5fCjQO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Collective Investment Undertakings")]
    [IsoXmlTag("CllctvInvstmtUdrtkgs")]
    public required InternalisationData1 CollectiveInvestmentUndertakings { get; init; } 
    
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    [IsoId("_FNIiEO3oEeaWjpoyrnG6Rw")]
    [DisplayName("Money Market Instrument")]
    [IsoXmlTag("MnyMktInstrm")]
    public required InternalisationData1 MoneyMarketInstrument { get; init; } 
    
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    [IsoId("_HCzqQO3oEeaWjpoyrnG6Rw")]
    [DisplayName("Emission Allowance")]
    [IsoXmlTag("EmssnAllwnc")]
    public required InternalisationData1 EmissionAllowance { get; init; } 
    
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    [IsoId("_Rf1p0O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Other Financial Instruments")]
    [IsoXmlTag("OthrFinInstrms")]
    public required InternalisationData1 OtherFinancialInstruments { get; init; } 
    
    
    #nullable disable
    
}
