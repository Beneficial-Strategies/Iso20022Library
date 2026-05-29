// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code domain, as published in an external bank transaction code domain code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionDomain1Code")]
[Description(
    @"Specifies the bank transaction code domain, as published in an external bank transaction code domain code list."
)]
[DerivedFrom(typeof(ExternalBankTransactionDomainCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalBankTransactionDomain1Code>))]
public enum ExternalBankTransactionDomain1Code { }
