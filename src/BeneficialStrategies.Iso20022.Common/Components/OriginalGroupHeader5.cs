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
/// Provides the details on the original group, to which the message refers.
/// </summary>
[IsoId("_sevoEFkyEeGeoaLUQk__nA_1903063845")]
[DisplayName("Original Group Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalGroupHeader5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalGroupHeader5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalGroupHeader5( System.String reqOriginalMessageIdentification,System.String reqOriginalMessageNameIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        OriginalMessageNameIdentification = reqOriginalMessageNameIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original group cancellation request.
    /// </summary>
    [IsoId("_sevoEVkyEeGeoaLUQk__nA_1828154802")]
    [DisplayName("Original Group Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpCxlId")]
    #endif
    [IsoXmlTag("OrgnlGrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalGroupCancellationIdentification { get; init; } 
    #else
    public System.String? OriginalGroupCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_sevoElkyEeGeoaLUQk__nA_781447190")]
    [DisplayName("Resolved Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RslvdCase")]
    #endif
    [IsoXmlTag("RslvdCase")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case3? ResolvedCase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3? ResolvedCase { get; init; } 
    #else
    public Case3? ResolvedCase { get; set; } 
    #endif
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_se5ZEFkyEeGeoaLUQk__nA_-2073459261")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageIdentification { get; init; } 
    #else
    public System.String OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_sfCjAFkyEeGeoaLUQk__nA_-1546463318")]
    [DisplayName("Original Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgNmId")]
    #endif
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageNameIdentification { get; init; } 
    #else
    public System.String OriginalMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_sfCjAVkyEeGeoaLUQk__nA_-769709024")]
    [DisplayName("Original Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCreDtTm")]
    #endif
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalCreationDateTime { get; init; } 
    #else
    public System.DateTime? OriginalCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_sfCjAlkyEeGeoaLUQk__nA_-1365213817")]
    [DisplayName("Original Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNbOfTxs")]
    #endif
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalNumberOfTransactions { get; init; } 
    #else
    public System.String? OriginalNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_sfCjA1kyEeGeoaLUQk__nA_1049447839")]
    [DisplayName("Original Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCtrlSum")]
    #endif
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OriginalControlSum { get; init; } 
    #else
    public System.UInt64? OriginalControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a group cancellation request.
    /// </summary>
    [IsoId("_sfMUAFkyEeGeoaLUQk__nA_-1376312594")]
    [DisplayName("Group Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpCxlSts")]
    #endif
    [IsoXmlTag("GrpCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 
    #else
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_sfMUAVkyEeGeoaLUQk__nA_746391324")]
    [DisplayName("Cancellation Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlStsRsnInf")]
    #endif
    [IsoXmlTag("CxlStsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    #else
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_sfMUAlkyEeGeoaLUQk__nA_-1790738466")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxsPerCxlSts")]
    #endif
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #else
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
