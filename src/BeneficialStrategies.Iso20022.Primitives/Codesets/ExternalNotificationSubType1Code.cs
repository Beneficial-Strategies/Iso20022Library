// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the notification sub type, as published in an external notification sub type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Per MCP, a versioned restriction of ExternalNotificationSubTypeCode.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("__e8BMLktEe68nbz8Nl_hLQ")]
[Description(@"Specifies the notification sub type, as published in an external notification sub type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalNotificationSubType1Code>))]
public readonly struct ExternalNotificationSubType1Code : IIsoExternalCode, IEquatable<ExternalNotificationSubType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalNotificationSubType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalNotificationSubType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalNotificationSubType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalNotificationSubType1Code"/>.</summary>
    public static implicit operator ExternalNotificationSubType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalNotificationSubType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalNotificationSubType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalNotificationSubType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalNotificationSubType1Code a, ExternalNotificationSubType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalNotificationSubType1Code a, ExternalNotificationSubType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalNotificationSubType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalNotificationSubType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalNotificationSubType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalNotificationSubType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Notification is for the credit department.</summary>
    [IsoId("_VNzMgmXkEe-25NN5iis_kQ")]
    [Description(@"Notification is for the credit department.")]
    public static readonly ExternalNotificationSubType1Code Credit = new("CRED");

    /// <summary>Notification is for the liquidity department.</summary>
    [IsoId("_IVlj8WXkEe-25NN5iis_kQ")]
    [Description(@"Notification is for the liquidity department.")]
    public static readonly ExternalNotificationSubType1Code Liquidity = new("LIQI");

    /// <summary>Notification is for the loans department.</summary>
    [IsoId("_abRW8mXkEe-25NN5iis_kQ")]
    [Description(@"Notification is for the loans department.")]
    public static readonly ExternalNotificationSubType1Code Loans = new("LOAN");

    /// <summary>Notification is for the payment operations department.</summary>
    [IsoId("_PyVpYWXkEe-25NN5iis_kQ")]
    [Description(@"Notification is for the payment operations department.")]
    public static readonly ExternalNotificationSubType1Code PaymentOperations = new("PAOP");

    /// <summary>Notification is for the sales department.</summary>
    [IsoId("_6JdccmXjEe-25NN5iis_kQ")]
    [Description(@"Notification is for the sales department.")]
    public static readonly ExternalNotificationSubType1Code Sales = new("SALE");

    /// <summary>Notification is for the servicing department.</summary>
    [IsoId("_Bk1B0mXkEe-25NN5iis_kQ")]
    [Description(@"Notification is for the servicing department.")]
    public static readonly ExternalNotificationSubType1Code Servicing = new("SERV");
}
