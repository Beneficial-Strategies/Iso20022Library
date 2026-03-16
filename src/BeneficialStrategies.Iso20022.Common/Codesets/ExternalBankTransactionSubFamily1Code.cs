// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code sub-family, as published in an external bank transaction code sub-family code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionSubFamily1Code")]
[Description(
    @"Specifies the bank transaction code sub-family, as published in an external bank transaction code sub-family code list."
)]
[DerivedFrom(typeof(ExternalBankTransactionSubFamilyCode))]
public enum ExternalBankTransactionSubFamily1Code { }
