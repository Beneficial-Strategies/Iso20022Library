// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of verification entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b-gbQSbTEeyhZIgCcGlTyA")]
[Description(@"Type of verification entity.")]
[DerivedFrom(typeof(VerificationEntityCode))]
public enum VerificationEntity2Code
{
    /// <summary>
    /// Acceptor (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_cFaUgSbTEeyhZIgCcGlTyA")]
    [Description(@"Acceptor (for example signature verification by the attendant).")]
    Acceptor = VerificationEntityCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_cFaUgybTEeyhZIgCcGlTyA")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer = VerificationEntityCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_cFaUhSbTEeyhZIgCcGlTyA")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer."
    )]
    Agent = VerificationEntityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_cFaUhybTEeyhZIgCcGlTyA")]
    [Description(@"Card issuer.")]
    Issuer = VerificationEntityCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of authentication entity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_cFaUiSbTEeyhZIgCcGlTyA")]
    [Description(@"Other type of authentication entity defined at national level.")]
    OtherNational = VerificationEntityCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of authentication entity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cFaUiybTEeyhZIgCcGlTyA")]
    [Description(@"Other type of authentication entity defined at private level.")]
    OtherPrivate = VerificationEntityCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of Device to accept payment
    /// Encoded/decoded by serializers as &quot;CDAD&quot;.
    /// </summary>
    [EnumMember(Value = "CDAD")]
    [IsoId("_ebmv0SbTEeyhZIgCcGlTyA")]
    [Description(@"Type of Device to accept payment")]
    AcceptanceDevice = VerificationEntityCode.AcceptanceDevice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_emCeMSbTEeyhZIgCcGlTyA")]
    [Description(@"Application in the smart card.")]
    CardApplication = VerificationEntityCode.CardApplication, // same ordinal as derivation source for type conversions
}
