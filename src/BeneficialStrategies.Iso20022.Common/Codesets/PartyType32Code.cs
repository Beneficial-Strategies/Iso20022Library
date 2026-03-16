// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jjdWAENhEeiut6dbx3wnBg")]
[Description(@"Type of party.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType32Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_6Pgn8X0lEemfrNOe0zHQyg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_6Pgn830lEemfrNOe0zHQyg")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer."
    )]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is the entitled party.
    /// Encoded/decoded by serializers as &quot;ISUR&quot;.
    /// </summary>
    [EnumMember(Value = "ISUR")]
    [IsoId("_6Pgn9X0lEemfrNOe0zHQyg")]
    [Description(@"Issuer is the entitled party.")]
    Issuer = PartyTypeCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6Pgn930lEemfrNOe0zHQyg")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6Pgn-X0lEemfrNOe0zHQyg")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
