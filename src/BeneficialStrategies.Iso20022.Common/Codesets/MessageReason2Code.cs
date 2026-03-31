// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to send the message.
/// ISO 8583:93/2003 bit 25.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sVbosE0eEeea0Mdu1TOzDQ")]
[Description(@"Reason to send the message.|ISO 8583:93/2003 bit 25.")]
[DerivedFrom(typeof(MessageReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageReason2Code>))]
#endif
public enum MessageReason2Code
{
    /// <summary>
    /// Stand-in processing at the acquirer&apos;s option.
    /// Encoded/decoded by serializers as &quot;ASTD&quot;.
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_oH-a0X0lEemfrNOe0zHQyg")]
    [Description(@"Stand-in processing at the acquirer's option.")]
    AcquirerStandin = MessageReasonCode.AcquirerStandin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction above or under the floor limit.
    /// Encoded/decoded by serializers as &quot;FLRL&quot;.
    /// </summary>
    [EnumMember(Value = "FLRL")]
    [IsoId("_oH-a030lEemfrNOe0zHQyg")]
    [Description(@"Transaction above or under the floor limit.")]
    FloorLimit = MessageReasonCode.FloorLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction performed offline by the card.
    /// Encoded/decoded by serializers as &quot;COFF&quot;.
    /// </summary>
    [EnumMember(Value = "COFF")]
    [IsoId("_oH-a1X0lEemfrNOe0zHQyg")]
    [Description(@"Transaction performed offline by the card.")]
    CardProcessed = MessageReasonCode.CardProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor forced to be online.
    /// Encoded/decoded by serializers as &quot;ASPC&quot;.
    /// </summary>
    [EnumMember(Value = "ASPC")]
    [IsoId("_oH-a130lEemfrNOe0zHQyg")]
    [Description(@"Card acceptor forced to be online.")]
    CardAcceptorSuspicious = MessageReasonCode.CardAcceptorSuspicious, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;CUNB&quot;.
    /// </summary>
    [EnumMember(Value = "CUNB")]
    [IsoId("_oH-a2X0lEemfrNOe0zHQyg")]
    [Description(@"Card cannot process offline the transaction.")]
    CardUnableToProcess = MessageReasonCode.CardUnableToProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Random online decided by the card.
    /// Encoded/decoded by serializers as &quot;CRND&quot;.
    /// </summary>
    [EnumMember(Value = "CRND")]
    [IsoId("_oH-a230lEemfrNOe0zHQyg")]
    [Description(@"Random online decided by the card.")]
    CardRandomSelection = MessageReasonCode.CardRandomSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forced online by card acceptor, terminal, card, or the issuer.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_oH-a3X0lEemfrNOe0zHQyg")]
    [Description(@"Forced online by card acceptor, terminal, card, or the issuer.")]
    OnlineForced = MessageReasonCode.OnlineForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer signed off.
    /// Encoded/decoded by serializers as &quot;ISGN&quot;.
    /// </summary>
    [EnumMember(Value = "ISGN")]
    [IsoId("_oH-a330lEemfrNOe0zHQyg")]
    [Description(@"Issuer signed off.")]
    IssuerSignedOff = MessageReasonCode.IssuerSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer timed out on request.
    /// Encoded/decoded by serializers as &quot;ITIM&quot;.
    /// </summary>
    [EnumMember(Value = "ITIM")]
    [IsoId("_oH-a4X0lEemfrNOe0zHQyg")]
    [Description(@"Issuer timed out on request.")]
    IssuerTimeout = MessageReasonCode.IssuerTimeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer unavailable.
    /// Encoded/decoded by serializers as &quot;IUNV&quot;.
    /// </summary>
    [EnumMember(Value = "IUNV")]
    [IsoId("_oH-a430lEemfrNOe0zHQyg")]
    [Description(@"Issuer unavailable.")]
    IssuerUnavailable = MessageReasonCode.IssuerUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other national type of reason.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_oH-a5X0lEemfrNOe0zHQyg")]
    [Description(@"Other national type of reason.")]
    OtherNational = MessageReasonCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other private type of reason.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_oH-a530lEemfrNOe0zHQyg")]
    [Description(@"Other private type of reason.")]
    OtherPrivate = MessageReasonCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Random online decided by the terminal.
    /// Encoded/decoded by serializers as &quot;TRND&quot;.
    /// </summary>
    [EnumMember(Value = "TRND")]
    [IsoId("_oH-a6X0lEemfrNOe0zHQyg")]
    [Description(@"Random online decided by the terminal.")]
    TerminalRandomSelection = MessageReasonCode.TerminalRandomSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;TUNB&quot;.
    /// </summary>
    [EnumMember(Value = "TUNB")]
    [IsoId("_oH-a630lEemfrNOe0zHQyg")]
    [Description(@"Terminal cannot process offline the transaction.")]
    TerminalUnableToProcess = MessageReasonCode.TerminalUnableToProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stand-in processing at the receiver&apos;s option.
    /// Encoded/decoded by serializers as &quot;RSTD&quot;.
    /// </summary>
    [EnumMember(Value = "RSTD")]
    [IsoId("_oH-a7X0lEemfrNOe0zHQyg")]
    [Description(@"Stand-in processing at the receiver's option.")]
    ReceiverStandin = MessageReasonCode.ReceiverStandin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver timed out on request.
    /// Encoded/decoded by serializers as &quot;RTIM&quot;.
    /// </summary>
    [EnumMember(Value = "RTIM")]
    [IsoId("_oH-a730lEemfrNOe0zHQyg")]
    [Description(@"Receiver timed out on request.")]
    ReceiverTimeout = MessageReasonCode.ReceiverTimeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver signed off.
    /// Encoded/decoded by serializers as &quot;RSGN&quot;.
    /// </summary>
    [EnumMember(Value = "RSGN")]
    [IsoId("_oH-a8X0lEemfrNOe0zHQyg")]
    [Description(@"Receiver signed off.")]
    ReceiverSignedOff = MessageReasonCode.ReceiverSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver unavailable.
    /// Encoded/decoded by serializers as &quot;RUNV&quot;.
    /// </summary>
    [EnumMember(Value = "RUNV")]
    [IsoId("_oH-a830lEemfrNOe0zHQyg")]
    [Description(@"Receiver unavailable.")]
    ReceiverUnavailable = MessageReasonCode.ReceiverUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction performed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_oH-a9X0lEemfrNOe0zHQyg")]
    [Description(@"Transaction performed offline by the terminal.")]
    TerminalProcessed = MessageReasonCode.TerminalProcessed, // same ordinal as derivation source for type conversions
}
