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
/// Original and corrected price information of an investment fund.
/// </summary>
[IsoId("_U1YYltp-Ed-ak6NoX_4Aeg_243480882")]
[DisplayName("Price Correction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceCorrection2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PriceCorrection2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceCorrection2( PriceValuation2 reqPreviouslySentPriceDetails )
    {
        PreviouslySentPriceDetails = reqPreviouslySentPriceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument sent in a previous price report.
    /// </summary>
    [IsoId("_U1YYl9p-Ed-ak6NoX_4Aeg_243480943")]
    [DisplayName("Previously Sent Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslySntPricDtls")]
    #endif
    [IsoXmlTag("PrevslySntPricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValuation2 PreviouslySentPriceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValuation2 PreviouslySentPriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValuation2 PreviouslySentPriceDetails { get; init; } 
    #else
    public PriceValuation2 PreviouslySentPriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the new price valuation of a financial instrument, which overrides previously sent information.
    /// </summary>
    [IsoId("_U1YYmNp-Ed-ak6NoX_4Aeg_243480909")]
    [DisplayName("Corrected Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrctdPricDtls")]
    #endif
    [IsoXmlTag("CrrctdPricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValuation2? CorrectedPriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValuation2? CorrectedPriceDetails { get; init; } 
    #else
    public PriceValuation2? CorrectedPriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U1YYmdp-Ed-ak6NoX_4Aeg_-884858901")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
