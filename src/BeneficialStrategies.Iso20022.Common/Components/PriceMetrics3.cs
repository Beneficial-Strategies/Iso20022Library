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
/// Numeric variables consisting in interest rates, lending fees or haircuts, calculated as weighted averages.
/// </summary>
[IsoId("_rpb5cc-nEeufOvGsyZiDWA")]
[DisplayName("Price Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceMetrics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Interest rate of the loan.
    /// </summary>
    [IsoId("_rsBTY8-nEeufOvGsyZiDWA")]
    [DisplayName("Rates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rates")]
    #endif
    [IsoXmlTag("Rates")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rates3? Rates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rates3? Rates { get; init; } 
    #else
    public Rates3? Rates { get; set; } 
    #endif
    
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    [IsoId("_rsBTZc-nEeufOvGsyZiDWA")]
    [DisplayName("Lending Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgFee")]
    #endif
    [IsoXmlTag("LndgFee")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? LendingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? LendingFee { get; init; } 
    #else
    public System.Decimal? LendingFee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
