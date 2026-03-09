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
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_9h9p58WLEeiRga8tPu1L4Q")]
[DisplayName("Position Set Collateral Total")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetCollateralTotal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the number of reports used for calculating the position set.
    /// </summary>
    [IsoId("_9h9p6sWLEeiRga8tPu1L4Q")]
    [DisplayName("Number Of Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfRpts")]
    #endif
    [IsoXmlTag("NbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20PositiveNumber? NumberOfReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfReports { get; init; } 
    #else
    public System.UInt64? NumberOfReports { get; set; } 
    #endif
    
    /// <summary>
    /// Values of the initial margin for the portfolio.
    /// </summary>
    [IsoId("_9h9p6MWLEeiRga8tPu1L4Q")]
    [DisplayName("Initial Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgn")]
    #endif
    [IsoXmlTag("InitlMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetPostedAndReceived1? InitialMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetPostedAndReceived1? InitialMargin { get; init; } 
    #else
    public PositionSetPostedAndReceived1? InitialMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Values of the variation margin for the portfolio.
    /// </summary>
    [IsoId("_9h9p6cWLEeiRga8tPu1L4Q")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetPostedAndReceived1? VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetPostedAndReceived1? VariationMargin { get; init; } 
    #else
    public PositionSetPostedAndReceived1? VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Values of the excess cash for the portfolio.
    /// </summary>
    [IsoId("_9drxYcWMEeiRga8tPu1L4Q")]
    [DisplayName("Excess Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCsh")]
    #endif
    [IsoXmlTag("XcssCsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetPostedAndReceived1? ExcessCash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetPostedAndReceived1? ExcessCash { get; init; } 
    #else
    public PositionSetPostedAndReceived1? ExcessCash { get; set; } 
    #endif
    
    
    #nullable disable
    
}
