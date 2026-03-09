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
/// Information on the type of tax.
/// </summary>
[IsoId("_RvWbxtp-Ed-ak6NoX_4Aeg_1316020660")]
[DisplayName("Tax Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxType
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the tax that is being paid, including specific representation required by taxing authority.
    /// </summary>
    [IsoId("_RvWbx9p-Ed-ak6NoX_4Aeg_1403753704")]
    [DisplayName("Category Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyDesc")]
    #endif
    [IsoXmlTag("CtgyDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CategoryDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CategoryDescription { get; init; } 
    #else
    public System.String? CategoryDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_RvWbyNp-Ed-ak6NoX_4Aeg_1403753781")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    [IsoId("_RvWbydp-Ed-ak6NoX_4Aeg_1403754228")]
    [DisplayName("Taxable Base Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblBaseAmt")]
    #endif
    [IsoXmlTag("TaxblBaseAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TaxableBaseAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TaxableBaseAmount { get; init; } 
    #else
    public CurrencyAndAmount? TaxableBaseAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_RvWbytp-Ed-ak6NoX_4Aeg_1403754133")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? Amount { get; init; } 
    #else
    public CurrencyAndAmount? Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
