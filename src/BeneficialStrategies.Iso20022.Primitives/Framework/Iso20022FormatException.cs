// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Categorises why an ISO 20022 value was rejected, allowing callers to catch
/// specific violations with a <see langword="when"/> filter.
/// </summary>
public enum Iso20022FormatViolation
{
    /// <summary>
    /// The value is shorter than the ISO-specified minimum length.
    /// Catch with: <c>catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.TooShort)</c>
    /// </summary>
    TooShort,

    /// <summary>
    /// The value is longer than the ISO-specified maximum length.
    /// Catch with: <c>catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.TooLong)</c>
    /// </summary>
    TooLong,

    /// <summary>
    /// The value contains one or more characters outside the ISO-specified character set.
    /// Catch with: <c>catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.InvalidCharacter)</c>
    /// </summary>
    InvalidCharacter,

    /// <summary>
    /// The value does not match the ISO-specified regex pattern (catch-all for pattern types).
    /// Catch with: <c>catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.PatternMismatch)</c>
    /// </summary>
    PatternMismatch,

    /// <summary>
    /// The value's trailing check digit does not match the value computed from the rest of the
    /// value using the external standard's check-digit algorithm (e.g. SEDOL, CUSIP).
    /// Catch with: <c>catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.CheckDigitMismatch)</c>
    /// </summary>
    CheckDigitMismatch,
}

/// <summary>
/// Thrown when a value does not satisfy the ISO 20022 format constraints of the target type.
/// </summary>
/// <remarks>
/// Callers that need to distinguish failure reasons should use <see langword="when"/> filters:
/// <code>
/// try { field = new Max35Text(input); }
/// catch (ArgumentNullException) { /* null input */ }
/// catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.TooLong)
///     { /* truncate input and retry */ }
/// catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.TooShort)
///     { /* reject empty input */ }
/// catch (Iso20022FormatException e) when (e.Violation == Iso20022FormatViolation.InvalidCharacter)
///     { /* sanitise character set */ }
/// </code>
/// </remarks>
public sealed class Iso20022FormatException : FormatException
{
    /// <summary>The ISO 20022 type that rejected the value.</summary>
    public Type TargetType { get; }

    /// <summary>The value that failed validation (may be truncated in the message for readability).</summary>
    public string InvalidValue { get; }

    /// <summary>The ISO-specified constraint that was violated.</summary>
    public string Constraint { get; }

    /// <summary>The specific kind of violation, for use with <see langword="catch"/> / <see langword="when"/>.</summary>
    public Iso20022FormatViolation Violation { get; }

    // ── Private constructor — all creation goes through public constructors or factory methods ──

    private Iso20022FormatException(
        Type targetType, string invalidValue, string constraint,
        Iso20022FormatViolation violation, string message)
        : base(message)
    {
        TargetType = targetType;
        InvalidValue = invalidValue;
        Constraint = constraint;
        Violation = violation;
    }

    private Iso20022FormatException(
        Type targetType, string invalidValue, string constraint,
        Iso20022FormatViolation violation, string message, Exception inner)
        : base(message, inner)
    {
        TargetType = targetType;
        InvalidValue = invalidValue;
        Constraint = constraint;
        Violation = violation;
    }

    // ── Public constructor for pattern-validated types (external codes, regex types) ──

    /// <summary>
    /// Creates an exception for a value that failed a regex pattern check.
    /// </summary>
    /// <param name="targetType">The ISO 20022 type that rejected the value.</param>
    /// <param name="invalidValue">The value that failed validation.</param>
    /// <param name="pattern">The ISO-specified regex pattern.</param>
    public Iso20022FormatException(Type targetType, string invalidValue, string pattern)
        : this(targetType, invalidValue, pattern, Iso20022FormatViolation.PatternMismatch,
            $"'{Preview(invalidValue)}' is not a valid {targetType.Name}. " +
            $"ISO 20022 pattern constraint: {pattern}")
    { }

