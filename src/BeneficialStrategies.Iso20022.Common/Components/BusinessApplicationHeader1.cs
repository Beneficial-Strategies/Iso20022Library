// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the Business Application Header of the Business Message.
/// Can be used when replying to a query; can also be used when canceling or amending.
/// </summary>
[IsoId("_QnrCBdp-Ed-ak6NoX_4Aeg_2082653882")]
[DisplayName("Business Application Header")]
public record BusinessApplicationHeader1
{
    /// <summary>
    /// Contains the character set of the text-based elements used in the Business Message.
    /// </summary>
    [IsoId("_QnrCBtp-Ed-ak6NoX_4Aeg_1732906457")]
    [DisplayName("Character Set")]
    [IsoXmlTag("CharSet")]
    public UnicodeChartsCode? CharacterSet { get; init; }

    /// <summary>
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_QnrCB9p-Ed-ak6NoX_4Aeg_-73112806")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party9Choice_ From { get; init; }

    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_QnrCCNp-Ed-ak6NoX_4Aeg_-169722537")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party9Choice_ To { get; init; }

    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_QnrCCdp-Ed-ak6NoX_4Aeg_325023192")]
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; }

    /// <summary>
    /// Contains the MessageIdentifier that defines the BusinessMessage.
    /// It must contain a MessageIdentifier published on the ISO 20022 website.
    /// example	camt.001.001.03.
    /// </summary>
    [IsoId("_QnrCCtp-Ed-ak6NoX_4Aeg_-2098267532")]
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; }

    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    ///  To be used when there is a choice of processing services or processing service levels.
    /// Example: E&amp;I.
    /// </summary>
    [IsoId("_QnrCC9p-Ed-ak6NoX_4Aeg_-1512320506")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; }

    /// <summary>
    /// Date and time when this Business Message (header) was created.
    /// Note Times must be normalized, using the &quot;Z&quot; annotation.
    /// </summary>
    [IsoId("_Qn0zANp-Ed-ak6NoX_4Aeg_1403963847")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISONormalisedDateTime)]
    public required IsoISONormalisedDateTime CreationDate { get; init; }

    /// <summary>
    /// Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.
    /// </summary>
    [IsoId("_Qn0zAdp-Ed-ak6NoX_4Aeg_293052428")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }

    /// <summary>
    /// Flag indicating if the Business Message exchanged between the MessagingEndpoints is possibly a duplicate.
    /// If the receiving MessagingEndpoint did not receive the original, then this Business Message should be processed as if it were the original.
    /// If the receiving MessagingEndpoint did receive the original, then it should perform necessary actions to avoid processing this Business Message again.
    /// This will guarantee business idempotent behaviour.
    /// NOTE: this is named &quot;PossResend&quot; in FIX - this is an application level resend not a network level retransmission.
    /// </summary>
    [IsoId("_Qn0zAtp-Ed-ak6NoX_4Aeg_1615242288")]
    [DisplayName("Possible Duplicate")]
    [IsoXmlTag("PssblDplct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PossibleDuplicate { get; init; }

    /// <summary>
    /// Relative indication of the processing precedence of the message over a (set of) Business Messages with assigned priorities.
    /// </summary>
    [IsoId("_Qn0zA9p-Ed-ak6NoX_4Aeg_1846952339")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public BusinessMessagePriorityCode? Priority { get; init; }

    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business Message.
    /// </summary>
    [IsoId("_Qn0zBNp-Ed-ak6NoX_4Aeg_-572833242")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SignatureEnvelope? Signature { get; init; }
}
