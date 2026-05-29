// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of card transaction in the format of character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCardTransactionCategory1Code")]
[Description(
    @"Specifies the category of card transaction in the format of character string with a maximum length of 4 characters."
)]
[DerivedFrom(typeof(ExternalCardTransactionCategoryCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalCardTransactionCategory1Code>))]
public enum ExternalCardTransactionCategory1Code { }
