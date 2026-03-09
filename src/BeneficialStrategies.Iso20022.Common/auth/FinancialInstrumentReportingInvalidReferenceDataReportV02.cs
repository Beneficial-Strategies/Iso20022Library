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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.042.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument.
/// </summary>
[Description(@"The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument.")]
[IsoId("_vXohoSdoEei12pGEsJIAeQ")]
[DisplayName("Financial Instrument Reporting Invalid Reference Data Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingInvalidReferenceDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.042.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgInvldRefDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.042.001.02";
    
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
    /// Constructs a FinancialInstrumentReportingInvalidReferenceDataReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingInvalidReferenceDataReportV02( Period4Choice_ reqDatePeriod,SecuritiesInvalidReferenceDataReport4 reqFinancialInstruments )
    {
        DatePeriod = reqDatePeriod;
        FinancialInstruments = reqFinancialInstruments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date period capturing when instruments in the report have been invalidated
    /// Usage:
    /// Within MiFIR, only the From Date To Date field will be used with the From Date corresponding to the date the first instrument was added to this report while the To Date is the date the last instrument was added to the file.
    /// </summary>
    [IsoId("_vXohoydoEei12pGEsJIAeQ")]
    [DisplayName("Date Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtPrd")]
    #endif
    [IsoXmlTag("DtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4Choice_ DatePeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4Choice_ DatePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_ DatePeriod { get; init; } 
    #else
    public Period4Choice_ DatePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Number of invalid records in this message.
    /// </summary>
    [IsoId("_vXohpSdoEei12pGEsJIAeQ")]
    [DisplayName("Number Of Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfRcrds")]
    #endif
    [IsoXmlTag("NbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfRecords { get; init; } 
    #else
    public System.UInt64? NumberOfRecords { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the financial instruments.
    /// </summary>
    [IsoId("_vXohpydoEei12pGEsJIAeQ")]
    [DisplayName("Financial Instruments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrms")]
    #endif
    [IsoXmlTag("FinInstrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesInvalidReferenceDataReport4 FinancialInstruments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesInvalidReferenceDataReport4 FinancialInstruments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesInvalidReferenceDataReport4 FinancialInstruments { get; init; } 
    #else
    public SecuritiesInvalidReferenceDataReport4 FinancialInstruments { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vXohqSdoEei12pGEsJIAeQ")]
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


// Since FinancialInstrumentReportingInvalidReferenceDataReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingInvalidReferenceDataReportV02.

