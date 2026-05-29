// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the industry sector according to a regulatory framework.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YX_LwMA8Ee6Po8t8GRsqAQ")]
[Description(@"Specifies the industry sector according to a regulatory framework.")]
[DerivedFrom(typeof(ExternalIndustrySectorClassificationCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalIndustrySectorClassification1Code>))]
public enum ExternalIndustrySectorClassification1Code { }
