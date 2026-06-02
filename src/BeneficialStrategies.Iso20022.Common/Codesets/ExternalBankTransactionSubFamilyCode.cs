// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the deepest level of the three-level Bank Transaction Code (BTC) hierarchy:
/// Domain → Family → <b>Sub-Family</b>.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority (not in the eRepository),
/// so this enum has no members. At runtime, values arrive as raw 4-character strings via
/// <c>ExternalBankTransactionSubFamily1Code</c> (the string-typed wrapper used in message types).
/// </para>
/// <para>
/// <b>Validation:</b> Sub-Family codes are Domain+Family-dependent — the same code (e.g. OTHR, NTAV)
/// appears under many Domain/Family pairs, and a code valid for one pair may not be valid for another.
/// You cannot validate a Sub-Family code without knowing both the
/// <see cref="ExternalBankTransactionDomainCode"/> and <see cref="ExternalBankTransactionFamilyCode"/>.
/// Use the MCP tool <c>get_reference_data("Bank Transaction Codes", "&lt;DomainCode&gt;/&lt;FamilyCode&gt;")</c>
/// to retrieve the complete list of valid Sub-Family codes for a specific Domain/Family pair.
/// </para>
/// <para>
/// <b>Reference:</b> https://www.iso20022.org/catalogue/additional-content-messages/external-code-sets
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionSubFamilyCode")]
[Description(
    @"Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters."
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalBankTransactionSubFamilyCode>))]
public enum ExternalBankTransactionSubFamilyCode { }
