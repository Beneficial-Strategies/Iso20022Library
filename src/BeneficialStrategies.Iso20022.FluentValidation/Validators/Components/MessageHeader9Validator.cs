// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MessageHeader9"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _jAUZkZIhEeect698_YsnIA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of characteristics, such as the identification or the creation date and time, specific to
/// the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>RequestType</term><description>RequestType4Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>RequestType</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MessageHeader9Validator : AbstractValidator<MessageHeader9>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>RequestType</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="requestTypeValidator">
    /// Validator for the optional <c>RequestType</c> building block (RequestType4Choice_, 0..1)
    /// — only invoked when present.
    /// </param>
    public MessageHeader9Validator(IValidator<RequestType4Choice_> requestTypeValidator)
    {
        When(
            x => x.RequestType is not null,
            () => RuleFor(x => x.RequestType).SetValidator(requestTypeValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>RequestType</c> is validated by
    /// its own default validator (<see cref="RequestType4Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public MessageHeader9Validator()
        : this(new RequestType4Choice_Validator()) { }
}
