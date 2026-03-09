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
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_SvuToNp-Ed-ak6NoX_4Aeg_-852630950")]
[DisplayName("ISA Years Of Issue")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISAYearsOfIssue3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ISAYearsOfIssue3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ISAYearsOfIssue3( System.String reqCashComponentIndicator,SubscriptionInformation1 reqCurrentYearSubscriptionDetails )
    {
        CashComponentIndicator = reqCashComponentIndicator;
        CurrentYearSubscriptionDetails = reqCurrentYearSubscriptionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTodp-Ed-ak6NoX_4Aeg_-852630907")]
    [DisplayName("Current Year Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrTp")]
    #endif
    [IsoXmlTag("CurYrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISAType1Code? CurrentYearType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ISAType1Code? CurrentYearType { get; init; } 
    #else
    public ISAType1Code? CurrentYearType { get; set; } 
    #endif
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTotp-Ed-ak6NoX_4Aeg_-484143046")]
    [DisplayName("Extended Current Year Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedCurYrTp")]
    #endif
    [IsoXmlTag("XtndedCurYrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedCurrentYearType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedCurrentYearType { get; init; } 
    #else
    public System.String? ExtendedCurrentYearType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_SvuTo9p-Ed-ak6NoX_4Aeg_-484142768")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CashComponentIndicator { get; init; } 
    #else
    public System.String CashComponentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_SvuTpNp-Ed-ak6NoX_4Aeg_-115002919")]
    [DisplayName("Current Year Subscription Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYrSbcptDtls")]
    #endif
    [IsoXmlTag("CurYrSbcptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    #else
    public SubscriptionInformation1 CurrentYearSubscriptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_SvuTpdp-Ed-ak6NoX_4Aeg_375718367")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYear1? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear1? PreviousYears { get; init; } 
    #else
    public PreviousYear1? PreviousYears { get; set; } 
    #endif
    
    
    #nullable disable
    
}
