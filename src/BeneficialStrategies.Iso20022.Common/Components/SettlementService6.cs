// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Service6.
/// </summary>
[IsoId("_XD-0MXjVEe6YlIMyoxWMJA")]
[DisplayName("Settlement Service6")]
public partial record SettlementService6
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalData1> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Cut Off Time.
    /// </summary>
    [DisplayName("Cut Off Time")]
    [IsoXmlTag("CutOffTm")]
    public IsoISODateTime? CutOffTime { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Deferred.
    /// </summary>
    [DisplayName("Deferred")]
    [IsoXmlTag("Dfrrd")]
    public IsoTrueFalseIndicator? Deferred { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; } 

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public IsoMax35Text? Period { get; init; } 

    /// <summary>
    /// Reporting Entity Identification.
    /// </summary>
    [DisplayName("Reporting Entity Identification")]
    [IsoXmlTag("RptgNttyId")]
    public IsoMax35Text? ReportingEntityIdentification { get; init; } 

    /// <summary>
    /// Reporting Entity Type.
    /// </summary>
    [DisplayName("Reporting Entity Type")]
    [IsoXmlTag("RptgNttyTp")]
    public IsoMax35Text? ReportingEntityType { get; init; } 

    /// <summary>
    /// Requested Date.
    /// </summary>
    [DisplayName("Requested Date")]
    [IsoXmlTag("ReqdDt")]
    public IsoISODate? RequestedDate { get; init; } 

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; } 

    
    #nullable disable
    
}
