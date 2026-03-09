// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KoEfcGJuEeiVRNxFJ2pSfQ")]
[Description(@"Common report status for all individual reports sent / received.")]
[DerivedFrom(typeof(PairedReconciledCode))]
public enum PairedReconciled1Code
{
    /// <summary>
    /// Paired.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_NFpVIGJuEeiVRNxFJ2pSfQ")]
    [Description(@"Paired.")]
    Paired = PairedReconciledCode.Paired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciled.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_NWlUIWJuEeiVRNxFJ2pSfQ")]
    [Description(@"Reconciled.")]
    Reconciled = PairedReconciledCode.Reconciled, // same ordinal as derivation source for type conversions
    
}
