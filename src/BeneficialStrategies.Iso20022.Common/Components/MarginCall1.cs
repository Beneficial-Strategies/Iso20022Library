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
/// Details of the margin call request.
/// </summary>
[IsoId("_Uk_MJdp-Ed-ak6NoX_4Aeg_138884862")]
[DisplayName("Margin Call")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCall1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party A. That is, all transactions which would have an amount payable by party B to party A if they were being terminated.
    /// </summary>
    [IsoId("_Uk_MJtp-Ed-ak6NoX_4Aeg_-1579631561")]
    [DisplayName("Exposed Amount Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsdAmtPtyA")]
    #endif
    [IsoXmlTag("XpsdAmtPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ExposedAmountPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the exposures of all transactions which are in the favour of party B. That is, all transactions which would have an amount payable by party A to party B if they were being terminated.
    /// </summary>
    [IsoId("_Uk_MJ9p-Ed-ak6NoX_4Aeg_1154819457")]
    [DisplayName("Exposed Amount Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsdAmtPtyB")]
    #endif
    [IsoXmlTag("XpsdAmtPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ExposedAmountPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Determines how the variation margin requirement is to be calculated:
    /// - either Net, in which the exposure of all transactions in favour of party A and the the exposure of all transactions in favour of party B will be netted together or
    /// - gross in which two separate variation margin requirements will be determined.
    /// </summary>
    [IsoId("_Uk_MKNp-Ed-ak6NoX_4Aeg_1509089912")]
    [DisplayName("Exposure Convention")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrCnvntn")]
    #endif
    [IsoXmlTag("XpsrCnvntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureConventionType1Code? ExposureConvention { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureConventionType1Code? ExposureConvention { get; init; } 
    #else
    public ExposureConventionType1Code? ExposureConvention { get; set; } 
    #endif
    
    /// <summary>
    /// Amount applied as an add-on to the exposure (to party A) usually intended to cover a possible increase in exposure before the next valuation date.
    /// </summary>
    [IsoId("_Uk_MKdp-Ed-ak6NoX_4Aeg_1988654401")]
    [DisplayName("Independent Amount Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndpdntAmtPtyA")]
    #endif
    [IsoXmlTag("IndpdntAmtPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregatedIndependentAmount1? IndependentAmountPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregatedIndependentAmount1? IndependentAmountPartyA { get; init; } 
    #else
    public AggregatedIndependentAmount1? IndependentAmountPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// An amount applied as an add-on to the exposure (to party B) usually intended to cover a possible increase in exposure before the next valuation date.
    /// </summary>
    [IsoId("_UlI9INp-Ed-ak6NoX_4Aeg_-957268284")]
    [DisplayName("Independent Amount Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndpdntAmtPtyB")]
    #endif
    [IsoXmlTag("IndpdntAmtPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregatedIndependentAmount1? IndependentAmountPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregatedIndependentAmount1? IndependentAmountPartyB { get; init; } 
    #else
    public AggregatedIndependentAmount1? IndependentAmountPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like threshold amount, threshold type, minimum transfer amount, rouding amount or rounding convention, that applies to either the variation margin or the segregated independent amount.
    /// </summary>
    [IsoId("_UlI9Idp-Ed-ak6NoX_4Aeg_1932695356")]
    [DisplayName("Margin Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnTerms")]
    #endif
    [IsoXmlTag("MrgnTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginTerms1Choice_? MarginTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginTerms1Choice_? MarginTerms { get; init; } 
    #else
    public MarginTerms1Choice_? MarginTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties with a segregation between variation margin and segregated independent amount.
    /// </summary>
    [IsoId("_UlI9Itp-Ed-ak6NoX_4Aeg_-381594311")]
    [DisplayName("Collateral Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollBal")]
    #endif
    [IsoXmlTag("CollBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralBalance1Choice_? CollateralBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralBalance1Choice_? CollateralBalance { get; init; } 
    #else
    public CollateralBalance1Choice_? CollateralBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
