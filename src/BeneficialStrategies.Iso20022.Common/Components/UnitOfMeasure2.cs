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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_OO8ZwZF_EeukDPgU2BMkjQ")]
[DisplayName("Unit Of Measure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitOfMeasure2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unit of measure of the item being shipped.
    /// </summary>
    [IsoId("_OU5QwZF_EeukDPgU2BMkjQ")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_OU5Qw5F_EeukDPgU2BMkjQ")]
    [DisplayName("Other Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitOfMeasr")]
    #endif
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitOfMeasure { get; init; } 
    #else
    public System.String? OtherUnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units.
    /// </summary>
    [IsoId("_OU5QxZF_EeukDPgU2BMkjQ")]
    [DisplayName("Number Of Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfUnits")]
    #endif
    [IsoXmlTag("NbOfUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NumberOfUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfUnits { get; init; } 
    #else
    public System.UInt64? NumberOfUnits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
