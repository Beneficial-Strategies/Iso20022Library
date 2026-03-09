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
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_zg_J065QEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExposureMetrics6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_zwe-Ya5QEeuo-IflVgGqiA")]
    [DisplayName("Posted Margin Or Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstdMrgnOrColl")]
    #endif
    [IsoXmlTag("PstdMrgnOrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
    #else
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; set; } 
    #endif
    
    
    #nullable disable
    
}