    /// <inheritdoc cref="Iso20022FormatException(Type,string,string)"/>
    /// <param name="targetType"><inheritdoc cref="Iso20022FormatException(Type,string,string)" path="/param[@name='targetType']"/></param>
    /// <param name="invalidValue"><inheritdoc cref="Iso20022FormatException(Type,string,string)" path="/param[@name='invalidValue']"/></param>
    /// <param name="pattern"><inheritdoc cref="Iso20022FormatException(Type,string,string)" path="/param[@name='pattern']"/></param>
    /// <param name="inner">The exception that caused this one.</param>
    public Iso20022FormatException(Type targetType, string invalidValue, string pattern, Exception inner)
        : this(targetType, invalidValue, pattern, Iso20022FormatViolation.PatternMismatch,
            $"'{Preview(invalidValue)}' is not a valid {targetType.Name}. " +
            $"ISO 20022 pattern constraint: {pattern}", inner)
    { }

    // ── Factory methods for length violations ──

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.TooShort"/> exception.
    /// </summary>
    public static Iso20022FormatException ForTooShort(Type targetType, string value, int minLength) =>
        new(targetType, value, $"minLength {minLength}", Iso20022FormatViolation.TooShort,
            value.Length == 0
                ? $"'{targetType.Name}' requires at least {minLength} character(s) but received an empty string."
                : $"'{targetType.Name}' requires at least {minLength} character(s) but received {value.Length}: '{Preview(value)}'.");

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.TooLong"/> exception.
    /// </summary>
    public static Iso20022FormatException ForTooLong(Type targetType, string value, int maxLength) =>
        new(targetType, value, $"maxLength {maxLength}", Iso20022FormatViolation.TooLong,
            $"'{targetType.Name}' allows at most {maxLength} character(s) but received {value.Length}: '{Preview(value)}'.");

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.TooShort"/> exception for a byte[]-backed
    /// (binary) type. The message reports the byte count rather than a character count, and
    /// <see cref="InvalidValue"/> stores the base64 wire representation of <paramref name="value"/>
    /// rather than the raw bytes.
    /// </summary>
    public static Iso20022FormatException ForTooShort(Type targetType, byte[] value, int minLength) =>
        new(targetType, Convert.ToBase64String(value), $"minLength {minLength} byte(s)", Iso20022FormatViolation.TooShort,
            value.Length == 0
                ? $"'{targetType.Name}' requires at least {minLength} byte(s) but received an empty array."
                : $"'{targetType.Name}' requires at least {minLength} byte(s) but received {value.Length}.");

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.TooLong"/> exception for a byte[]-backed
    /// (binary) type. The message reports the byte count rather than a character count, and
    /// <see cref="InvalidValue"/> stores the base64 wire representation of <paramref name="value"/>
    /// rather than the raw bytes.
    /// </summary>
    public static Iso20022FormatException ForTooLong(Type targetType, byte[] value, int maxLength) =>
        new(targetType, Convert.ToBase64String(value), $"maxLength {maxLength} byte(s)", Iso20022FormatViolation.TooLong,
            $"'{targetType.Name}' allows at most {maxLength} byte(s) but received {value.Length}.");

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.InvalidCharacter"/> exception.
    /// </summary>
    public static Iso20022FormatException ForInvalidCharacter(Type targetType, string value, string allowedCharacters) =>
        new(targetType, value, $"character set: {allowedCharacters}", Iso20022FormatViolation.InvalidCharacter,
            $"'{targetType.Name}' contains characters outside the allowed set ({allowedCharacters}): '{Preview(value)}'.");

    /// <summary>
    /// Creates a <see cref="Iso20022FormatViolation.CheckDigitMismatch"/> exception.
    /// </summary>
    /// <param name="targetType">The ISO 20022 type that rejected the value.</param>
    /// <param name="value">The full value supplied, including its (incorrect) check digit.</param>
    /// <param name="expectedCheckDigit">The check digit computed from the value's core per the external standard's algorithm.</param>
    /// <param name="actualCheckDigit">The check digit actually present in <paramref name="value"/>.</param>
    public static Iso20022FormatException ForCheckDigitMismatch(
        Type targetType, string value, char expectedCheckDigit, char actualCheckDigit) =>
        new(targetType, value, "check digit", Iso20022FormatViolation.CheckDigitMismatch,
            $"'{Preview(value)}' has an invalid check digit for {targetType.Name}: " +
            $"expected '{expectedCheckDigit}' but the value supplied '{actualCheckDigit}'.");

    // ── Helpers ──

    private static string Preview(string value) =>
        value is null ? "(null)" :
        value.Length <= 50 ? value :
        value[..47] + "...";
}
