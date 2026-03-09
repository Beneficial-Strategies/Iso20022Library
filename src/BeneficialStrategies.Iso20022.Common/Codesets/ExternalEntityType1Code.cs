// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A5iwIOIaEe-eFYnrXcX-mQ")]
[Description(@"Specifies the type of entity.")]
[DerivedFrom(typeof(ExternalEntityTypeCode))]
public enum ExternalEntityType1Code
{
}
