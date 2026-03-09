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
/// The final result of a single invoice financing request.
/// </summary>
[IsoId("_TiFktdp-Ed-ak6NoX_4Aeg_1101123529")]
[DisplayName("Financing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingResult1( RequestStatus1Code reqFinancingRequestStatus )
    {
        FinancingRequestStatus = reqFinancingRequestStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the financing request (e.g. financed. not financed).
    /// </summary>
    [IsoId("_TiFkttp-Ed-ak6NoX_4Aeg_352221392")]
    [DisplayName("Financing Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgReqSts")]
    #endif
    [IsoXmlTag("FincgReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestStatus1Code FinancingRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestStatus1Code FinancingRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestStatus1Code FinancingRequestStatus { get; init; } 
    #else
    public RequestStatus1Code FinancingRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reasons that have determined the result of the single request.
    /// </summary>
    [IsoId("_TiFkt9p-Ed-ak6NoX_4Aeg_564525140")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReason4Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReason4Choice_? StatusReason { get; init; } 
    #else
    public StatusReason4Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the status reason.
    /// </summary>
    [IsoId("_TiFkuNp-Ed-ak6NoX_4Aeg_-99752141")]
    [DisplayName("Additional Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStsRsnInf")]
    #endif
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatusReasonInformation { get; init; } 
    #else
    public System.String? AdditionalStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates amount financed related to the request.
    /// </summary>
    [IsoId("_TiOuoNp-Ed-ak6NoX_4Aeg_603605189")]
    [DisplayName("Financed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincdAmt")]
    #endif
    [IsoXmlTag("FincdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancingRateOrAmountChoice_? FinancedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingRateOrAmountChoice_? FinancedAmount { get; init; } 
    #else
    public FinancingRateOrAmountChoice_? FinancedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
