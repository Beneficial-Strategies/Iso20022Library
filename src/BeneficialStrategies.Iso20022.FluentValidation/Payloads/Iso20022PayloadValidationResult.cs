// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// The result of dispatching a raw XML/JSON payload through
/// <see cref="IIso20022PayloadValidationDispatcher"/>: the validation outcome, which ISO 20022
/// message type was resolved (if any), and the successfully deserialized message instance (if
/// parsing got that far) — so a caller that anticipates more than one possible message type can
/// act differently depending on which one the payload turned out to be, typically by switching on
/// <see cref="MessageType"/> and pattern-matching <see cref="Message"/> to each candidate type.
/// </summary>
/// <param name="ValidationResult">
/// The full FluentValidation result — <see cref="FluentValidation.Results.ValidationResult.Errors"/>
/// contains parse failures (<c>"XmlParseError"</c>/<c>"PayloadParseError"</c>/etc. — see
/// <see cref="IIso20022PayloadValidationDispatcher"/>'s remarks) exactly like it contains ordinary
/// business-rule failures; nothing distinguishes the two in shape.
/// </param>
/// <param name="MessageType">
/// The resolved ISO 20022 message CLR type, or <see langword="null"/> if the payload's type
/// couldn't be determined at all (malformed XML with no root, an unrecognized document namespace,
/// or an unrecognized JSON message identifier).
/// </param>
/// <param name="Message">
/// The deserialized message instance, or <see langword="null"/> if <see cref="MessageType"/> was
/// resolved but deserialization itself then failed, or if <see cref="MessageType"/> is
/// <see langword="null"/>. Declared as <see cref="object"/> because the concrete type isn't known
/// at compile time — cast or pattern-match against each type your caller anticipates.
/// </param>
public sealed record Iso20022PayloadValidationResult(ValidationResult ValidationResult, Type? MessageType, object? Message)
{
    /// <summary>Shorthand for <c>ValidationResult.IsValid</c>.</summary>
    public bool IsValid => ValidationResult.IsValid;
}
