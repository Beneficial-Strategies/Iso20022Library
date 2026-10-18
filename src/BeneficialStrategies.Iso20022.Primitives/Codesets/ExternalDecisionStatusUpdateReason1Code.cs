// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the update reason for the decision, as defined in an external Decision Status Update Reason code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org. Versioned restriction of <see cref="ExternalDecisionStatusUpdateReasonCode"/> — each member below carries its own IsoId distinct from the base codeset's IsoId for the same wire code, per CLAUDE.md's hybrid-pattern guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_g87ncPeYEfC4KMmFuc_hXw")]
[Description(@"Specifies the update reason for the decision, as defined in an external Decision Status Update Reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalDecisionStatusUpdateReason1Code>))]
public readonly struct ExternalDecisionStatusUpdateReason1Code : IIsoExternalCode, IEquatable<ExternalDecisionStatusUpdateReason1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalDecisionStatusUpdateReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalDecisionStatusUpdateReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalDecisionStatusUpdateReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalDecisionStatusUpdateReason1Code"/>.</summary>
    public static implicit operator ExternalDecisionStatusUpdateReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalDecisionStatusUpdateReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalDecisionStatusUpdateReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalDecisionStatusUpdateReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalDecisionStatusUpdateReason1Code a, ExternalDecisionStatusUpdateReason1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalDecisionStatusUpdateReason1Code a, ExternalDecisionStatusUpdateReason1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalDecisionStatusUpdateReason1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalDecisionStatusUpdateReason1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalDecisionStatusUpdateReason1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalDecisionStatusUpdateReason1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Authorisation under Art. 34.</summary>
    [IsoId("_ldUpcfeYEfC4KMmFuc_hXw")]
    [Description(@"Authorisation under Art. 34.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code AuthorisationUnderArt34 = new("AAUT");

    /// <summary>Endorsement under Art. 33.</summary>
    [IsoId("_lkiEsfeYEfC4KMmFuc_hXw")]
    [Description(@"Endorsement under Art. 33.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code EndorsementUnderArt33 = new("ADRS");

    /// <summary>Equivalence under Art. 30.</summary>
    [IsoId("_lo5AQfeYEfC4KMmFuc_hXw")]
    [Description(@"Equivalence under Art. 30.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code EquivalenceUnderArt30 = new("AEQA");

    /// <summary>Recognition under Art. 32.</summary>
    [IsoId("_l4WYkfeYEfC4KMmFuc_hXw")]
    [Description(@"Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code RecognitionUnderArt32 = new("ARCG");

    /// <summary>Registration under Art. 34.</summary>
    [IsoId("_l-WS4feYEfC4KMmFuc_hXw")]
    [Description(@"Registration under Art. 34.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code RegistrationUnderrt34 = new("AREG");

    /// <summary>Cessation of endorsement under Art. 33.</summary>
    [IsoId("_ks4D8feYEfC4KMmFuc_hXw")]
    [Description(@"Cessation of endorsement under Art. 33.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code CessationOfEndorsementUnderArt33 = new("CDRS");

    /// <summary>Non-Compliant under Art. 24.</summary>
    [IsoId("_luUS0feYEfC4KMmFuc_hXw")]
    [Description(@"Non-Compliant under Art. 24.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code NonCompliantUnderArt24 = new("NCOM");

    /// <summary>Not Yet Licensed under Art 24.</summary>
    [IsoId("_lyfoMfeYEfC4KMmFuc_hXw")]
    [Description(@"Not Yet Licensed under Art 24.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code NotYetLicensedUnderArt24 = new("NLIC");

    /// <summary>Suspension of Authorisation under Art. 35.</summary>
    [IsoId("_mCkEgfeYEfC4KMmFuc_hXw")]
    [Description(@"Suspension of Authorisation under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code SuspensionOfAuthorisationUnderArt35 = new("SAUT");

    /// <summary>Suspension of Recognition under Art. 32.</summary>
    [IsoId("_mKhGofeYEfC4KMmFuc_hXw")]
    [Description(@"Suspension of Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code SuspensionOfRecognitionUnderArt32 = new("SRCG");

    /// <summary>Suspension of Registration under Art. 35.</summary>
    [IsoId("_mUapgfeYEfC4KMmFuc_hXw")]
    [Description(@"Suspension of Registration under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code SuspensionOfRegistrationUnderArt35 = new("SREG");

    /// <summary>Withdrawal of Authorisation under Art. 35.</summary>
    [IsoId("_mchcofeYEfC4KMmFuc_hXw")]
    [Description(@"Withdrawal of Authorisation under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code WithdrawalOfAuthorisationUnderArt35 = new("WAUT");

    /// <summary>Withdrawal by third country competent authority of Registration of the third country administrator under Art. 30.</summary>
    [IsoId("_mYeDEfeYEfC4KMmFuc_hXw")]
    [Description(@"Withdrawal by third country competent authority of Registration of the third country administrator under Art. 30.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code WithdrawalByThirdCountryCompetentAuthorityUnderArt30 = new("WEQA");

    /// <summary>Withdrawal by ESMA of Registration of the third country administrator under Art. 31.</summary>
    [IsoId("_mq9hQfeYEfC4KMmFuc_hXw")]
    [Description(@"Withdrawal by ESMA of Registration of the third country administrator under Art. 31.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code WithdrawalOfTheThirdCountryAdministratorUnderArt31 = new("WEQE");

    /// <summary>Withdrawal of Recognition under Art. 32.</summary>
    [IsoId("_mhn_EfeYEfC4KMmFuc_hXw")]
    [Description(@"Withdrawal of Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code WithdrawalOfRecognitionUnderArt32 = new("WRCG");

    /// <summary>Withdrawal of Registration under Art. 35.</summary>
    [IsoId("_mlYdsfeYEfC4KMmFuc_hXw")]
    [Description(@"Withdrawal of Registration under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReason1Code WithdrawalOfRegistrationUnderArt35 = new("WREG");
}
