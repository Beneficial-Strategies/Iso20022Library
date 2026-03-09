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
/// Criterion by which the cash movements are broken down.
/// </summary>
[IsoId("_Uw6IRdp-Ed-ak6NoX_4Aeg_1035399646")]
[DisplayName("Cash Sorting Criterion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashSortingCriterion2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashSortingCriterion2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashSortingCriterion2( SortCriteria1Choice_ reqSortingCriterionType )
    {
        SortingCriterionType = reqSortingCriterionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of criterion by which the cash flow is being broken down, ie, country, institution, currency code or a user defined type, such as a region or distribution channel.
    /// </summary>
    [IsoId("_Uw6IRtp-Ed-ak6NoX_4Aeg_1035399672")]
    [DisplayName("Sorting Criterion Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrtgCritnTp")]
    #endif
    [IsoXmlTag("SrtgCritnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SortCriteria1Choice_ SortingCriterionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SortCriteria1Choice_ SortingCriterionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SortCriteria1Choice_ SortingCriterionType { get; init; } 
    #else
    public SortCriteria1Choice_ SortingCriterionType { get; set; } 
    #endif
    
    /// <summary>
    /// Parameter for which the cash movements are reported.
    /// </summary>
    [IsoId("_Uw6IR9p-Ed-ak6NoX_4Aeg_1035399862")]
    [DisplayName("Forecast Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcstBrkdwnDtls")]
    #endif
    [IsoXmlTag("FcstBrkdwnDtls")]
    public ValueList<ForecastParameter2> ForecastBreakdownDetails { get; init; } = new ValueList<ForecastParameter2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Uw6IR9p-Ed-ak6NoX_4Aeg_1035399862
    
    
    #nullable disable
    
}
