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
/// Provides the Invoice tax status report header details.
/// </summary>
[IsoId("_I_Tr4U52Eeaine-lsNAGsA")]
[DisplayName("Invoice Tax Status Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceTaxStatusReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceTaxStatusReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceTaxStatusReportHeader1( MessageIdentification1 reqMessageIdentification,MessageIdentification1 reqOriginalMessageIdentification,TaxReportingStatus1Code reqReportStatus )
    {
        MessageIdentification = reqMessageIdentification;
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        ReportStatus = reqReportStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party to which the TaxReport is delivered. This message block contains party details for a specific tax authority.
    /// </summary>
    [IsoId("_6iFdwGqXEea_XZixF5unWQ")]
    [DisplayName("Tax Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAuthrty")]
    #endif
    [IsoXmlTag("TaxAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxOrganisationIdentification1? TaxAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxOrganisationIdentification1? TaxAuthority { get; init; } 
    #else
    public TaxOrganisationIdentification1? TaxAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the InvoiceTaxReportStatusAdvice message.
    /// </summary>
    [IsoId("_bLfvgE52Eeaine-lsNAGsA")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the InvoiceTaxReport message.
    /// </summary>
    [IsoId("_W1dt8E53Eeaine-lsNAGsA")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 OriginalMessageIdentification { get; init; } 
    #else
    public MessageIdentification1 OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_JIHClU52Eeaine-lsNAGsA")]
    [DisplayName("Report Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSts")]
    #endif
    [IsoXmlTag("RptSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxReportingStatus1Code ReportStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxReportingStatus1Code ReportStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReportingStatus1Code ReportStatus { get; init; } 
    #else
    public TaxReportingStatus1Code ReportStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_JIHCl052Eeaine-lsNAGsA")]
    [DisplayName("Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnRule")]
    #endif
    [IsoXmlTag("VldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? ValidationRule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
