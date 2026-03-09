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
/// Details of confirmation in the CMU.
/// </summary>
[IsoId("_itJLUAJ-EeS2H9l84F_isg")]
[DisplayName("Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Confirmation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Confirmation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Confirmation1( TradeConfirmationStatus1Code reqConfirmationStatus,ConfirmationRequest1Code reqConfirmationType,MessageIdentification1 reqRequestIdentification,System.String reqQueryStartNumber,System.UInt64 reqTotalNumberOfReports,System.String reqPageNumber,System.String reqQueryPageNumber,System.UInt64 reqMessageNumberOfCurrentPage,System.UInt64 reqListOrderNumber,System.String reqLastPageIndicator,System.String reqLastReportRequested )
    {
        ConfirmationStatus = reqConfirmationStatus;
        ConfirmationType = reqConfirmationType;
        RequestIdentification = reqRequestIdentification;
        QueryStartNumber = reqQueryStartNumber;
        TotalNumberOfReports = reqTotalNumberOfReports;
        PageNumber = reqPageNumber;
        QueryPageNumber = reqQueryPageNumber;
        MessageNumberOfCurrentPage = reqMessageNumberOfCurrentPage;
        ListOrderNumber = reqListOrderNumber;
        LastPageIndicator = reqLastPageIndicator;
        LastReportRequested = reqLastReportRequested;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the confirmation.
    /// </summary>
    [IsoId("_B6YGkAKDEeS2H9l84F_isg")]
    [DisplayName("Confirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfSts")]
    #endif
    [IsoXmlTag("ConfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #else
    public TradeConfirmationStatus1Code ConfirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Time that both of parties confirm the trade.
    /// </summary>
    [IsoId("_RzrzQKazEeSxuMLA5o46jQ")]
    [DisplayName("Confirmation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfTm")]
    #endif
    [IsoXmlTag("ConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ConfirmationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ConfirmationTime { get; init; } 
    #else
    public System.DateTime? ConfirmationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time that the trade party confirms the trade.
    /// </summary>
    [IsoId("_OKoP4AKGEeS2H9l84F_isg")]
    [DisplayName("Trade Party Confirmation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPtyConfTm")]
    #endif
    [IsoXmlTag("TradPtyConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradePartyConfirmationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradePartyConfirmationTime { get; init; } 
    #else
    public System.DateTime? TradePartyConfirmationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time that the initiating party confirms the trade.
    /// </summary>
    [IsoId("_LLSw8AKGEeS2H9l84F_isg")]
    [DisplayName("Initiating Party Confirmation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPtyConfTm")]
    #endif
    [IsoXmlTag("InitgPtyConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? InitiatingPartyConfirmationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? InitiatingPartyConfirmationTime { get; init; } 
    #else
    public System.DateTime? InitiatingPartyConfirmationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of confirmation message being sent.
    /// </summary>
    [IsoId("_5a5sUIHYEeSY3ulMDfpmvA")]
    [DisplayName("Confirmation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfTp")]
    #endif
    [IsoXmlTag("ConfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConfirmationRequest1Code ConfirmationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConfirmationRequest1Code ConfirmationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationRequest1Code ConfirmationType { get; init; } 
    #else
    public ConfirmationRequest1Code ConfirmationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the confirm request messge.
    /// </summary>
    [IsoId("_8SUZAKaxEeSxuMLA5o46jQ")]
    [DisplayName("Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqId")]
    #endif
    [IsoXmlTag("ReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_MhL0UKayEeSxuMLA5o46jQ")]
    [DisplayName("Query Start Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryStartNb")]
    #endif
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35NumericText QueryStartNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueryStartNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueryStartNumber { get; init; } 
    #else
    public System.String QueryStartNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports returned in response to a request.
    /// </summary>
    [IsoId("_Wf7_4AKEEeS2H9l84F_isg")]
    [DisplayName("Total Number Of Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRpts")]
    #endif
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberOfReports { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfReports { get; init; } 
    #else
    public System.UInt64 TotalNumberOfReports { get; set; } 
    #endif
    
    /// <summary>
    /// Query results will be grouped with fixed number. The field indicates that the total number of groups.
    /// </summary>
    [IsoId("_YpefQAKEEeS2H9l84F_isg")]
    [DisplayName("Page Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PgNb")]
    #endif
    [IsoXmlTag("PgNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35NumericText PageNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PageNumber { get; init; } 
    #else
    public System.String PageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Page number in request result.
    /// </summary>
    [IsoId("_YXsvUKayEeSxuMLA5o46jQ")]
    [DisplayName("Query Page Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryPgNb")]
    #endif
    [IsoXmlTag("QryPgNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35NumericText QueryPageNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueryPageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueryPageNumber { get; init; } 
    #else
    public System.String QueryPageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of messages in current page.
    /// </summary>
    [IsoId("_CO9GQESsEeSTS-T7FO4CUQ")]
    [DisplayName("Message Number Of Current Page")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNbOfCurPg")]
    #endif
    [IsoXmlTag("MsgNbOfCurPg")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber MessageNumberOfCurrentPage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 MessageNumberOfCurrentPage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 MessageNumberOfCurrentPage { get; init; } 
    #else
    public System.UInt64 MessageNumberOfCurrentPage { get; set; } 
    #endif
    
    /// <summary>
    /// Number of reports at current page.
    /// </summary>
    [IsoId("_-32pYAKFEeS2H9l84F_isg")]
    [DisplayName("List Order Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListOrdrNb")]
    #endif
    [IsoXmlTag("ListOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ListOrderNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ListOrderNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ListOrderNumber { get; init; } 
    #else
    public System.UInt64 ListOrderNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether the current message is the last one of the current page or not.
    /// </summary>
    [IsoId("_eV2zQAKEEeS2H9l84F_isg")]
    [DisplayName("Last Page Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastPgInd")]
    #endif
    [IsoXmlTag("LastPgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator LastPageIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LastPageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LastPageIndicator { get; init; } 
    #else
    public System.String LastPageIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether this message is that last report message in response to a request.
    /// </summary>
    [IsoId("_B_YbAAKGEeS2H9l84F_isg")]
    [DisplayName("Last Report Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastRptReqd")]
    #endif
    [IsoXmlTag("LastRptReqd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator LastReportRequested { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LastReportRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LastReportRequested { get; init; } 
    #else
    public System.String LastReportRequested { get; set; } 
    #endif
    
    
    #nullable disable
    
}
