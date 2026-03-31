// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
[IsoId("_759LcKMgEeCJ6YNENx4h-w_896464386")]
[DisplayName("Message Header")]
public record MessageHeader3
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_759LcaMgEeCJ6YNENx4h-w_1835348211")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_759LcqMgEeCJ6YNENx4h-w_-174608647")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    [IsoId("_759Lc6MgEeCJ6YNENx4h-w_411338379")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    public RequestType2Choice_? RequestType { get; init; }

    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_759LdKMgEeCJ6YNENx4h-w_-2070821051")]
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }

    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    [IsoId("_759LdaMgEeCJ6YNENx4h-w_1901929233")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; }
}
