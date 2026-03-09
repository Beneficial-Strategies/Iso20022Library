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
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_QxNYhdp-Ed-ak6NoX_4Aeg_206813968")]
[DisplayName("Corporate Action Preliminary Advice Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPreliminaryAdviceType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionPreliminaryAdviceType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionPreliminaryAdviceType1( CorporateActionPreliminaryAdviceType1Code reqType,CorporateActionProcessingStatus1Choice_ reqProcessingStatus )
    {
        Type = reqType;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of movement preliminary advice ie. new or replacement.
    /// </summary>
    [IsoId("_QxNYhtp-Ed-ak6NoX_4Aeg_-140554685")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #else
    public CorporateActionPreliminaryAdviceType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_QxNYh9p-Ed-ak6NoX_4Aeg_1529675202")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; init; } 
    #else
    public CorporateActionProcessingStatus1Choice_ ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the movement preliminary advice is sent after entitlement date.
    /// Value is Yes (true) if sent after entitlement date and No (false) if sent before entitlement date.
    /// </summary>
    [IsoId("_QxNYiNp-Ed-ak6NoX_4Aeg_-1422220686")]
    [DisplayName("Eligibility Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltyInd")]
    #endif
    [IsoXmlTag("ElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibilityIndicator { get; init; } 
    #else
    public System.String? EligibilityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
