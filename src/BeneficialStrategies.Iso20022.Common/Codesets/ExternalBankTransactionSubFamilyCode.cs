// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionSubFamilyCode")]
[Description(@"Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.")]
public enum ExternalBankTransactionSubFamilyCode
{
}
