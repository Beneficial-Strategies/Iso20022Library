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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_SdiXeNp-Ed-ak6NoX_4Aeg_-1800133123")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument18( SecurityIdentification9 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_SdiXedp-Ed-ak6NoX_4Aeg_-1800133121")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification9 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification9 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification9 Identification { get; init; } 
    #else
    public SecurityIdentification9 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_SdiXetp-Ed-ak6NoX_4Aeg_-1800133062")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Date that identifies the issue of a fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription order, if known.
    /// </summary>
    [IsoId("_SdsIcNp-Ed-ak6NoX_4Aeg_-798661529")]
    [DisplayName("Series Issue Identification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrsIsseIdDt")]
    #endif
    [IsoXmlTag("SrsIsseIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SeriesIssueIdentificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SeriesIssueIdentificationDate { get; init; } 
    #else
    public System.DateOnly? SeriesIssueIdentificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the name of a fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription, if known.
    /// </summary>
    [IsoId("_SdsIcdp-Ed-ak6NoX_4Aeg_971691708")]
    [DisplayName("Series Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrsNm")]
    #endif
    [IsoXmlTag("SrsNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SeriesName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SeriesName { get; init; } 
    #else
    public System.String? SeriesName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the financial instrument and/or series included in the message is a new issue.
    /// </summary>
    [IsoId("_SdsIctp-Ed-ak6NoX_4Aeg_-2097762260")]
    [DisplayName("New Issue Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewIsseInd")]
    #endif
    [IsoXmlTag("NewIsseInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NewIssueIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewIssueIndicator { get; init; } 
    #else
    public System.String? NewIssueIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_SdsIc9p-Ed-ak6NoX_4Aeg_-1800133031")]
    [DisplayName("Supplementary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryId")]
    #endif
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupplementaryIdentification { get; init; } 
    #else
    public System.String? SupplementaryIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
