// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external domain code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the top level of the three-level Bank Transaction Code (BTC) hierarchy:
/// <b>Domain → Family → Sub-Family</b>.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority (not in the eRepository),
/// so this enum has no members. At runtime, values arrive as raw 4-character strings via
/// <c>ExternalBankTransactionDomain1Code</c> (the string-typed wrapper used in message types).
/// </para>
/// <para>
/// <b>Validation:</b> Use the MCP tool <c>get_reference_data("Bank Transaction Codes")</c> to retrieve
/// all current Domain codes. A Domain code on a message is only valid if it appears in that list.
/// Furthermore, the accompanying <see cref="ExternalBankTransactionFamilyCode"/> must be a valid
/// Family within that Domain — cross-level consistency is required.
/// </para>
/// <para>
/// <b>Known domains (v2025-11-30):</b>
/// ACMT (Account Management), CAMT (Cash Management), CMDT (Commodities),
/// DERV (Derivatives), FORX (Foreign Exchange), LDAS (Loans, Deposits &amp; Syndications),
/// PMNT (Payments), PMET (Precious Metal), SECU (Securities), TRAD (Trade Services),
/// XTND (Extended Domain).
/// </para>
/// <para>
/// <b>Reference:</b> https://www.iso20022.org/catalogue/additional-content-messages/external-code-sets
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_ExternalBankTransactionDomainCode")]
[Description(
    @"Specifies the external domain code of the bank transaction code in the format of character string with a maximum length of 4 characters."
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalBankTransactionDomainCode>))]
public enum ExternalBankTransactionDomainCode { }
