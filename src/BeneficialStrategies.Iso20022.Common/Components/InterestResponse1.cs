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
/// Provides details about the reponse to the interest payment request.
/// </summary>
[IsoId("_Qki1hNp-Ed-ak6NoX_4Aeg_1044109408")]
[DisplayName("Interest Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestResponse1( Status4Code reqResponseType,System.String reqInterestPaymentRequestIdentification )
    {
        ResponseType = reqResponseType;
        InterestPaymentRequestIdentification = reqInterestPaymentRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the type of the response, either accepted or rejected.
    /// </summary>
    [IsoId("_Qki1hdp-Ed-ak6NoX_4Aeg_-1991695647")]
    [DisplayName("Response Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnTp")]
    #endif
    [IsoXmlTag("RspnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status4Code ResponseType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status4Code ResponseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status4Code ResponseType { get; init; } 
    #else
    public Status4Code ResponseType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a reason for rejection identified using a code or a proprietary format.
    /// </summary>
    [IsoId("_Qki1htp-Ed-ak6NoX_4Aeg_749006670")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionReason21FormatChoice_? RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason21FormatChoice_? RejectionReason { get; init; } 
    #else
    public RejectionReason21FormatChoice_? RejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the rejection reason.
    /// </summary>
    [IsoId("_Qki1h9p-Ed-ak6NoX_4Aeg_-1579101885")]
    [DisplayName("Rejection Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsnInf")]
    #endif
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? RejectionReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectionReasonInformation { get; init; } 
    #else
    public System.String? RejectionReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_Qki1iNp-Ed-ak6NoX_4Aeg_1472856857")]
    [DisplayName("Interest Payment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtReqId")]
    #endif
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InterestPaymentRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InterestPaymentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InterestPaymentRequestIdentification { get; init; } 
    #else
    public System.String InterestPaymentRequestIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
