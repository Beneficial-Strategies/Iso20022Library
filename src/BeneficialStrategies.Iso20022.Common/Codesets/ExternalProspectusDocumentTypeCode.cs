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
/// External code sets can be downloaded from www.iso20022.org. Length facet from MCP: minLength=1, maxLength=4.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_SFvPDp3BEe-5R_OgGkLFHw")]
[Description(@"Specifies the type of data exchanged using a code used for the current regulation in the format of character string with a maximum length of 4 characters.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProspectusDocumentTypeCode>))]
public readonly struct ExternalProspectusDocumentTypeCode : IIsoExternalCode, IEquatable<ExternalProspectusDocumentTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProspectusDocumentTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProspectusDocumentTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProspectusDocumentTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProspectusDocumentTypeCode"/>.</summary>
    public static implicit operator ExternalProspectusDocumentTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProspectusDocumentTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProspectusDocumentTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProspectusDocumentTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusDocumentTypeCode a, ExternalProspectusDocumentTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusDocumentTypeCode a, ExternalProspectusDocumentTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusDocumentTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusDocumentTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProspectusDocumentTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProspectusDocumentTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Document type  is amendment of a registration document or an universal registration document.</summary>
    [IsoId("_SFvPFJ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type  is amendment of a registration document or an universal registration document.")]
    public static readonly ExternalProspectusDocumentTypeCode Amendment = new("AMND");

    /// <summary>Document type is a translation of appendix.</summary>
    [IsoId("_SFvPEZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a translation of appendix.")]
    public static readonly ExternalProspectusDocumentTypeCode TranslationOfAppendix = new("APPT");

    /// <summary>Document type is a base prospectus with final terms.</summary>
    [IsoId("_SFvPD53BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a base prospectus with final terms.")]
    public static readonly ExternalProspectusDocumentTypeCode BaseProspectusWithFinalTerm = new("BPFT");

    /// <summary>Document type is a base prospectus without final terms.</summary>
    [IsoId("_SFvPGJ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a base prospectus without final terms.")]
    public static readonly ExternalProspectusDocumentTypeCode BaseProspectusWithoutFinalTerm = new("BPWO");

    /// <summary>Document type is a certificate of approval record.</summary>
    [IsoId("_SFvPGZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a certificate of approval record.")]
    public static readonly ExternalProspectusDocumentTypeCode CertificateOfApproval = new("COAP");

    /// <summary>Document type  is exemption document.</summary>
    [IsoId("_CuBBoZ3CEe-5R_OgGkLFHw")]
    [Description(@"Document type  is exemption document.")]
    public static readonly ExternalProspectusDocumentTypeCode ExemptionDocument = new("EXMP");

    /// <summary>Document type is a final offer price and amount of securities.</summary>
    [IsoId("_4WxrkJ3CEe-5R_OgGkLFHw")]
    [Description(@"Document type is a final offer price and amount of securities.")]
    public static readonly ExternalProspectusDocumentTypeCode FinalOfferPrice = new("FOPA");

    /// <summary>Document type is a final terms with summary record.</summary>
    [IsoId("_SFvPFp3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a final terms with summary record.")]
    public static readonly ExternalProspectusDocumentTypeCode FinalTermsWithSummary = new("FTWS");

    /// <summary>Document type is a stand-alone registration document.</summary>
    [IsoId("_SFvPEp3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a stand-alone registration document.")]
    public static readonly ExternalProspectusDocumentTypeCode RegistrationDocument = new("REGN");

    /// <summary>Document type is a securities note.</summary>
    [IsoId("_SFvPEJ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a securities note.")]
    public static readonly ExternalProspectusDocumentTypeCode SecuritiesNote = new("SECN");

    /// <summary>Document type is a summary.</summary>
    [IsoId("_SFvPGp3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a summary.")]
    public static readonly ExternalProspectusDocumentTypeCode Summary = new("SMRY");

    /// <summary>Document type is stand-alone prospectus.</summary>
    [IsoId("_SFvPFZ3BEe-5R_OgGkLFHw")]
    [Description(@"Document type is stand-alone prospectus.")]
    public static readonly ExternalProspectusDocumentTypeCode StandaloneProspectus = new("STDA");

    /// <summary>Document type is translation of summary.</summary>
    [IsoId("_SFvPG53BEe-5R_OgGkLFHw")]
    [Description(@"Document type is translation of summary.")]
    public static readonly ExternalProspectusDocumentTypeCode TranslationOfSummary = new("SUMT");

    /// <summary>Document type is a supplement document.</summary>
    [IsoId("_SFvPF53BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a supplement document.")]
    public static readonly ExternalProspectusDocumentTypeCode Supplement = new("SUPP");

    /// <summary>Document type is a universal registration document.</summary>
    [IsoId("_SFvPE53BEe-5R_OgGkLFHw")]
    [Description(@"Document type is a universal registration document.")]
    public static readonly ExternalProspectusDocumentTypeCode UniversalRegistrationDocument = new("URGN");
}
