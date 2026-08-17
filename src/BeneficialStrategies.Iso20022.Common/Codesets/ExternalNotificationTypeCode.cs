// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the notification type, as published in an external notification type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Per MCP, derived by ExternalNotificationType1Code.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_ayMzgLktEe68nbz8Nl_hLQ")]
[Description(@"Specifies the notification type, as published in an external notification type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalNotificationTypeCode>))]
public readonly struct ExternalNotificationTypeCode : IIsoExternalCode, IEquatable<ExternalNotificationTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalNotificationTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalNotificationTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalNotificationTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalNotificationTypeCode"/>.</summary>
    public static implicit operator ExternalNotificationTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalNotificationTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalNotificationTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalNotificationTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalNotificationTypeCode a, ExternalNotificationTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalNotificationTypeCode a, ExternalNotificationTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalNotificationTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalNotificationTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalNotificationTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalNotificationTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Notification of a change of address.</summary>
    [IsoId("_Q0oHQLFbEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of a change of address.")]
    public static readonly ExternalNotificationTypeCode ChangeOfAddress = new("ADDR");

    /// <summary>Notification of new or amended terms and conditions for an account.</summary>
    [IsoId("_SVk3oGXjEe-25NN5iis_kQ")]
    [Description(@"Notification of new or amended terms and conditions for an account.")]
    public static readonly ExternalNotificationTypeCode AccountTermsAndConditions = new("ATAC");

    /// <summary>Notification of new or amended contact details.</summary>
    [IsoId("_dWBGQGXjEe-25NN5iis_kQ")]
    [Description(@"Notification of new or amended contact details.")]
    public static readonly ExternalNotificationTypeCode ContactDetailsUpdate = new("COUP");

    /// <summary>Notification of a currency holiday.</summary>
    [IsoId("_GC3v4GXjEe-25NN5iis_kQ")]
    [Description(@"Notification of a currency holiday.")]
    public static readonly ExternalNotificationTypeCode CurrencyHoliday = new("CUHO");

    /// <summary>Notification of any pertinent industry or market changes.</summary>
    [IsoId("_10i6MLFcEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of any pertinent industry or market changes.")]
    public static readonly ExternalNotificationTypeCode IndustryChanges = new("INCH");

    /// <summary>Sharing of information.</summary>
    [IsoId("_AnLoQLFbEe-6m-PwtIJ7WQ")]
    [Description(@"Sharing of information.")]
    public static readonly ExternalNotificationTypeCode InformationSharing = new("INFO");

    /// <summary>Notification of a merger and any associated changes.</summary>
    [IsoId("_GCPGQLFcEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of a merger and any associated changes.")]
    public static readonly ExternalNotificationTypeCode AdviceOfAMerger = new("MERG");

    /// <summary>Notification of a change to opening hours.</summary>
    [IsoId("_lSJe4LFcEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of a change to opening hours.")]
    public static readonly ExternalNotificationTypeCode ChangeOfBankBranchOpeningHours = new("OPEN");

    /// <summary>Other notification type.</summary>
    [IsoId("_nKAv4GXjEe-25NN5iis_kQ")]
    [Description(@"Other notification type.")]
    public static readonly ExternalNotificationTypeCode Other = new("OTHR");

    /// <summary>Notification of a change to Standing Settlement Instructions (SSIs).</summary>
    [IsoId("_oXvzULFbEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of a change to Standing Settlement Instructions (SSIs).")]
    public static readonly ExternalNotificationTypeCode StandingSettlementInstructionsUpdate = new("SSIS");

    /// <summary>Notification of a process suspension due to an incident.</summary>
    [IsoId("_YHM4AGXjEe-25NN5iis_kQ")]
    [Description(@"Notification of a process suspension due to an incident.")]
    public static readonly ExternalNotificationTypeCode Suspension = new("SUSP");

    /// <summary>Request for access to a system.</summary>
    [IsoId("_YkuxELFcEe-6m-PwtIJ7WQ")]
    [Description(@"Request for access to a system.")]
    public static readonly ExternalNotificationTypeCode SystemAccessRequest = new("SYST");

    /// <summary>Notification of termination of a service, such as an account closure.</summary>
    [IsoId("_b6av8LFbEe-6m-PwtIJ7WQ")]
    [Description(@"Notification of termination of a service, such as an account closure.")]
    public static readonly ExternalNotificationTypeCode ServiceTermination = new("TERM");
}
