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
/// Redemption leg, or switch-out, of a switch transaction.
/// </summary>
[IsoId("_4kpxMzbsEead9bDRE_1DAQ")]
[DisplayName("Switch Redemption Leg Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchRedemptionLegOrder6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchRedemptionLegOrder6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchRedemptionLegOrder6( FinancialInstrument57 reqFinancialInstrumentDetails,System.String reqPhysicalDeliveryIndicator )
    {
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        PhysicalDeliveryIndicator = reqPhysicalDeliveryIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for the instance of the leg within a switch.
    /// </summary>
    [IsoId("_48wIBTbsEead9bDRE_1DAQ")]
    [DisplayName("Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegId")]
    #endif
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegIdentification { get; init; } 
    #else
    public System.String? LegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Investment fund class related to the redemption leg of the order.
    /// </summary>
    [IsoId("_48wIBzbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument57 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money, number of units or percentage for the subscription leg of the switch order.
    /// </summary>
    [IsoId("_48wICTbsEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Quantity Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmQtyChc")]
    #endif
    [IsoXmlTag("FinInstrmQtyChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity29Choice_? FinancialInstrumentQuantityChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity29Choice_? FinancialInstrumentQuantityChoice { get; init; } 
    #else
    public FinancialInstrumentQuantity29Choice_? FinancialInstrumentQuantityChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("_48wICzbsEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount58? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_48wIDTbsEead9bDRE_1DAQ")]
    [DisplayName("Income Preference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmPref")]
    #endif
    [IsoXmlTag("IncmPref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncomePreference1Code? IncomePreference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomePreference1Code? IncomePreference { get; init; } 
    #else
    public IncomePreference1Code? IncomePreference { get; set; } 
    #endif
    
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_48wIDzbsEead9bDRE_1DAQ")]
    [DisplayName("Group 1 Or 2 Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp1Or2Units")]
    #endif
    [IsoXmlTag("Grp1Or2Units")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    #else
    public UKTaxGroupUnit1Code? Group1Or2Units { get; set; } 
    #endif
    
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_48wIETbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmCcy")]
    #endif
    [IsoXmlTag("ReqdSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedSettlementCurrency { get; init; } 
    #else
    public string? RequestedSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_48wIEzbsEead9bDRE_1DAQ")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the gross amount.
    /// </summary>
    [IsoId("_fBLhMTk5EeapUO0vUIo9Xw")]
    [DisplayName("Transaction Overhead")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOvrhd")]
    #endif
    [IsoXmlTag("TxOvrhd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FeeAndTax1? TransactionOverhead { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FeeAndTax1? TransactionOverhead { get; init; } 
    #else
    public FeeAndTax1? TransactionOverhead { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_48wIGzbsEead9bDRE_1DAQ")]
    [DisplayName("Settlement And Custody Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAndCtdyDtls")]
    #endif
    [IsoXmlTag("SttlmAndCtdyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; init; } 
    #else
    public FundSettlementParameters12? SettlementAndCustodyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_48wIHTbsEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysDlvryInd")]
    #endif
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhysicalDeliveryIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhysicalDeliveryIndicator { get; init; } 
    #else
    public System.String PhysicalDeliveryIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [IsoId("_48wIHzbsEead9bDRE_1DAQ")]
    [DisplayName("Physical Delivery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysDlvryDtls")]
    #endif
    [IsoXmlTag("PhysDlvryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    #else
    public DeliveryParameters3? PhysicalDeliveryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_48wIITbsEead9bDRE_1DAQ")]
    [DisplayName("Non Standard Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdSttlmInf")]
    #endif
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardSettlementInformation { get; init; } 
    #else
    public System.String? NonStandardSettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Part of an investor&apos;s retained subscription amount that is returned by the fund in order to reimburse preliminary incentive/performance fees.
    /// </summary>
    [IsoId("_48wIIzbsEead9bDRE_1DAQ")]
    [DisplayName("Equalisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Equlstn")]
    #endif
    [IsoXmlTag("Equlstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Equalisation1? Equalisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Equalisation1? Equalisation { get; init; } 
    #else
    public Equalisation1? Equalisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
