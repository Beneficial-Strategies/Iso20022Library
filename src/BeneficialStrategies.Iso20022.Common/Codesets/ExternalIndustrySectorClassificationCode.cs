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
[IsoId("_KejWwcA8Ee6Po8t8GRsqAQ")]
[Description(@"Specifies the industry sector according to a regulatory framework.")]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalIndustrySectorClassificationCode>))]
public enum ExternalIndustrySectorClassificationCode { }
