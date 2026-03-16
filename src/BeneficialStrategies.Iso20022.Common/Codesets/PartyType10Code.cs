// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of identified entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be1R0HrgEeSlsoBd7x4P6A")]
[Description(@"Type of identified entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType10Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_dnNTkXrgEeSlsoBd7x4P6A")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_dtndkXrgEeSlsoBd7x4P6A")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity managing the ATM.
    /// Encoded/decoded by serializers as &quot;ATMG&quot;.
    /// </summary>
    [EnumMember(Value = "ATMG")]
    [IsoId("_e5urYXrgEeSlsoBd7x4P6A")]
    [Description(@"Entity managing the ATM.")]
    ATMManager = PartyTypeCode.ATMManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_ftit8XrgEeSlsoBd7x4P6A")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_f-YmUXrgEeSlsoBd7x4P6A")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity hosting the ATM.
    /// Encoded/decoded by serializers as &quot;HSTG&quot;.
    /// </summary>
    [EnumMember(Value = "HSTG")]
    [IsoId("_hm2Y8XrgEeSlsoBd7x4P6A")]
    [Description(@"Entity hosting the ATM.")]
    HostingEntity = PartyTypeCode.HostingEntity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_h05cAXrgEeSlsoBd7x4P6A")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_i5CZkXrgEeSlsoBd7x4P6A")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM initiating the transaction.
    /// Encoded/decoded by serializers as &quot;OATM&quot;.
    /// </summary>
    [EnumMember(Value = "OATM")]
    [IsoId("_jRkOUXrgEeSlsoBd7x4P6A")]
    [Description(@"ATM initiating the transaction.")]
    OriginatingATM = PartyTypeCode.OriginatingATM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_jYxCgXrgEeSlsoBd7x4P6A")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions
}
