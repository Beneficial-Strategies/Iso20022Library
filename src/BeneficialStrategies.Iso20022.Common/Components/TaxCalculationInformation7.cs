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
/// Information used to calculate the tax.
/// </summary>
[IsoId("_SnOe8Np-Ed-ak6NoX_4Aeg_1829579688")]
[DisplayName("Tax Calculation Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxCalculationInformation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Calculation basis.
    /// </summary>
    [IsoId("_SnOe8dp-Ed-ak6NoX_4Aeg_566010243")]
    [DisplayName("Tax Calculation Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnBsis")]
    #endif
    [IsoXmlTag("TaxClctnBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCalculationBasisType1Choice_? TaxCalculationBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculationBasisType1Choice_? TaxCalculationBasis { get; init; } 
    #else
    public TaxCalculationBasisType1Choice_? TaxCalculationBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that it is to be taxed.
    /// </summary>
    [IsoId("_SnOe8tp-Ed-ak6NoX_4Aeg_1830499782")]
    [DisplayName("Taxable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblAmt")]
    #endif
    [IsoXmlTag("TaxblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TaxableAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
