// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the middle level of the three-level Bank Transaction Code (BTC) hierarchy:
/// Domain → <b>Family</b> → Sub-Family.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority (not in the eRepository),
/// so this enum has no members. At runtime, values arrive as raw 4-character strings via
/// <c>ExternalBankTransactionFamily1Code</c> (the string-typed wrapper used in message types).
/// </para>
/// <para>
/// <b>Validation:</b> Family codes are Domain-dependent — a code valid in one Domain may not exist in
/// another. You cannot validate a Family code in isolation; you must know the accompanying
/// <see cref="ExternalBankTransactionDomainCode"/>. Use the MCP tool
/// <c>get_reference_data("Bank Transaction Codes", "&lt;DomainCode&gt;")</c> to retrieve valid
/// Family codes for a specific Domain. The accompanying
/// <see cref="ExternalBankTransactionSubFamilyCode"/> must then be valid within that Domain/Family pair.
/// </para>
/// <para>
/// <b>Reference:</b> https://www.iso20022.org/catalogue/additional-content-messages/external-code-sets
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionFamilyCode")]
[Description(
    @"Specifies the external family code of the bank transaction code in the format of character string with a maximum length of 4 characters."
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalBankTransactionFamilyCode>))]
public enum ExternalBankTransactionFamilyCode { }
