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
[IsoId("_i375p5IhEeect698_YsnIA")]
[DisplayName("Message Header")]
public record MessageHeader8
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_jATLc5IhEeect698_YsnIA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_jATLdZIhEeect698_YsnIA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Pagination of the message.|Usage: the pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_jATLd5IhEeect698_YsnIA")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }

    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_jATLeZIhEeect698_YsnIA")]
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }

    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    [IsoId("_jATLe5IhEeect698_YsnIA")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    public RequestType4Choice_? RequestType { get; init; }

    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    [IsoId("_jATLfZIhEeect698_YsnIA")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; }
}
