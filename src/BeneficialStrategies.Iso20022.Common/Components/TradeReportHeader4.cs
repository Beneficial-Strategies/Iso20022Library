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
/// Provides the details of the header for a trade transaction query message.
/// </summary>
[IsoId("_hxrf4RZ6Ee27wrM4RUjLog")]
[DisplayName("Trade Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeReportHeader4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeReportHeader4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeReportHeader4( System.UInt64 reqNumberRecords )
    {
        NumberRecords = reqNumberRecords;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the as-at day for which the report was produced.
    /// </summary>
    [IsoId("_hzTQgRZ6Ee27wrM4RUjLog")]
    [DisplayName("Report Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptExctnDt")]
    #endif
    [IsoXmlTag("RptExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ReportExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ReportExecutionDate { get; init; } 
    #else
    public System.DateOnly? ReportExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within the report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_hzTQgxZ6Ee27wrM4RUjLog")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? MessagePagination { get; init; } 
    #else
    public Pagination1? MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the number of records in the page.
    /// </summary>
    [IsoId("_hzTQhRZ6Ee27wrM4RUjLog")]
    [DisplayName("Number Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbRcrds")]
    #endif
    [IsoXmlTag("NbRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberRecords { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberRecords { get; init; } 
    #else
    public System.UInt64 NumberRecords { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the competent authority that requires reporting of the transaction.
    /// </summary>
    [IsoId("_hzTQhxZ6Ee27wrM4RUjLog")]
    [DisplayName("Competent Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmptntAuthrty")]
    #endif
    [IsoXmlTag("CmptntAuthrty")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? CompetentAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompetentAuthority { get; init; } 
    #else
    public System.String? CompetentAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the new trade repository to which the derivative is transfered to.
    /// </summary>
    [IsoId("_hzTQiRZ6Ee27wrM4RUjLog")]
    [DisplayName("New Trade Repository Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewTradRpstryIdr")]
    #endif
    [IsoXmlTag("NewTradRpstryIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification15Choice_? NewTradeRepositoryIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification15Choice_? NewTradeRepositoryIdentifier { get; init; } 
    #else
    public OrganisationIdentification15Choice_? NewTradeRepositoryIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for reporting the derivative transaction.
    /// </summary>
    [IsoId("_Uu4gsCLrEe2KAJot-YBP6w")]
    [DisplayName("Reporting Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPurp")]
    #endif
    [IsoXmlTag("RptgPurp")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? ReportingPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportingPurpose { get; init; } 
    #else
    public System.String? ReportingPurpose { get; set; } 
    #endif
    
    
    #nullable disable
    
}
