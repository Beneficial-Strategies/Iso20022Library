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
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_RBcz9tp-Ed-ak6NoX_4Aeg_-453440412")]
[DisplayName("Mandate Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAmendment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateAmendment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAmendment1( AmendmentReasonInformation1 reqAmendmentReason,MandateInformation3 reqMandate,OriginalMandate1Choice_ reqOriginalMandate )
    {
        AmendmentReason = reqAmendmentReason;
        Mandate = reqMandate;
        OriginalMandate = reqOriginalMandate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_RBcz99p-Ed-ak6NoX_4Aeg_344631630")]
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
    /// Set of elements used to provide detailed information on the amendment reason.
    /// </summary>
    [IsoId("_RBcz-Np-Ed-ak6NoX_4Aeg_-995812636")]
    [DisplayName("Amendment Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntRsn")]
    #endif
    [IsoXmlTag("AmdmntRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmendmentReasonInformation1 AmendmentReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmendmentReasonInformation1 AmendmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendmentReasonInformation1 AmendmentReason { get; init; } 
    #else
    public AmendmentReasonInformation1 AmendmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide the amended mandate data.
    /// </summary>
    [IsoId("_RBmk8Np-Ed-ak6NoX_4Aeg_-1140806205")]
    [DisplayName("Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mndt")]
    #endif
    [IsoXmlTag("Mndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateInformation3 Mandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MandateInformation3 Mandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateInformation3 Mandate { get; init; } 
    #else
    public MandateInformation3 Mandate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    [IsoId("_RBmk8dp-Ed-ak6NoX_4Aeg_75619015")]
    [DisplayName("Original Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMndt")]
    #endif
    [IsoXmlTag("OrgnlMndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMandate1Choice_ OriginalMandate { get; init; } 
    #else
    public OriginalMandate1Choice_ OriginalMandate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
