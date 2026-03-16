// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code family, as published in an external bank transaction code family code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionFamily1Code")]
[Description(@"Specifies the bank transaction code family, as published in an external bank transaction code family code list.")]
[DerivedFrom(typeof(ExternalBankTransactionFamilyCode))]
public enum ExternalBankTransactionFamily1Code
{
}
