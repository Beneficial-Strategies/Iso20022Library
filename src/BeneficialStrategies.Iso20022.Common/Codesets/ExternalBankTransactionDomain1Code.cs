// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code domain, as published in an external bank transaction code domain code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionDomain1Code")]
[Description(@"Specifies the bank transaction code domain, as published in an external bank transaction code domain code list.")]
[DerivedFrom(typeof(ExternalBankTransactionDomainCode))]
public enum ExternalBankTransactionDomain1Code
{
}
