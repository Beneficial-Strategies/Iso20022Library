// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Service6.
/// </summary>
[IsoId("_XD-0MXjVEe6YlIMyoxWMJA")]
[DisplayName("Settlement Service6")]
public partial record SettlementService6
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public Max35Text? Type { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Max35Text? Identification { get; init; }

    /// <summary>
    /// Requested Date.
    /// </summary>
    [DisplayName("Requested Date")]
    [IsoXmlTag("ReqdDt")]
    public ISODate? RequestedDate { get; init; }

    /// <summary>
    /// Deferred.
    /// </summary>
    [DisplayName("Deferred")]
    [IsoXmlTag("Dfrrd")]
    public TrueFalseIndicator? Deferred { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public ISODate? Date { get; init; }

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public ISOTime? Time { get; init; }

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public Max35Text? Period { get; init; }

    /// <summary>
    /// Cut Off Time.
    /// </summary>
    [DisplayName("Cut Off Time")]
    [IsoXmlTag("CutOffTm")]
    public ISODateTime? CutOffTime { get; init; }

    /// <summary>
    /// Reporting Entity Type.
    /// </summary>
    [DisplayName("Reporting Entity Type")]
    [IsoXmlTag("RptgNttyTp")]
    public Max35Text? ReportingEntityType { get; init; }

    /// <summary>
    /// Reporting Entity Identification.
    /// </summary>
    [DisplayName("Reporting Entity Identification")]
    [IsoXmlTag("RptgNttyId")]
    public Max35Text? ReportingEntityIdentification { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalData1> AdditionalInformation { get; init; } = [];
}
