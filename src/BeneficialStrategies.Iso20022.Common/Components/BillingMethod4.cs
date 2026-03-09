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
/// Provides the details for the tax calculation method C.
/// </summary>
[IsoId("_6QGNo5qlEeGSON8vddiWzQ_288570123")]
[DisplayName("Billing Method")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingMethod4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingMethod4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingMethod4( TaxCalculation1 reqTaxCalculation )
    {
        TaxCalculation = reqTaxCalculation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the details of the taxable services using tax calculation method C.
    /// </summary>
    [IsoId("_6QGNpJqlEeGSON8vddiWzQ_-708502230")]
    [DisplayName("Service Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDtl")]
    #endif
    [IsoXmlTag("SvcDtl")]
    public ValueList<BillingServiceParameters2> ServiceDetail { get; init; } = new ValueList<BillingServiceParameters2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6QGNpJqlEeGSON8vddiWzQ_-708502230
    
    /// <summary>
    /// Total amount of service charge to be taxed in the tax region’s host currency along with the supporting tax calculations. ||Usage: Used for tax calculation method C only, and only one per tax region may be specified.
    /// </summary>
    [IsoId("_6QGNpZqlEeGSON8vddiWzQ_-1819413649")]
    [DisplayName("Tax Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctn")]
    #endif
    [IsoXmlTag("TaxClctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxCalculation1 TaxCalculation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxCalculation1 TaxCalculation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculation1 TaxCalculation { get; init; } 
    #else
    public TaxCalculation1 TaxCalculation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
