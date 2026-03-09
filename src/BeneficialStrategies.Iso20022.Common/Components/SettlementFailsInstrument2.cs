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
[IsoId("_ao5uNR2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsInstrument2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsInstrument2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsInstrument2( SettlementTotalData1Choice_ reqEquity,SettlementTotalData1Choice_ reqSovereignDebt,SettlementTotalData1Choice_ reqBond,SettlementTotalData1Choice_ reqOtherTransferableSecurities,SettlementTotalData1Choice_ reqExchangeTradedFunds,SettlementTotalData1Choice_ reqCollectiveInvestmentUndertakings,SettlementTotalData1Choice_ reqMoneyMarketInstrument,SettlementTotalData1Choice_ reqEmissionAllowance,SettlementTotalData1Choice_ reqOther )
    {
        Equity = reqEquity;
        SovereignDebt = reqSovereignDebt;
        Bond = reqBond;
        OtherTransferableSecurities = reqOtherTransferableSecurities;
        ExchangeTradedFunds = reqExchangeTradedFunds;
        CollectiveInvestmentUndertakings = reqCollectiveInvestmentUndertakings;
        MoneyMarketInstrument = reqMoneyMarketInstrument;
        EmissionAllowance = reqEmissionAllowance;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Shares in companies and other securities equivalent to shares in companies, partnerships or other entities, and depositary receipts in respect of share.
    /// </summary>
    [IsoId("_apzGER2lEeqF2P5v-Rtejg")]
    [DisplayName("Equity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Eqty")]
    #endif
    [IsoXmlTag("Eqty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ Equity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ Equity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ Equity { get; init; } 
    #else
    public SettlementTotalData1Choice_ Equity { get; set; } 
    #endif
    
    /// <summary>
    /// Debt instrument issued by a sovereign issuer.
    /// </summary>
    [IsoId("_apzGEx2lEeqF2P5v-Rtejg")]
    [DisplayName("Sovereign Debt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrgnDebt")]
    #endif
    [IsoXmlTag("SvrgnDebt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ SovereignDebt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ SovereignDebt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ SovereignDebt { get; init; } 
    #else
    public SettlementTotalData1Choice_ SovereignDebt { get; set; } 
    #endif
    
    /// <summary>
    /// Bonds other than sovereign debt.
    /// </summary>
    [IsoId("_apzGFR2lEeqF2P5v-Rtejg")]
    [DisplayName("Bond")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bd")]
    #endif
    [IsoXmlTag("Bd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ Bond { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ Bond { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ Bond { get; init; } 
    #else
    public SettlementTotalData1Choice_ Bond { get; set; } 
    #endif
    
    /// <summary>
    /// Securities meeting the criteria laid down in the relevant legislation.
    /// </summary>
    [IsoId("_apzGFx2lEeqF2P5v-Rtejg")]
    [DisplayName("Other Transferable Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTrfblScties")]
    #endif
    [IsoXmlTag("OthrTrfblScties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ OtherTransferableSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ OtherTransferableSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ OtherTransferableSecurities { get; init; } 
    #else
    public SettlementTotalData1Choice_ OtherTransferableSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to a fund of which at least one unit or share class is traded throughout the day on at least one trading venue and with at least one market maker which takes action to ensure that the price of its units or shares on the trading venue does not vary significantly from its net asset value and, where applicable, from its indicative net asset value, as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_apzGGR2lEeqF2P5v-Rtejg")]
    [DisplayName("Exchange Traded Funds")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgTraddFnds")]
    #endif
    [IsoXmlTag("XchgTraddFnds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ ExchangeTradedFunds { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ ExchangeTradedFunds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ ExchangeTradedFunds { get; init; } 
    #else
    public SettlementTotalData1Choice_ ExchangeTradedFunds { get; set; } 
    #endif
    
    /// <summary>
    /// Units in collective investment undertakings, other than ETFs.
    /// </summary>
    [IsoId("_apzGGx2lEeqF2P5v-Rtejg")]
    [DisplayName("Collective Investment Undertakings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllctvInvstmtUdrtkgs")]
    #endif
    [IsoXmlTag("CllctvInvstmtUdrtkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ CollectiveInvestmentUndertakings { get; init; } 
    #else
    public SettlementTotalData1Choice_ CollectiveInvestmentUndertakings { get; set; } 
    #endif
    
    /// <summary>
    /// Money market instruments other than sovereign debts.
    /// </summary>
    [IsoId("_apzGHR2lEeqF2P5v-Rtejg")]
    [DisplayName("Money Market Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyMktInstrm")]
    #endif
    [IsoXmlTag("MnyMktInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ MoneyMarketInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ MoneyMarketInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ MoneyMarketInstrument { get; init; } 
    #else
    public SettlementTotalData1Choice_ MoneyMarketInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Relates to emission allowances which are tradable according to the relevant legislation.
    /// </summary>
    [IsoId("_apzGHx2lEeqF2P5v-Rtejg")]
    [DisplayName("Emission Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmssnAllwnc")]
    #endif
    [IsoXmlTag("EmssnAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ EmissionAllowance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ EmissionAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ EmissionAllowance { get; init; } 
    #else
    public SettlementTotalData1Choice_ EmissionAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Covers any financial instruments not covered as a dedicated category.
    /// </summary>
    [IsoId("_apzGIR2lEeqF2P5v-Rtejg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1Choice_ Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1Choice_ Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1Choice_ Other { get; init; } 
    #else
    public SettlementTotalData1Choice_ Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
