// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the mandate setup reason, as published in an external mandate setup reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q77v4T2MEeS6DKIV6SF6gw")]
[Description(@"Specifies the mandate setup reason, as published in an external mandate setup reason code set.")]
[Derivations(typeof(ExternalMandateSetupReason1Code))]
public enum ExternalMandateSetupReasonCode
{
}
