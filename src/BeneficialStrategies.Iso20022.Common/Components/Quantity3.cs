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
/// Specifies the quantity of a product in a trade transaction.
/// </summary>
[IsoId("_Sqgcfdp-Ed-ak6NoX_4Aeg_-119892077")]
[DisplayName("Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Quantity3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Quantity3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Quantity3( UnitOfMeasure4Code reqUnitOfMeasureCode,System.String reqOtherUnitOfMeasure,System.UInt64 reqValue )
    {
        UnitOfMeasureCode = reqUnitOfMeasureCode;
        OtherUnitOfMeasure = reqOtherUnitOfMeasure;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unit of measurement. For example, kilo, tons.
    /// </summary>
    [IsoId("_Sqgcftp-Ed-ak6NoX_4Aeg_-119891985")]
    [DisplayName("Unit Of Measure Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasrCd")]
    #endif
    [IsoXmlTag("UnitOfMeasrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure4Code UnitOfMeasureCode { get; init; } 
    #else
    public UnitOfMeasure4Code UnitOfMeasureCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the unit of measure not present in the code list.
    /// </summary>
    [IsoId("_SqpmYNp-Ed-ak6NoX_4Aeg_-119891677")]
    [DisplayName("Other Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitOfMeasr")]
    #endif
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OtherUnitOfMeasure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OtherUnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OtherUnitOfMeasure { get; init; } 
    #else
    public System.String OtherUnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_SqpmYdp-Ed-ak6NoX_4Aeg_-119892046")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Value { get; init; } 
    #else
    public System.UInt64 Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
