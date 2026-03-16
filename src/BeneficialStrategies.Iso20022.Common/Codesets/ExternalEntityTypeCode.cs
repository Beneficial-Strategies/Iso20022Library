// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zu_aYOIZEe-eFYnrXcX-mQ")]
[Description(@"Specifies the type of entity.")]
[Derivations(typeof(ExternalEntityType1Code))]
public enum ExternalEntityTypeCode { }
