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
[IsoId("_Qfn5Qtp-Ed-ak6NoX_4Aeg_-214178771")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice9( UnitOfMeasure4Code reqUnitOfMeasureCode,System.String reqOtherUnitOfMeasure,CurrencyAndAmount reqAmount )
    {
        UnitOfMeasureCode = reqUnitOfMeasureCode;
        OtherUnitOfMeasure = reqOtherUnitOfMeasure;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unit of measurement. For example, kilo, tons.
    /// </summary>
    [IsoId("_Qfn5Q9p-Ed-ak6NoX_4Aeg_-214178648")]
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
    [IsoId("_Qfn5RNp-Ed-ak6NoX_4Aeg_-214178370")]
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
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_Qfn5Rdp-Ed-ak6NoX_4Aeg_-214178739")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_Qfn5Rtp-Ed-ak6NoX_4Aeg_-214178679")]
    [DisplayName("Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctr")]
    #endif
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? Factor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Factor { get; init; } 
    #else
    public System.String? Factor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
