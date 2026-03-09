// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking issuance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kx1cMH4LEeG05p8M2uqofg")]
[Description(@"Specifies the undertaking issuance type.")]
[Derivations(typeof(IssuanceType1Code))]
public enum IssuanceTypeCode
{
    /// <summary>
    /// Undertaking issued direct to the beneficiary.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_okhB0H4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued direct to the beneficiary.")]
    UndertakingIssuedDirect,
    
    /// <summary>
    /// Undertaking issued to the beneficiary via an advising party.
    /// Encoded/decoded by serializers as &quot;ISAD&quot;.
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_2S0k4H4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via an advising party.")]
    UndertakingViaAdvisingParty,
    
    /// <summary>
    /// Undertaking issued to the beneficiary via a confirming party.
    /// Encoded/decoded by serializers as &quot;ISCO&quot;.
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_-OEkMH4LEeG05p8M2uqofg")]
    [Description(@"Undertaking issued to the beneficiary via a confirming party.")]
    UndertakingIssuedViaConfirmingParty,
    
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue a local undertaking.
    /// Encoded/decoded by serializers as &quot;CRQL&quot;.
    /// </summary>
    [EnumMember(Value = "CRQL")]
    [IsoId("_HetpIH4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue a local undertaking.")]
    CounterUndertakingRequestForLocalUndertaking,
    
    /// <summary>
    /// Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CRQC&quot;.
    /// </summary>
    [EnumMember(Value = "CRQC")]
    [IsoId("_cyhlAH4MEeG05p8M2uqofg")]
    [Description(@"Counter-undertaking issued to a correspondent with a request to issue another counter-undertaking.")]
    CounterUndertakingRequestForCounterUndertaking,
    
}
