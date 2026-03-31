// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external credit line type code in the format of character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCreditLineType1Code")]
[Description(
    @"Specifies the external credit line type code in the format of character string with a maximum length of 4 characters."
)]
[DerivedFrom(typeof(ExternalCreditLineTypeCode))]
public enum ExternalCreditLineType1Code { }
