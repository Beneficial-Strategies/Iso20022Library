// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3WUpkHtCEeSTS7uHCe8FPQ")]
[Description(@"Type of entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType11Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_-QbU8XtCEeSTS7uHCe8FPQ")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_-ZApM3tCEeSTS7uHCe8FPQ")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("__OPoE3tCEeSTS7uHCe8FPQ")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("__deW43tCEeSTS7uHCe8FPQ")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_AgFDY3tDEeSTS7uHCe8FPQ")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application on the terminal which has initiated the transaction.
    /// Encoded/decoded by serializers as &quot;OTRM&quot;.
    /// </summary>
    [EnumMember(Value = "OTRM")]
    [IsoId("_BBjYw3tDEeSTS7uHCe8FPQ")]
    [Description(@"Application on the terminal which has initiated the transaction.")]
    OriginatingTerminal = PartyTypeCode.OriginatingTerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_X79fgS6vEeWc7f-D6ByqMg")]
    [Description(@"Application in the smart card.")]
    CardApplication = PartyTypeCode.CardApplication, // same ordinal as derivation source for type conversions
}
