// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the communication format for statements in the format of a character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalCommunicationFormatCode")]
[Description(
    @"Specifies the communication format for statements in the format of a character string with a maximum length of 4 characters."
)]
public enum ExternalCommunicationFormatCode { }
