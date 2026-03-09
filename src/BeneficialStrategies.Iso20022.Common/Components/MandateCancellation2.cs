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
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_tlX48lkyEeGeoaLUQk__nA_1031601865")]
[DisplayName("Mandate Cancellation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateCancellation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateCancellation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateCancellation2( PaymentCancellationReason1 reqCancellationReason,OriginalMandate2Choice_ reqOriginalMandate )
    {
        CancellationReason = reqCancellationReason;
        OriginalMandate = reqOriginalMandate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_tlX481kyEeGeoaLUQk__nA_-257428226")]
    [DisplayName("Original Message Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgInf")]
    #endif
    [IsoXmlTag("OrgnlMsgInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    #else
    public OriginalMessageInformation1? OriginalMessageInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_tlX49FkyEeGeoaLUQk__nA_503336927")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCancellationReason1 CancellationReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCancellationReason1 CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationReason1 CancellationReason { get; init; } 
    #else
    public PaymentCancellationReason1 CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_tlhp8FkyEeGeoaLUQk__nA_33260517")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMandate2Choice_ OriginalMandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMandate2Choice_ OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate2Choice_ OriginalMandate { get; init; } 
    #else
    public OriginalMandate2Choice_ OriginalMandate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
