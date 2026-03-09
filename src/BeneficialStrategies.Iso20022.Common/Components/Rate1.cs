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
/// Set of elements qualifying the interest rate.
/// </summary>
[IsoId("_SRnbU9p-Ed-ak6NoX_4Aeg_36879442")]
[DisplayName("Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Rate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Rate1( RateTypeChoice_ reqRate )
    {
        Rate = reqRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument. |Example percentage rate: Rate expressed as a percentage, ie, in hundredths, eg, 0.7 is 7/10 of a percent, and 7.0 is 7%.|Example Textual rate: Rate is expressed as a text.
    /// </summary>
    [IsoId("_SRnbVNp-Ed-ak6NoX_4Aeg_225276293")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateTypeChoice_ Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateTypeChoice_ Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateTypeChoice_ Rate { get; init; } 
    #else
    public RateTypeChoice_ Rate { get; set; } 
    #endif
    
    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    [IsoId("_SRnbVdp-Ed-ak6NoX_4Aeg_-1476444438")]
    [DisplayName("Validity Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyRg")]
    #endif
    [IsoXmlTag("VldtyRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmountRange? ValidityRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmountRange? ValidityRange { get; init; } 
    #else
    public CurrencyAndAmountRange? ValidityRange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
