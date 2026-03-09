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
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
[IsoId("_KUd0HRuyEeyhRdHRjakS2w")]
[DisplayName("Total Eligible Balance Format")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalEligibleBalanceFormat10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_KpeasRuyEeyhRdHRjakS2w")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity49Choice_? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity49Choice_? Balance { get; init; } 
    #else
    public Quantity49Choice_? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_KpeasxuyEeyhRdHRjakS2w")]
    [DisplayName("Full Period Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullPrdUnits")]
    #endif
    [IsoXmlTag("FullPrdUnits")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? FullPeriodUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? FullPeriodUnits { get; init; } 
    #else
    public SignedQuantityFormat10? FullPeriodUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    [IsoId("_KpeatRuyEeyhRdHRjakS2w")]
    [DisplayName("Part Way Period Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PartWayPrdUnits")]
    #endif
    [IsoXmlTag("PartWayPrdUnits")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat10? PartWayPeriodUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10? PartWayPeriodUnits { get; init; } 
    #else
    public SignedQuantityFormat10? PartWayPeriodUnits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
