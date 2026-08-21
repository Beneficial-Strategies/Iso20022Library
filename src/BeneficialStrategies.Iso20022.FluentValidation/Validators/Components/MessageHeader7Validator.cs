// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MessageHeader7"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _imfkUZIhEeect698_YsnIA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of characteristics, such as the identification or the creation date and time, specific to
/// the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>RequestType</term><description>RequestType4Choice_ — optional (0..1)</description></item>
///   <item><term>OriginalBusinessQuery</term><description>OriginalBusinessQuery1 — optional (0..1)</description></item>
///   <item><term>QueryName</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. This is the "response" sibling of
/// <see cref="MessageHeader9"/> (used on the request side) — same <c>RequestType</c> field, plus
/// <c>OriginalBusinessQuery</c> and <c>QueryName</c> to correlate the response back to the
/// original request.
///
/// Dependency injection: <c>RequestType</c> and <c>OriginalBusinessQuery</c> are each validated
/// by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class MessageHeader7Validator : AbstractValidator<MessageHeader7>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>RequestType</c> and <c>OriginalBusinessQuery</c> building blocks —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="requestTypeValidator">
    /// Validator for the optional <c>RequestType</c> building block (RequestType4Choice_, 0..1)
    /// — only invoked when present.
    /// </param>
    /// <param name="originalBusinessQueryValidator">
    /// Validator for the optional <c>OriginalBusinessQuery</c> building block
    /// (OriginalBusinessQuery1, 0..1) — only invoked when present.
    /// </param>
    public MessageHeader7Validator(
        IValidator<RequestType4Choice_> requestTypeValidator,
        IValidator<OriginalBusinessQuery1> originalBusinessQueryValidator
    )
    {
        // QueryName: optional scalar, length enforced by the struct constructor — no rule needed.

        When(
            x => x.RequestType is not null,
            () => RuleFor(x => x.RequestType).SetValidator(requestTypeValidator!)
        );
        When(
            x => x.OriginalBusinessQuery is not null,
            () => RuleFor(x => x.OriginalBusinessQuery).SetValidator(originalBusinessQueryValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>RequestType</c> and
    /// <c>OriginalBusinessQuery</c> are each validated by their own default validator
    /// (<see cref="RequestType4Choice_Validator"/>, <see cref="OriginalBusinessQuery1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MessageHeader7Validator()
        : this(new RequestType4Choice_Validator(), new OriginalBusinessQuery1Validator()) { }
}
