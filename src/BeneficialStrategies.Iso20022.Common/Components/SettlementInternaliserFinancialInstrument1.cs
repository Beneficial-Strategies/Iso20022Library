// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial instruments that are initially recorded or centrally maintained in CSDs (central securities depositories) as defined in the relevant regulation.
/// </summary>
[IsoId("_JZgRUO3nEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserFinancialInstrument1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliserFinancialInstrument1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserFinancialInstrument1( InternalisationData1 reqEquity,InternalisationData1 reqSovereignDebt,InternalisationData1 reqBond,InternalisationData1 reqOtherTransferableSecurities,InternalisationData1 reqExchangeTradingFunds,InternalisationData1 reqCollectiveInvestmentUndertakings,InternalisationData1 reqMoneyMarketInstrument,InternalisationData1 reqEmissionAllowance,InternalisationData1 reqOtherFinancialInstruments )
    {
        Equity = reqEquity;
        SovereignDebt = reqSovereignDebt;
        Bond = reqBond;
        OtherTransferableSecurities = reqOtherTransferableSecurities;
        ExchangeTradingFunds = reqExchangeTradingFunds;
        CollectiveInvestmentUndertakings = reqCollectiveInvestmentUndertakings;
        MoneyMarketInstrument = reqMoneyMarketInstrument;
        EmissionAllowance = reqEmissionAllowance;
        OtherFinancialInstruments = reqOtherFinancialInstruments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    [IsoId("_VHap8O3nEeaWjpoyrnG6Rw")]
    [DisplayName("Equity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Eqty")]
    #endif
    [IsoXmlTag("Eqty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 Equity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 Equity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 Equity { get; init; } 
    #else
    public InternalisationData1 Equity { get; set; } 
    #endif
    
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    [IsoId("_hI1NYO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Sovereign Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrgnDebt")]
    #endif
    [IsoXmlTag("SvrgnDebt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 SovereignDebt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 SovereignDebt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 SovereignDebt { get; init; } 
    #else
    public InternalisationData1 SovereignDebt { get; set; } 
    #endif
    
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    [IsoId("_n4s-sO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Bond")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bd")]
    #endif
    [IsoXmlTag("Bd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 Bond { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 Bond { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 Bond { get; init; } 
    #else
    public InternalisationData1 Bond { get; set; } 
    #endif
    
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    [IsoId("_uPJjYO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Other Transferable Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTrfblScties")]
    #endif
    [IsoXmlTag("OthrTrfblScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 OtherTransferableSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 OtherTransferableSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 OtherTransferableSecurities { get; init; } 
    #else
    public InternalisationData1 OtherTransferableSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_3soxgO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Exchange Trading Funds")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgTradgFnds")]
    #endif
    [IsoXmlTag("XchgTradgFnds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 ExchangeTradingFunds { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 ExchangeTradingFunds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 ExchangeTradingFunds { get; init; } 
    #else
    public InternalisationData1 ExchangeTradingFunds { get; set; } 
    #endif
    
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    [IsoId("_5fCjQO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Collective Investment Undertakings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllctvInvstmtUdrtkgs")]
    #endif
    [IsoXmlTag("CllctvInvstmtUdrtkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 CollectiveInvestmentUndertakings { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 CollectiveInvestmentUndertakings { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 CollectiveInvestmentUndertakings { get; init; } 
    #else
    public InternalisationData1 CollectiveInvestmentUndertakings { get; set; } 
    #endif
    
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    [IsoId("_FNIiEO3oEeaWjpoyrnG6Rw")]
    [DisplayName("Money Market Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyMktInstrm")]
    #endif
    [IsoXmlTag("MnyMktInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 MoneyMarketInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 MoneyMarketInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 MoneyMarketInstrument { get; init; } 
    #else
    public InternalisationData1 MoneyMarketInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    [IsoId("_HCzqQO3oEeaWjpoyrnG6Rw")]
    [DisplayName("Emission Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmssnAllwnc")]
    #endif
    [IsoXmlTag("EmssnAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 EmissionAllowance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 EmissionAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 EmissionAllowance { get; init; } 
    #else
    public InternalisationData1 EmissionAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    [IsoId("_Rf1p0O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Other Financial Instruments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFinInstrms")]
    #endif
    [IsoXmlTag("OthrFinInstrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 OtherFinancialInstruments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 OtherFinancialInstruments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 OtherFinancialInstruments { get; init; } 
    #else
    public InternalisationData1 OtherFinancialInstruments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
