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
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_U5QL9dp-Ed-ak6NoX_4Aeg_1827324489")]
[DisplayName("Total Taxes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalTaxes2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the taxes for a specific order.
    /// </summary>
    [IsoId("_U5QL9tp-Ed-ak6NoX_4Aeg_1827324679")]
    [DisplayName("Total Amount Of Taxes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtOfTaxs")]
    #endif
    [IsoXmlTag("TtlAmtOfTaxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_U5QL99p-Ed-ak6NoX_4Aeg_1827325403")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax7> TaxDetails { get; init; } = new ValueList<Tax7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _U5QL99p-Ed-ak6NoX_4Aeg_1827325403
    
    
    #nullable disable
    
}
