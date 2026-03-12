// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the message(s) which should be resent.
/// </summary>
[IsoId("_jJzloO5NEeCisYr99QEiWA_840208955")]
[DisplayName("Resend Search Criteria")]
public partial record ResendSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Date of the business day of the requested messages the resend function is used for.
    /// </summary>
    [IsoId("_jJzloe5NEeCisYr99QEiWA_2072733843")]
    [DisplayName("Business Date")]
    [IsoXmlTag("BizDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BusinessDate { get; init; } 
    
    /// <summary>
    /// Independent counter for message sequence, which is available once per party technical address.|Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_jJzlou5NEeCisYr99QEiWA_-1176991045")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Unambiguously identifies the original business message, which was delivered by the business sender.
    /// </summary>
    [IsoId("_hdq1QGliEeGaMcKyqKNRfQ_1962590125")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_jJzlo-5NEeCisYr99QEiWA_-595981789")]
    [DisplayName("File Reference")]
    [IsoXmlTag("FileRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FileReference { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the recipient of the report message.
    /// </summary>
    [IsoId("_jJzlpO5NEeCisYr99QEiWA_-493610823")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required PartyIdentification71Choice_ Recipient { get; init; } 
    
    
    #nullable disable
    
}
