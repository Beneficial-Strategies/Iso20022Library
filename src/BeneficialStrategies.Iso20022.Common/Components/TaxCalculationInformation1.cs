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
[IsoId("_VSSXA9p-Ed-ak6NoX_4Aeg_1013966021")]
[DisplayName("Tax Calculation Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxCalculationInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_VSSXBNp-Ed-ak6NoX_4Aeg_-1422873809")]
    [DisplayName("Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bsis")]
    #endif
    [IsoXmlTag("Bsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxationBasis1? Basis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxationBasis1? Basis { get; init; } 
    #else
    public TaxationBasis1? Basis { get; set; } 
    #endif
    
    
    #nullable disable
    
}
