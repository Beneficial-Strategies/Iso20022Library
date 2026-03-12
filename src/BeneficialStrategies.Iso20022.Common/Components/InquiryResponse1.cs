// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the inquiry response message.
/// </summary>
[IsoId("_gk0NkVfjEeeg8PDQoAs78Q")]
[DisplayName("Inquiry Response")]
public partial record InquiryResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_gygrUVfjEeeg8PDQoAs78Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment15 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_mzS0Ed8REeeNTcLLmuYy-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context2 Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_gygrVVfjEeeg8PDQoAs78Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction87 Transaction { get; init; } 
    
    /// <summary>
    /// Result of the inquiry processing.
    /// </summary>
    [IsoId("_xSGF8e-_EeeJbIMlSHFAag")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult5 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_gygrV1fjEeeg8PDQoAs78Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_u0higdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_5YDqUaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
