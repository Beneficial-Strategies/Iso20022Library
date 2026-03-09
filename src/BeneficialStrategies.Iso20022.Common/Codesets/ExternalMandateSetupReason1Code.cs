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
[IsoId("_hsQScD2MEeS6DKIV6SF6gw")]
[Description(@"Specifies the mandate setup reason, as published in an external mandate setup reason code set.")]
[DerivedFrom(typeof(ExternalMandateSetupReasonCode))]
public enum ExternalMandateSetupReason1Code
{
}
