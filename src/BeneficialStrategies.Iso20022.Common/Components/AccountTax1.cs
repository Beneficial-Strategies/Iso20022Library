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
/// Describes account taxing parameters.
/// </summary>
[IsoId("_6TYLKJqlEeGSON8vddiWzQ_-1311079011")]
[DisplayName("Account Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountTax1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountTax1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountTax1( BillingTaxCalculationMethod1Code reqCalculationMethod )
    {
        CalculationMethod = reqCalculationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the calculation method on how the taxes are applied on the account.
    /// </summary>
    [IsoId("_6TYLKZqlEeGSON8vddiWzQ_-1424918077")]
    [DisplayName("Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnMtd")]
    #endif
    [IsoXmlTag("ClctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BillingTaxCalculationMethod1Code CalculationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BillingTaxCalculationMethod1Code CalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingTaxCalculationMethod1Code CalculationMethod { get; init; } 
    #else
    public BillingTaxCalculationMethod1Code CalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the tax region in which the account resides.
    /// </summary>
    [IsoId("_6TYLKpqlEeGSON8vddiWzQ_1872976866")]
    [DisplayName("Region")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rgn")]
    #endif
    [IsoXmlTag("Rgn")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax40Text? Region { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Region { get; init; } 
    #else
    public System.String? Region { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the country of residence, when the account owner does not reside in the account&apos;s tax region.||Usage: If present, the account owner does not reside in the account&apos;s tax region.
    /// </summary>
    [IsoId("_6TYLK5qlEeGSON8vddiWzQ_-765795978")]
    [DisplayName("Non Residence Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonResCtry")]
    #endif
    [IsoXmlTag("NonResCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidenceLocation1Choice_? NonResidenceCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidenceLocation1Choice_? NonResidenceCountry { get; init; } 
    #else
    public ResidenceLocation1Choice_? NonResidenceCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
