// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the meta data associated with a net report.
/// </summary>
[IsoId("_CWAzsQN1Ee2-vqzwMUAewg")]
[DisplayName("Net Report Data")]
public partial record NetReportData2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    [IsoId("_Cb9qsQN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the net report was generated.
    /// </summary>
    [IsoId("_Cb9qswN1Ee2-vqzwMUAewg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Provides the cut off time that has been passed, resulting in the generation of the net report.
    /// </summary>
    [IsoId("_Cb9qtQN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Cut Off Time")]
    [IsoXmlTag("NetgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime NettingCutOffTime { get; init; } 
    
    /// <summary>
    /// Specifies the value date on which the net report was generated.
    /// </summary>
    [IsoId("_Cb9qtwN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Date")]
    [IsoXmlTag("RptDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReportDate { get; init; } 
    
    /// <summary>
    /// Specifies the value date of the trades used in the generation of the net report.
    /// </summary>
    [IsoId("_Cb9quQN1Ee2-vqzwMUAewg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Specifies the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    [IsoId("_Cb9quwN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Type")]
    [IsoXmlTag("RptTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReportType { get; init; } 
    
    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    [IsoId("_Cb9qvQN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Report Servicer")]
    [IsoXmlTag("NetRptSvcr")]
    public PartyIdentification242Choice_? NetReportServicer { get; init; } 
    
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_Cb9qvwN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Type")]
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NetServiceType { get; init; } 
    
    /// <summary>
    /// Page number of the message (within the net report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_Cb9qwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; } 
    
    
    #nullable disable
    
}
