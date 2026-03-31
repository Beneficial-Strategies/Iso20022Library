// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the size of an entity according to a list of categories.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Hvx6EOIYEe-eFYnrXcX-mQ")]
[Description(@"Specifies the size of an entity according to a list of categories.")]
[Derivations(typeof(ExternalEntitySize1Code))]
public enum ExternalEntitySizeCode { }
