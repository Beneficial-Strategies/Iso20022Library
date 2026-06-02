// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of verification entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1e6zIT1vEfCQAqQ9lolFUg")]
[Description(@"Type of verification entity.")]
[DerivedFrom(typeof(VerificationEntityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<VerificationEntity3Code>))]
public enum VerificationEntity3Code
{
    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_1hN5Mz1vEfCQAqQ9lolFUg")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer = VerificationEntityCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_1hN5NT1vEfCQAqQ9lolFUg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.")]
    Agent = VerificationEntityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of Device to accept payment
    /// Encoded/decoded by serializers as &quot;CDAD&quot;.
    /// </summary>
    [EnumMember(Value = "CDAD")]
    [IsoId("_1hN5PT1vEfCQAqQ9lolFUg")]
    [Description(@"Type of Device to accept payment")]
    AcceptanceDevice = VerificationEntityCode.AcceptanceDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_1hN5Pz1vEfCQAqQ9lolFUg")]
    [Description(@"Application in the smart card.")]
    CardApplication = VerificationEntityCode.CardApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_1hN5Nz1vEfCQAqQ9lolFUg")]
    [Description(@"Card issuer.")]
    Issuer = VerificationEntityCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acceptor (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_1hN5MT1vEfCQAqQ9lolFUg")]
    [Description(@"Acceptor (for example signature verification by the attendant).")]
    Acceptor = VerificationEntityCode.Acceptor, // same ordinal as derivation source for type conversions
}
