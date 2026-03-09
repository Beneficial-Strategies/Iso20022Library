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
/// Set of elements of a cash distribution that will be withheld by a tax authority.
/// </summary>
[IsoId("_haio02liEeGaMcKyqKNRfQ_-1955007741")]
[DisplayName("Security With Holding Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityWithHoldingTax1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityWithHoldingTax1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityWithHoldingTax1( RateAndAmountFormat1Choice_ reqWithholdingTaxValue,string reqCountry )
    {
        WithholdingTaxValue = reqWithholdingTaxValue;
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the withholding tax as rate, amount or not specified.
    /// </summary>
    [IsoId("_haio1GliEeGaMcKyqKNRfQ_-987543376")]
    [DisplayName("Withholding Tax Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxVal")]
    #endif
    [IsoXmlTag("WhldgTaxVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateAndAmountFormat1Choice_ WithholdingTaxValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateAndAmountFormat1Choice_ WithholdingTaxValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat1Choice_ WithholdingTaxValue { get; init; } 
    #else
    public RateAndAmountFormat1Choice_ WithholdingTaxValue { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the tax authority.
    /// </summary>
    [IsoId("_haio1WliEeGaMcKyqKNRfQ_1903420370")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
