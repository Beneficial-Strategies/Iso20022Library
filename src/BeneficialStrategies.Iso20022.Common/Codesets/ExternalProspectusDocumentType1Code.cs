// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of data exchanged using a code used for the current regulation in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. Length facet from MCP: minLength=1, maxLength=4. Versioned restriction of <see cref="ExternalProspectusDocumentTypeCode"/> — each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_lQho4J3BEe-5R_OgGkLFHw")]
[Description(@"Specifies the type of data exchanged using a code used for the current regulation in the format of character string with a maximum length of 4 characters.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProspectusDocumentType1Code>))]
public readonly struct ExternalProspectusDocumentType1Code : IIsoExternalCode, IEquatable<ExternalProspectusDocumentType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProspectusDocumentType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProspectusDocumentType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProspectusDocumentType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProspectusDocumentType1Code"/>.</summary>
    public static implicit operator ExternalProspectusDocumentType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProspectusDocumentType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProspectusDocumentType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProspectusDocumentType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusDocumentType1Code a, ExternalProspectusDocumentType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusDocumentType1Code a, ExternalProspectusDocumentType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusDocumentType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusDocumentType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProspectusDocumentType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProspectusDocumentType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Document type  is amendment of a registration document or an universal registration document.</summary>
    [IsoId("_SnwhgZ3CEe-5R_OgGkLFHw")]
    [Description(@"Document type  is amendment of a registration document or an universal registration document.")]
    public static readonly ExternalProspectusDocumentType1Code Amendment = new("AMND");

    /// <summary>Document type is a translation of appendix.</summary>
    [IsoId("_mYk2EZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a translation of appendix.")]
    public static readonly ExternalProspectusDocumentType1Code TranslationOfAppendix = new("APPT");

    /// <summary>Document type is a base prospectus with final terms.</summary>
    [IsoId("_nD4c4Z3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a base prospectus with final terms.")]
    public static readonly ExternalProspectusDocumentType1Code BaseProspectusWithFinalTerm = new("BPFT");

    /// <summary>Document type is a base prospectus without final terms.</summary>
    [IsoId("_m_P0gZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a base prospectus without final terms.")]
    public static readonly ExternalProspectusDocumentType1Code BaseProspectusWithoutFinalTerm = new("BPWO");

    /// <summary>Document type is a certificate of approval record.</summary>
    [IsoId("_m6c0EZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a certificate of approval record.")]
    public static readonly ExternalProspectusDocumentType1Code CertificateOfApproval = new("COAP");

    /// <summary>Document type  is exemption document.</summary>
    [IsoId("_RzBR4Z3CEe-5R_OgGkLFHw")]
    [Description(@"Document type  is exemption document.")]
    public static readonly ExternalProspectusDocumentType1Code ExemptionDocument = new("EXMP");

    /// <summary>Document type is a final offer price and amount of securities.</summary>
    [IsoId("_Cb0B4Z3DEe-5R_OgGkLFHw")]
    [Description(@"Document type is a final offer price and amount of securities.")]
    public static readonly ExternalProspectusDocumentType1Code FinalOfferPrice = new("FOPA");

    /// <summary>Document type is a final terms with summary record.</summary>
    [IsoId("_m2C1MZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a final terms with summary record.")]
    public static readonly ExternalProspectusDocumentType1Code FinalTermsWithSummary = new("FTWS");

    /// <summary>Document type is a stand-alone registration document.</summary>
    [IsoId("_mqklAZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a stand-alone registration document.")]
    public static readonly ExternalProspectusDocumentType1Code RegistrationDocument = new("REGN");

    /// <summary>Document type is a securities note.</summary>
    [IsoId("_muusQZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a securities note.")]
    public static readonly ExternalProspectusDocumentType1Code SecuritiesNote = new("SECN");

    /// <summary>Document type is a summary.</summary>
    [IsoId("_mlyysZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a summary.")]
    public static readonly ExternalProspectusDocumentType1Code Summary = new("SMRY");

    /// <summary>Document type is stand-alone prospectus.</summary>
    [IsoId("_mhloIZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is stand-alone prospectus.")]
    public static readonly ExternalProspectusDocumentType1Code StandaloneProspectus = new("STDA");

    /// <summary>Document type is translation of summary.</summary>
    [IsoId("_mTycsZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is translation of summary.")]
    public static readonly ExternalProspectusDocumentType1Code TranslationOfSummary = new("SUMT");

    /// <summary>Document type is a supplement document.</summary>
    [IsoId("_mc25IZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a supplement document.")]
    public static readonly ExternalProspectusDocumentType1Code Supplement = new("SUPP");

    /// <summary>Document type is a universal registration document.</summary>
    [IsoId("_mOrTMZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a universal registration document.")]
    public static readonly ExternalProspectusDocumentType1Code UniversalRegistrationDocument = new("URGN");
}
