// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// W3C XML Schema xs:boolean — a true/false value.
/// </summary>
/// <remarks>
/// W3C XML Schema built-in type <c>xs:boolean</c>.
/// Wire format: lowercase <c>"true"</c> or <c>"false"</c> (the lexical space also accepts the
/// numeric forms <c>"1"</c> and <c>"0"</c> on input, but <see cref="ToString"/> always emits the
/// canonical <c>"true"</c>/<c>"false"</c> form — NOT the .NET <see cref="bool.ToString()"/>
/// output of <c>"True"</c>/<c>"False"</c>).
/// Programmatic access via <see cref="Value"/> returns the native <see cref="bool"/>.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("boolean_ID")]
[Description(@"W3C XML Schema xs:boolean — a true/false value.")]
[JsonConverter(typeof(Iso20022NumericValueJsonConverter<XsdBoolean, bool>))]
public readonly struct XsdBoolean : IIsoSimpleValue<bool>, IEquatable<XsdBoolean>
{
    /// <inheritdoc/>
    public bool Value { get; }

    /// <summary>Initializes from the native <see cref="bool"/> value.</summary>
    public XsdBoolean(bool value)
    {
        Value = value;
    }

    /// <summary>
    /// Initializes by parsing the W3C XSD boolean lexical space: <c>"true"</c>, <c>"false"</c>,
    /// <c>"1"</c>, or <c>"0"</c>.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">Thrown when the string is not a valid xs:boolean.</exception>
    public XsdBoolean(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        Value = value switch
        {
            "true" or "1" => true,
            "false" or "0" => false,
            _ => throw new Iso20022FormatException(typeof(XsdBoolean), value, "xs:boolean — \"true\", \"false\", \"1\", or \"0\""),
        };
    }

    /// <summary>Always succeeds — every <see cref="bool"/> is a valid xs:boolean value.</summary>
    public static bool TryCreate(bool value, out XsdBoolean result)
    {
        result = new(value);
        return true;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> is a valid xs:boolean lexical form.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out XsdBoolean result)
    {
        switch (value)
        {
            case "true" or "1":
                result = new(true);
                return true;
            case "false" or "0":
                result = new(false);
                return true;
            default:
                result = default;
                return false;
        }
    }

    /// <summary>Implicitly wraps a <see cref="bool"/> as a <see cref="XsdBoolean"/>.</summary>
    public static implicit operator XsdBoolean(bool value) => new(value);
    /// <summary>Implicitly unwraps to the native <see cref="bool"/> value.</summary>
    public static implicit operator bool(XsdBoolean v) => v.Value;
    /// <summary>Implicitly wraps a wire string as a <see cref="XsdBoolean"/>.</summary>
    public static implicit operator XsdBoolean(string value) => new(value);
    /// <summary>Implicitly unwraps to the wire string representation.</summary>
    public static implicit operator string(XsdBoolean v) => v.ToString();

    /// <inheritdoc/>
    public override string ToString() => Value ? "true" : "false";
    /// <inheritdoc/>
    public bool Equals(XsdBoolean other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is XsdBoolean other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    public static bool operator ==(XsdBoolean a, XsdBoolean b) => a.Value == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(XsdBoolean a, XsdBoolean b) => a.Value != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdBoolean a, bool b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdBoolean a, bool b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(bool a, XsdBoolean b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(bool a, XsdBoolean b) => a != b.Value;
    /// <inheritdoc/>
    public static bool operator ==(XsdBoolean a, string? b) => a.ToString() == b;
    /// <inheritdoc/>
    public static bool operator !=(XsdBoolean a, string? b) => a.ToString() != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, XsdBoolean b) => a == b.ToString();
    /// <inheritdoc/>
    public static bool operator !=(string? a, XsdBoolean b) => a != b.ToString();
}
