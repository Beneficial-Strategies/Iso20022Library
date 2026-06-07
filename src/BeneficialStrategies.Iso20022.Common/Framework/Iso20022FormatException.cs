// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Thrown when a value does not satisfy the ISO 20022 format constraints of the target type
/// (e.g. pattern, maximum length, or character casing requirements).
/// </summary>
public sealed class Iso20022FormatException : FormatException
{
    /// <summary>The ISO 20022 type that rejected the value.</summary>
    public Type TargetType { get; }

    /// <summary>The value that failed validation.</summary>
    public string InvalidValue { get; }

    /// <summary>The ISO-specified constraint (regex pattern, length rule, etc.).</summary>
    public string Constraint { get; }

    /// <param name="targetType">The ISO 20022 type that rejected the value.</param>
    /// <param name="invalidValue">The value that failed validation.</param>
    /// <param name="constraint">The ISO-specified constraint description (e.g. the regex pattern).</param>
    public Iso20022FormatException(Type targetType, string invalidValue, string constraint)
        : base(
            $"'{invalidValue}' is not a valid {targetType.Name}. " +
            $"ISO 20022 constraint: {constraint}")
    {
        TargetType = targetType;
        InvalidValue = invalidValue;
        Constraint = constraint;
    }

    /// <param name="targetType">The ISO 20022 type that rejected the value.</param>
    /// <param name="invalidValue">The value that failed validation.</param>
    /// <param name="constraint">The ISO-specified constraint description.</param>
    /// <param name="inner">The exception that caused this one.</param>
    public Iso20022FormatException(Type targetType, string invalidValue, string constraint, Exception inner)
        : base(
            $"'{invalidValue}' is not a valid {targetType.Name}. " +
            $"ISO 20022 constraint: {constraint}",
            inner)
    {
        TargetType = targetType;
        InvalidValue = invalidValue;
        Constraint = constraint;
    }
}
