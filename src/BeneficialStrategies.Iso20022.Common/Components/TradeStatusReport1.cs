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
/// Details of the trade status report.
/// </summary>
[IsoId("_-C4P-HltEeG7BsjMvd1mEw_2067370861")]
[DisplayName("Trade Status Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeStatusReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeStatusReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeStatusReport1( OriginalMessage1 reqOriginalMessageDetails,UndertakingStatus1Code reqStatus )
    {
        OriginalMessageDetails = reqOriginalMessageDetails;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information concerning the original message to which the TradeStatusReport is sent in response.
    /// </summary>
    [IsoId("_-C4P-XltEeG7BsjMvd1mEw_420163937")]
    [DisplayName("Original Message Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgDtls")]
    #endif
    [IsoXmlTag("OrgnlMsgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMessage1 OriginalMessageDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMessage1 OriginalMessageDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessage1 OriginalMessageDetails { get; init; } 
    #else
    public OriginalMessage1 OriginalMessageDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the processing status of the original message.
    /// </summary>
    [IsoId("_-DCA8HltEeG7BsjMvd1mEw_95108517")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingStatus1Code Status { get; init; } 
    #else
    public UndertakingStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_-DCA8XltEeG7BsjMvd1mEw_-415310632")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation8? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation8? StatusReason { get; init; } 
    #else
    public StatusReasonInformation8? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the report.
    /// </summary>
    [IsoId("_-DCA8nltEeG7BsjMvd1mEw_-952635895")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
