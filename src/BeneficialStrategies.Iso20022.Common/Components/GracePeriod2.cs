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
/// Grace period applicable to an instalment plan.
/// </summary>
[IsoId("_CPcywZJMEeuuktRxxQZoNQ")]
[DisplayName("Grace Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GracePeriod2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Grace period time relative to the grace period unit type. 
    /// </summary>
    [IsoId("_CWyJ0ZJMEeuuktRxxQZoNQ")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Time { get; init; } 
    #else
    public System.String? Time { get; set; } 
    #endif
    
    /// <summary>
    /// Grace period unit type.
    /// </summary>
    [IsoId("_CWyJ05JMEeuuktRxxQZoNQ")]
    [DisplayName("Unit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitTp")]
    #endif
    [IsoXmlTag("UnitTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GracePeriodUnitType1Code? UnitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GracePeriodUnitType1Code? UnitType { get; init; } 
    #else
    public GracePeriodUnitType1Code? UnitType { get; set; } 
    #endif
    
    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    [IsoId("_CWyJ1ZJMEeuuktRxxQZoNQ")]
    [DisplayName("Other Unit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitTp")]
    #endif
    [IsoXmlTag("OthrUnitTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitType { get; init; } 
    #else
    public System.String? OtherUnitType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a customer selected grace period
    /// </summary>
    [IsoId("_oMntkJJMEeuuktRxxQZoNQ")]
    [DisplayName("Customer Selected Grace Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrSelctdGracePrd")]
    #endif
    [IsoXmlTag("CstmrSelctdGracePrd")]
    [IsoSimpleType(IsoSimpleType.boolean)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Isoboolean? CustomerSelectedGracePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerSelectedGracePeriod { get; init; } 
    #else
    public System.String? CustomerSelectedGracePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
