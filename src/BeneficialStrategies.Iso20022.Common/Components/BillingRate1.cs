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
/// Specifies the billing rate.
/// </summary>
[IsoId("_6QGNppqlEeGSON8vddiWzQ_1919554496")]
[DisplayName("Billing Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingRate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingRate1( BillingRateIdentification1Choice_ reqIdentification,System.Decimal reqValue )
    {
        Identification = reqIdentification;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the type of rate or factor.
    /// </summary>
    [IsoId("_6QP-oJqlEeGSON8vddiWzQ_-585660341")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingRateIdentification1Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingRateIdentification1Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingRateIdentification1Choice_ Identification { get; init; } 
    #else
    public BillingRateIdentification1Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the rate or factor identified in the rate identification.
    /// </summary>
    [IsoId("_6QP-oZqlEeGSON8vddiWzQ_-1751808782")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Value { get; init; } 
    #else
    public System.Decimal Value { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days in the statement period. ||Usage: Used along with DaysInYear for time dependent per annum rate value.
    /// </summary>
    [IsoId("_6QP-opqlEeGSON8vddiWzQ_-1641402761")]
    [DisplayName("Days In Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DaysInPrd")]
    #endif
    [IsoXmlTag("DaysInPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DaysInPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysInPeriod { get; init; } 
    #else
    public System.UInt64? DaysInPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days in the year.||Usage: Used along with DaysInPeriod for time dependent per annum rate value.
    /// </summary>
    [IsoId("_6QP-o5qlEeGSON8vddiWzQ_-1276728980")]
    [DisplayName("Days In Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DaysInYr")]
    #endif
    [IsoXmlTag("DaysInYr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? DaysInYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysInYear { get; init; } 
    #else
    public System.UInt64? DaysInYear { get; set; } 
    #endif
    
    
    #nullable disable
    
}
