// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the entity which initially sets the authorisation response value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_otjDEIp8EeS3NqNpgnMh2w")]
[Description(@"Identifies the entity which initially sets the authorisation response value.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType13Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_rR52MYp8EeS3NqNpgnMh2w")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_rlIUM4p8EeS3NqNpgnMh2w")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_sTWsI4p8EeS3NqNpgnMh2w")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_stIeE4p8EeS3NqNpgnMh2w")]
    [Description(@"Party acting on behalf of other parties to process or forward data to other parties.")]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Application on the terminal which has initiated the transaction.
    /// Encoded/decoded by serializers as &quot;OTRM&quot;.
    /// </summary>
    [EnumMember(Value = "OTRM")]
    [IsoId("_tFbCQ4p8EeS3NqNpgnMh2w")]
    [Description(@"Application on the terminal which has initiated the transaction.")]
    OriginatingTerminal = PartyTypeCode.OriginatingTerminal, // same ordinal as derivation source for type conversions
    
}
