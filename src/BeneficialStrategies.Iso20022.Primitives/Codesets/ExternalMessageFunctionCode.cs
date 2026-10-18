// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify the type of process related to the message, as published separately in a message function external code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_o6qLAJgHEe6OBt2eQPMPsQ")]
[Description(@"Code to identify the type of process related to the message, as published separately in a message function external code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalMessageFunctionCode>))]
public readonly struct ExternalMessageFunctionCode : IIsoExternalCode, IEquatable<ExternalMessageFunctionCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given message function code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalMessageFunctionCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalMessageFunctionCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalMessageFunctionCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalMessageFunctionCode"/>.</summary>
    public static implicit operator ExternalMessageFunctionCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalMessageFunctionCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalMessageFunctionCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalMessageFunctionCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalMessageFunctionCode a, ExternalMessageFunctionCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalMessageFunctionCode a, ExternalMessageFunctionCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalMessageFunctionCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalMessageFunctionCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalMessageFunctionCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalMessageFunctionCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.</summary>
    [IsoId("_LtvcgL8lEe6tVqdcbD5-mg")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.")]
    public static readonly ExternalMessageFunctionCode Advice = new("ADVC");

    /// <summary>Notification to initiate the transfer of a batch (no response expected).</summary>
    [IsoId("__P-YsAyeEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a batch (no response expected).")]
    public static readonly ExternalMessageFunctionCode BatchNotification = new("BNTF");

    /// <summary>Request to initiate the transfer of a batch (response expected).</summary>
    [IsoId("_DPKLEAyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a batch (response expected).")]
    public static readonly ExternalMessageFunctionCode BatchRequest = new("BTRQ");

    /// <summary>Advice about the capture of an activity already performed (response expected).</summary>
    [IsoId("_wy0yoAyeEe-uhfEdsrOCZg")]
    [Description(@"Advice about the capture of an activity already performed (response expected).")]
    public static readonly ExternalMessageFunctionCode CaptureAdvice = new("CAAD");

    /// <summary>Notification about the capture of an activity already performed (no response expected).</summary>
    [IsoId("_45O5EAyeEe-uhfEdsrOCZg")]
    [Description(@"Notification about the capture of an activity already performed (no response expected).")]
    public static readonly ExternalMessageFunctionCode CaptureNotification = new("CANO");

    /// <summary>Notification to initiate the transfer of a collection (no response expected).</summary>
    [IsoId("_IJSiwAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a collection (no response expected).")]
    public static readonly ExternalMessageFunctionCode CollectionNotification = new("CLNF");

    /// <summary>Request to initiate the transfer of a collection (response expected).</summary>
    [IsoId("_QlkLgAyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a collection (response expected).")]
    public static readonly ExternalMessageFunctionCode CollectionRequest = new("CLRQ");

    /// <summary>Notification of a message containing errors.</summary>
    [IsoId("_gS8DUAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a message containing errors.")]
    public static readonly ExternalMessageFunctionCode ErrorNotification = new("ERNO");

    /// <summary>Informs of an action to be taken.</summary>
    [IsoId("_qMHH4AyfEe-uhfEdsrOCZg")]
    [Description(@"Informs of an action to be taken.")]
    public static readonly ExternalMessageFunctionCode Instruction = new("INSN");

    /// <summary>Message function is notification.</summary>
    [IsoId("_M_GWsL8lEe6tVqdcbD5-mg")]
    [Description(@"Message function is notification.")]
    public static readonly ExternalMessageFunctionCode Notification = new("NOTI");

    /// <summary>Notification of a rejected message.</summary>
    [IsoId("_l0PvwAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a rejected message.")]
    public static readonly ExternalMessageFunctionCode RejectNotification = new("RENO");

    /// <summary>Message function is request.</summary>
    [IsoId("_IAyCkL8lEe6tVqdcbD5-mg")]
    [Description(@"Message function is request.")]
    public static readonly ExternalMessageFunctionCode Request = new("REQU");

    /// <summary>Advice about the status of a transaction.</summary>
    [IsoId("_VUh1AAyfEe-uhfEdsrOCZg")]
    [Description(@"Advice about the status of a transaction.")]
    public static readonly ExternalMessageFunctionCode StatusAdvice = new("STAD");

    /// <summary>Notification about the status of a transaction.</summary>
    [IsoId("_b5bscAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification about the status of a transaction.")]
    public static readonly ExternalMessageFunctionCode StatusNotification = new("STNO");
}
