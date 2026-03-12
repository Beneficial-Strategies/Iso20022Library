// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies technical attributes of the message.
/// </summary>
[IsoId("_zQe54Th4Ee2PxMOcF-jxEw")]
[DisplayName("Technical Attributes")]
public partial record TechnicalAttributes6
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_zXW98Th4Ee2PxMOcF-jxEw")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the receipt of the submission of the report to the trade repository as recorded by the trade repository. This item should only be present in a message from the trade repository to an authority and/or other recipients of the message.
    /// </summary>
    [IsoId("_zXW99Th4Ee2PxMOcF-jxEw")]
    [DisplayName("Report Receipt Time Stamp")]
    [IsoXmlTag("RptRctTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReportReceiptTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
