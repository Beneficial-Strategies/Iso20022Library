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
/// Provides details on the calculation of the margin.
/// </summary>
[IsoId("_UkjHSdp-Ed-ak6NoX_4Aeg_-647501406")]
[DisplayName("Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Margin2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Margin2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Margin2( ActiveCurrencyAndAmount reqTotalMarginAmount,VariationMargin2 reqVariationMargin,Amount2 reqInitialMargin )
    {
        TotalMarginAmount = reqTotalMarginAmount;
        VariationMargin = reqVariationMargin;
        InitialMargin = reqInitialMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_UkjHStp-Ed-ak6NoX_4Aeg_-2041966150")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Net total of the transaction exposure of all outstanding deals.
    /// </summary>
    [IsoId("_UksRMNp-Ed-ak6NoX_4Aeg_-329577950")]
    [DisplayName("Exposure Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrAmt")]
    #endif
    [IsoXmlTag("XpsrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? ExposureAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? ExposureAmount { get; init; } 
    #else
    public Amount2? ExposureAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total margin requirement (expressed in the reporting currency) that must be provided by the clearing member to the central counterparty. This is the total requirement calculated to cover the initial margin and the variation margin.
    /// </summary>
    [IsoId("_UksRMdp-Ed-ak6NoX_4Aeg_-1135141434")]
    [DisplayName("Total Margin Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlMrgnAmt")]
    #endif
    [IsoXmlTag("TtlMrgnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalMarginAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalMarginAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalMarginAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalMarginAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the calculation of the variation margin.
    /// </summary>
    [IsoId("_UksRMtp-Ed-ak6NoX_4Aeg_177061771")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VariationMargin2 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VariationMargin2 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VariationMargin2 VariationMargin { get; init; } 
    #else
    public VariationMargin2 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// </summary>
    [IsoId("_UksRM9p-Ed-ak6NoX_4Aeg_2010627762")]
    [DisplayName("Initial Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgn")]
    #endif
    [IsoXmlTag("InitlMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2 InitialMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2 InitialMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2 InitialMargin { get; init; } 
    #else
    public Amount2 InitialMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount (expressed in the reporting currency) that the clearing member will have to provide to cover a risk increase. This results from a risk management decision depending on Central counterparty specific criteria.
    /// </summary>
    [IsoId("_UksRNNp-Ed-ak6NoX_4Aeg_2025633151")]
    [DisplayName("Increase Coverage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrCvrg")]
    #endif
    [IsoXmlTag("IncrCvrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IncreaseCoverage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IncreaseCoverage { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IncreaseCoverage { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the Central counterparty.
    /// </summary>
    [IsoId("_UksRNdp-Ed-ak6NoX_4Aeg_499679229")]
    [DisplayName("Minimum Requirement Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinRqrmntDpst")]
    #endif
    [IsoXmlTag("MinRqrmntDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_UksRNtp-Ed-ak6NoX_4Aeg_1252170489")]
    [DisplayName("Collateral On Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollOnDpst")]
    #endif
    [IsoXmlTag("CollOnDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Collateral3? CollateralOnDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral3? CollateralOnDeposit { get; init; } 
    #else
    public Collateral3? CollateralOnDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the margin result.
    /// </summary>
    [IsoId("_UksRN9p-Ed-ak6NoX_4Aeg_1717019535")]
    [DisplayName("Margin Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRslt")]
    #endif
    [IsoXmlTag("MrgnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginResult1Choice_? MarginResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginResult1Choice_? MarginResult { get; init; } 
    #else
    public MarginResult1Choice_? MarginResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
