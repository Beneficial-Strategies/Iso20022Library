// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment scenario, as published in an external payment scenario code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12sPUGw8Ee-t2JGPeXy0Sw")]
[Description(@"Specifies the payment scenario, as published in an external payment scenario code set.")]
[Derivations(typeof(ExternalPaymentScenario1Code))]
public enum ExternalPaymentScenarioCode
{
}
