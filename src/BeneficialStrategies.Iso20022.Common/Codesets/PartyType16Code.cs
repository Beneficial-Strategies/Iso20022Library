// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the entity which initially sets the authorisation response value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Fi62Aa1_EeWMg5rOByfExw")]
[Description(@"Identifies the entity which initially sets the authorisation response value.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType16Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_FuP8Qa1_EeWMg5rOByfExw")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_FuP8Q61_EeWMg5rOByfExw")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_FuP8Ra1_EeWMg5rOByfExw")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_FuP8R61_EeWMg5rOByfExw")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application on the terminal which has initiated the transaction.
    /// Encoded/decoded by serializers as &quot;OTRM&quot;.
    /// </summary>
    [EnumMember(Value = "OTRM")]
    [IsoId("_FuP8Sa1_EeWMg5rOByfExw")]
    [Description(@"Application on the terminal which has initiated the transaction.")]
    OriginatingTerminal = PartyTypeCode.OriginatingTerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The bank of the source account.
    /// Encoded/decoded by serializers as &quot;BKAF&quot;.
    /// </summary>
    [EnumMember(Value = "BKAF")]
    [IsoId("_KDSC0a1_EeWMg5rOByfExw")]
    [Description(@"The bank of the source account.")]
    AccountFromBank = PartyTypeCode.AccountFromBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The bank of the destination account.
    /// Encoded/decoded by serializers as &quot;BKAT&quot;.
    /// </summary>
    [EnumMember(Value = "BKAT")]
    [IsoId("_KK4foa1_EeWMg5rOByfExw")]
    [Description(@"The bank of the destination account.")]
    AccountToBank = PartyTypeCode.AccountToBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity managing the ATM.
    /// Encoded/decoded by serializers as &quot;ATMG&quot;.
    /// </summary>
    [EnumMember(Value = "ATMG")]
    [IsoId("_KcUN4a1_EeWMg5rOByfExw")]
    [Description(@"Entity managing the ATM.")]
    ATMManager = PartyTypeCode.ATMManager, // same ordinal as derivation source for type conversions
}
