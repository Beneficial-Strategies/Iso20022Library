// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies undertaking issuance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vRbJQH4MEeG05p8M2uqofg")]
[Description(@"Specifies undertaking issuance type.")]
[DerivedFrom(typeof(IssuanceTypeCode))]
public enum IssuanceType1Code
{
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue a local undertaking.
    /// Encoded/decoded by serializers as &quot;CRQL&quot;.
    /// </summary>
    [EnumMember(Value = "CRQL")]
    [IsoId("_6Joo9n4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue a local undertaking.")]
    CounterUndertakingRequestForLocalUndertaking = IssuanceTypeCode.CounterUndertakingRequestForLocalUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CRQC&quot;.
    /// </summary>
    [EnumMember(Value = "CRQC")]
    [IsoId("_6S3ddn4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.")]
    CounterUndertakingRequestForCounterUndertaking = IssuanceTypeCode.CounterUndertakingRequestForCounterUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking issued direct to the beneficiary.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_6ZlJdn4MEeG05p8M2uqofg")]
    [Description(@"Undertaking issued direct to the beneficiary.")]
    UndertakingIssuedDirect = IssuanceTypeCode.UndertakingIssuedDirect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking issued to the beneficiary via a confirming party.
    /// Encoded/decoded by serializers as &quot;ISCO&quot;.
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_6ihDBn4MEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via a confirming party.")]
    UndertakingIssuedViaConfirmingParty = IssuanceTypeCode.UndertakingIssuedViaConfirmingParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking issued to the beneficiary via an advising party.
    /// Encoded/decoded by serializers as &quot;ISAD&quot;.
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_6qt8xn4MEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via an advising party.")]
    UndertakingViaAdvisingParty = IssuanceTypeCode.UndertakingViaAdvisingParty, // same ordinal as derivation source for type conversions
    
}
