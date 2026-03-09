// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity involved in a card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GBytIdwBEeeOusYHZbyj7w")]
[Description(@"Type of entity involved in a card payment transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType28Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_GNPvMdwBEeeOusYHZbyj7w")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_GNPvM9wBEeeOusYHZbyj7w")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_GNPvO9wBEeeOusYHZbyj7w")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent = PartyTypeCode.Agent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_GNPvPdwBEeeOusYHZbyj7w")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_GNPvP9wBEeeOusYHZbyj7w")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provider of an electronic wallet
    /// Encoded/decoded by serializers as &quot;WLPR&quot;.
    /// </summary>
    [EnumMember(Value = "WLPR")]
    [IsoId("_KYSzUdwBEeeOusYHZbyj7w")]
    [Description(@"Provider of an electronic wallet")]
    WalletProvider = PartyTypeCode.WalletProvider, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer is the entitled party.
    /// Encoded/decoded by serializers as &quot;ISUR&quot;.
    /// </summary>
    [EnumMember(Value = "ISUR")]
    [IsoId("_0Hsb0UNKEeiut6dbx3wnBg")]
    [Description(@"Issuer is the entitled party.")]
    Issuer = PartyTypeCode.Issuer, // same ordinal as derivation source for type conversions
    
}
