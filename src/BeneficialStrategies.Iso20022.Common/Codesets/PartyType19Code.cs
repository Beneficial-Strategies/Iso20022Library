// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity involved in a card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_osi70ErAEeenp6hmNprBHg")]
[Description(@"Type of entity involved in a card payment transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType19Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_vd3eoUrAEeenp6hmNprBHg")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_v2D8MkrAEeenp6hmNprBHg")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity providing acquiring card payment processing services on behalf on an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_wX-9gkrAEeenp6hmNprBHg")]
    [Description(@"Entity providing acquiring card payment processing services on behalf on an acquirer.")]
    AcquirerProcessor = PartyTypeCode.AcquirerProcessor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_xTlqIkrAEeenp6hmNprBHg")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as &quot;CISP&quot;.
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_xfzhMkrAEeenp6hmNprBHg")]
    [Description(@"Entity providing issuing card payment processing services on behalf on an issuer.")]
    CardIssuerProcessor = PartyTypeCode.CardIssuerProcessor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_0MDsEkrAEeenp6hmNprBHg")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_35GUIdwAEeeOusYHZbyj7w")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_4CxNgdwAEeeOusYHZbyj7w")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
}
