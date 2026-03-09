// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.062.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PayInSchedule message is sent by a central settlement system to the participant to provide notification of a series of timed payments scheduled for each currency at the time and date of the schedule generation. The central settlement system may send information about how the timed payments have been calculated.
/// </summary>
[Description(@"The PayInSchedule message is sent by a central settlement system to the participant to provide notification of a series of timed payments scheduled for each currency at the time and date of the schedule generation. The central settlement system may send information about how the timed payments have been calculated.")]
[IsoId("_KfNcsS43EeK7-OZOLIksSw")]
[DisplayName("Pay In Schedule V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayInScheduleV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.062.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PayInSchdl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.062.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PayInScheduleV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayInScheduleV03( PartyIdentification73Choice_ reqPartyIdentification,ReportData4 reqReportData )
    {
        PartyIdentification = reqPartyIdentification;
        ReportData = reqReportData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_KfNctS43EeK7-OZOLIksSw")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification73Choice_ PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification73Choice_ PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_ PartyIdentification { get; init; } 
    #else
    public PartyIdentification73Choice_ PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information applicable to the report.
    /// </summary>
    [IsoId("_KfNcuS43EeK7-OZOLIksSw")]
    [DisplayName("Report Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptData")]
    #endif
    [IsoXmlTag("RptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportData4 ReportData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportData4 ReportData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportData4 ReportData { get; init; } 
    #else
    public ReportData4 ReportData { get; set; } 
    #endif
    
    /// <summary>
    /// Projected net position for all currencies, projected long for the value date.
    /// </summary>
    [IsoId("_KfNcvS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Schedule Long Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PayInSchdlLngBal")]
    #endif
    [IsoXmlTag("PayInSchdlLngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceStatus2? PayInScheduleLongBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceStatus2? PayInScheduleLongBalance { get; init; } 
    #else
    public BalanceStatus2? PayInScheduleLongBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and total amount to be paid in by the corresponding deadline.
    /// </summary>
    [IsoId("_KfNcwS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Schedule Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PayInSchdlItm")]
    #endif
    [IsoXmlTag("PayInSchdlItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PayInScheduleItems1? PayInScheduleItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PayInScheduleItems1? PayInScheduleItem { get; init; } 
    #else
    public PayInScheduleItems1? PayInScheduleItem { get; set; } 
    #endif
    
    /// <summary>
    /// Factors used in the calculation of the pay-in schedule.
    /// </summary>
    [IsoId("_KfNcxS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Factors")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PayInFctrs")]
    #endif
    [IsoXmlTag("PayInFctrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PayInFactors1? PayInFactors { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PayInFactors1? PayInFactors { get; init; } 
    #else
    public PayInFactors1? PayInFactors { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DTaJUS53EeKwTrPDLMbLxA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PayInScheduleV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PayInScheduleV03.

