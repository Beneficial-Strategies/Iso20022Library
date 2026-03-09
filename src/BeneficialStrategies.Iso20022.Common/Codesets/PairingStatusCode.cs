// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Pairing status for an individual transaction or report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sPf1A154Ee2a_-MvhEjKmA")]
[Description(@"Pairing status for an individual transaction or report.")]
[Derivations(typeof(PairingStatus1Code))]
public enum PairingStatusCode
{
    /// <summary>
    /// Transaction has been paired.
    /// Encoded/decoded by serializers as &quot;PARD&quot;.
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_sPf1Bl54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has been paired.")]
    Paired,
    
    /// <summary>
    /// Transaction has not been paired.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_sPf1BV54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has not been paired.")]
    Unpaired,
    
}
