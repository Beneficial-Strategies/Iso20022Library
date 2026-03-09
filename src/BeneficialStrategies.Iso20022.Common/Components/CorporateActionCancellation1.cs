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
/// Corporate action event cancellation status and reason.
/// </summary>
[IsoId("_UKK4Ytp-Ed-ak6NoX_4Aeg_237834559")]
[DisplayName("Corporate Action Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionCancellation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionCancellation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionCancellation1( CorporateActionCancellationReason1Code reqCancellationReasonCode,CorporateActionProcessingStatus1Choice_ reqProcessingStatus )
    {
        CancellationReasonCode = reqCancellationReasonCode;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    [IsoId("_UKK4Y9p-Ed-ak6NoX_4Aeg_564761395")]
    [DisplayName("Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnCd")]
    #endif
    [IsoXmlTag("CxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    #else
    public CorporateActionCancellationReason1Code CancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    [IsoId("_UKK4ZNp-Ed-ak6NoX_4Aeg_578612831")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReason { get; init; } 
    #else
    public System.String? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_UKK4Zdp-Ed-ak6NoX_4Aeg_176414226")]
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
    
    
    #nullable disable
    
}
