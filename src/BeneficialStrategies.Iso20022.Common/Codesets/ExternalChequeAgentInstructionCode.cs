// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external instruction code, as provided to a cheque agent for processing, in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ak80ertoEeq_cfXrH83Rcw")]
[Description(
    @"Specifies the external instruction code, as provided to a cheque agent for processing, in the format of character string with a maximum length of 4 characters."
)]
[Derivations(typeof(ExternalChequeAgentInstruction1Code))]
public enum ExternalChequeAgentInstructionCode { }
