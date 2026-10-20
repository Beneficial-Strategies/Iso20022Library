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
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_3BansPXqEfCQzYdew2M4XQ")]
[Description(@"Specifies the update reason for the decision, as defined in an external Decision Status Update Reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalDecisionStatusUpdateReasonCode>))]
public readonly struct ExternalDecisionStatusUpdateReasonCode : IIsoExternalCode, IEquatable<ExternalDecisionStatusUpdateReasonCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalDecisionStatusUpdateReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalDecisionStatusUpdateReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalDecisionStatusUpdateReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalDecisionStatusUpdateReasonCode"/>.</summary>
    public static implicit operator ExternalDecisionStatusUpdateReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalDecisionStatusUpdateReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalDecisionStatusUpdateReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalDecisionStatusUpdateReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalDecisionStatusUpdateReasonCode a, ExternalDecisionStatusUpdateReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalDecisionStatusUpdateReasonCode a, ExternalDecisionStatusUpdateReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalDecisionStatusUpdateReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalDecisionStatusUpdateReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalDecisionStatusUpdateReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalDecisionStatusUpdateReasonCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Authorisation under Art. 34.</summary>
    [IsoId("_raa58PXrEfCQzYdew2M4XQ")]
    [Description(@"Authorisation under Art. 34.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode AuthorisationUnderArt34 = new("AAUT");

    /// <summary>Endorsement under Art. 33.</summary>
    [IsoId("_mD2d4PXrEfCQzYdew2M4XQ")]
    [Description(@"Endorsement under Art. 33.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode EndorsementUnderArt33 = new("ADRS");

    /// <summary>Equivalence under Art. 30.</summary>
    [IsoId("_AkPo0PXrEfCQzYdew2M4XQ")]
    [Description(@"Equivalence under Art. 30.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode EquivalenceUnderArt30 = new("AEQA");

    /// <summary>Recognition under Art. 32.</summary>
    [IsoId("_XoJpUPXrEfCQzYdew2M4XQ")]
    [Description(@"Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode RecognitionUnderArt32 = new("ARCG");

    /// <summary>Registration under Art. 34.</summary>
    [IsoId("_tTD2kPXrEfCQzYdew2M4XQ")]
    [Description(@"Registration under Art. 34.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode RegistrationUnderrt34 = new("AREG");

    /// <summary>Cessation of endorsement under Art. 33.</summary>
    [IsoId("_oBAHEPXrEfCQzYdew2M4XQ")]
    [Description(@"Cessation of endorsement under Art. 33.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode CessationOfEndorsementUnderArt33 = new("CDRS");

    /// <summary>Non-Compliant under Art. 24.</summary>
    [IsoId("_2zMJAPXrEfCQzYdew2M4XQ")]
    [Description(@"Non-Compliant under Art. 24.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode NonCompliantUnderArt24 = new("NCOM");

    /// <summary>Not Yet Licensed under Art 24.</summary>
    [IsoId("_5KuoIPXrEfCQzYdew2M4XQ")]
    [Description(@"Not Yet Licensed under Art 24.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode NotYetLicensedUnderArt24 = new("NLIC");

    /// <summary>Suspension of Authorisation under Art. 35.</summary>
    [IsoId("_xK0LQPXrEfCQzYdew2M4XQ")]
    [Description(@"Suspension of Authorisation under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode SuspensionOfAuthorisationUnderArt35 = new("SAUT");

    /// <summary>Suspension of Recognition under Art. 32.</summary>
    [IsoId("_gmgEYPXrEfCQzYdew2M4XQ")]
    [Description(@"Suspension of Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode SuspensionOfRecognitionUnderArt32 = new("SRCG");

    /// <summary>Suspension of Registration under Art. 35.</summary>
    [IsoId("_1FIEsPXrEfCQzYdew2M4XQ")]
    [Description(@"Suspension of Registration under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode SuspensionOfRegistrationUnderArt35 = new("SREG");

    /// <summary>Withdrawal of Authorisation under Art. 35.</summary>
    [IsoId("_vLWN4PXrEfCQzYdew2M4XQ")]
    [Description(@"Withdrawal of Authorisation under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode WithdrawalOfAuthorisationUnderArt35 = new("WAUT");

    /// <summary>Withdrawal by third country competent authority of Registration of the third country administrator under Art. 30.</summary>
    [IsoId("_GQA40PXrEfCQzYdew2M4XQ")]
    [Description(@"Withdrawal by third country competent authority of Registration of the third country administrator under Art. 30.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode WithdrawalByThirdCountryCompetentAuthorityUnderArt30 = new("WEQA");

    /// <summary>Withdrawal by ESMA of Registration of the third country administrator under Art. 31.</summary>
    [IsoId("_Rz2IYPXrEfCQzYdew2M4XQ")]
    [Description(@"Withdrawal by ESMA of Registration of the third country administrator under Art. 31.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode WithdrawalOfTheThirdCountryAdministratorUnderArt31 = new("WEQE");

    /// <summary>Withdrawal of Recognition under Art. 32.</summary>
    [IsoId("_eo_O0PXrEfCQzYdew2M4XQ")]
    [Description(@"Withdrawal of Recognition under Art. 32.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode WithdrawalOfRecognitionUnderArt32 = new("WRCG");

    /// <summary>Withdrawal of Registration under Art. 35.</summary>
    [IsoId("_zTzRAPXrEfCQzYdew2M4XQ")]
    [Description(@"Withdrawal of Registration under Art. 35.")]
    public static readonly ExternalDecisionStatusUpdateReasonCode WithdrawalOfRegistrationUnderArt35 = new("WREG");
}
