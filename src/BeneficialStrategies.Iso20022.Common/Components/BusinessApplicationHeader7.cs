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
[IsoId("_VujxkfmsEeuM-bZFEQa_yw")]
[DisplayName("Business Application Header")]
public record BusinessApplicationHeader7
{
    /// <summary>
    /// Contains the character set of the text-based elements used in the Business Message.
    /// </summary>
    [IsoId("_V2dJUfmsEeuM-bZFEQa_yw")]
    [DisplayName("Character Set")]
    [IsoXmlTag("CharSet")]
    public UnicodeChartsCode? CharacterSet { get; init; }

    /// <summary>
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_V2dJU_msEeuM-bZFEQa_yw")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party44Choice_ From { get; init; }

    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_V2dJVfmsEeuM-bZFEQa_yw")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party44Choice_ To { get; init; }

    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_V2dJV_msEeuM-bZFEQa_yw")]
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; }

    /// <summary>
    /// The Message Definition Identifier of the Business Message instance with which this Business Application Header instance is associated.
    /// </summary>
    [IsoId("_V2dJWfmsEeuM-bZFEQa_yw")]
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; }

    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    /// To be used when there is a choice of processing services or processing service levels.
    /// Example:
    /// “marketx.hvps.01” and “marketx.xbdr.01” might be used to indicate that the associated messages are subject to different processing levels for domestic high value payments versus cross-border payments  within the same market practice.
    /// </summary>
    [IsoId("_V2dJW_msEeuM-bZFEQa_yw")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; }

    /// <summary>
    /// Specifies the market practice to which the message conforms. The market practices are a set of rules agreed between parties that restricts the usage of the messages in order to achieve better STP (Straight Through Processing) rates.
    /// A market practice specification may also extend the underlying message specification by using extensions or supplementary data of this underlying message.
    /// </summary>
    [IsoId("_fw9DkfmsEeuM-bZFEQa_yw")]
    [DisplayName("Market Practice")]
    [IsoXmlTag("MktPrctc")]
    public ImplementationSpecification1? MarketPractice { get; init; }

    /// <summary>
    /// Date and time when this Business Message (header) was created.
    /// Note Times must be normalized, using the &quot;Z&quot; annotation.
    /// </summary>
    [IsoId("_V2dJXfmsEeuM-bZFEQa_yw")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDate { get; init; }

    /// <summary>
    /// Processing date and time indicated by the sender for the receiver of the business message. This date may be different from the date and time provided in the CreationDate.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used.
    /// </summary>
    [IsoId("_oTE1ofmsEeuM-bZFEQa_yw")]
    [DisplayName("Business Processing Date")]
    [IsoXmlTag("BizPrcgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? BusinessProcessingDate { get; init; }

    /// <summary>
    /// Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.
    /// </summary>
    [IsoId("_V2dJX_msEeuM-bZFEQa_yw")]
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
    [IsoId("_V2dJYfmsEeuM-bZFEQa_yw")]
    [DisplayName("Possible Duplicate")]
    [IsoXmlTag("PssblDplct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PossibleDuplicate { get; init; }

    /// <summary>
    /// Relative indication of the processing precedence of the message over a (set of) Business Messages with assigned priorities.
    /// </summary>
    [IsoId("_V2dJY_msEeuM-bZFEQa_yw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public BusinessMessagePriorityCode? Priority { get; init; }

    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business Message.
    /// </summary>
    [IsoId("_V2dJZfmsEeuM-bZFEQa_yw")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SignatureEnvelope? Signature { get; init; }
}
