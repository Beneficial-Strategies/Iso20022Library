// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information.
/// </summary>
[IsoId("_ho71Md1BEeqW_oCeEFhoHw")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation25
{
    #nullable enable
    
    /// <summary>
    /// Type of query.
    /// </summary>
    [IsoId("_h9nrwd1BEeqW_oCeEFhoHw")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public GenericIdentification36? QueryType { get; init; } 
    
    /// <summary>
    /// Description of the query.
    /// </summary>
    [IsoId("_h9nrw91BEeqW_oCeEFhoHw")]
    [DisplayName("Query")]
    [IsoXmlTag("Qry")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Query { get; init; } 
    
    /// <summary>
    /// Reason for the query.
    /// </summary>
    [IsoId("_t-VEkN1BEeqW_oCeEFhoHw")]
    [DisplayName("Query Reason")]
    [IsoXmlTag("QryRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? QueryReason { get; init; } 
    
    /// <summary>
    /// Reason the instruction was rejected.
    /// </summary>
    [IsoId("_x1W5IN1EEeqW_oCeEFhoHw")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectedReason33Choice_? RejectionReason { get; init; } 
    
    
    #nullable disable
    
}
