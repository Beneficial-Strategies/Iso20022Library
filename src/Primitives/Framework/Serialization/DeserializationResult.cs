// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>What kind of problem a <see cref="DeserializationIssue"/> reports.</summary>
public enum IssueCode
{
    /// <summary>The text is not well-formed XML.</summary>
    MalformedXml,

    /// <summary>The document root, or the message element under it, is not the expected one.</summary>
    WrongRoot,

    /// <summary>A required element or attribute is absent.</summary>
    RequiredMissing,

    /// <summary>The text cannot be read as the member's type (not a number, not a date, not an enum value).</summary>
    BadValue,

    /// <summary>The text is of the right kind but breaks an ISO facet (length, pattern, range).</summary>
    FacetViolation,

    /// <summary>None of the variants of a choice is present.</summary>
    UnknownChoice,

    /// <summary>More than one variant of a choice is present.</summary>
    AmbiguousChoice,

    /// <summary>A child element that the type does not define.</summary>
    UnexpectedElement,
}

/// <summary>One problem found while reading a document.</summary>
/// <param name="Path">Where, as element names from the document element, with one-based indexes on repeated elements: <c>Document/PayInCall/RptData/PayInCallAmt[2]/Amt</c>. An attribute ends in <c>/@Ccy</c>.</param>
/// <param name="Code">The kind of problem.</param>
/// <param name="Value">The offending text, when there is one.</param>
/// <param name="Reason">What is wrong, in English.</param>
/// <param name="Line">The line in the source text, when the document was loaded with line information.</param>
/// <param name="Position">The position on that line.</param>
public sealed record DeserializationIssue(
    string Path,
    IssueCode Code,
    string? Value,
    string Reason,
    int? Line = null,
    int? Position = null
)
{
    /// <summary>The path, the kind, the reason and the line, on one line.</summary>
    public override string ToString() =>
        $"{Path}: {Code}: {Reason}" + (Line is null ? "" : $" (line {Line}, position {Position})");
}

/// <summary>
/// The outcome of reading XML into an ISO 20022 record: either the complete record, or every
/// problem found. A record is never returned together with issues, because a record that was
/// built by reflection around a problem can hold a default value in a member that is required.
/// </summary>
public sealed class DeserializationResult<TMessage>
    where TMessage : class
{
    private DeserializationResult(TMessage? message, IReadOnlyList<DeserializationIssue> issues)
    {
        Message = message;
        Issues = issues;
    }

    /// <summary>The record, set only when <see cref="Issues"/> is empty.</summary>
    public TMessage? Message { get; }

    /// <summary>Every problem found, in document order. Empty when <see cref="Succeeded"/>.</summary>
    public IReadOnlyList<DeserializationIssue> Issues { get; }

    /// <summary>True when <see cref="Message"/> is set.</summary>
    public bool Succeeded => Message is not null;

    internal static DeserializationResult<TMessage> Success(TMessage message) => new(message, []);

    internal static DeserializationResult<TMessage> Failure(IReadOnlyList<DeserializationIssue> issues) =>
        new(null, issues);
}

/// <summary>What the caller knows that the element being read does not say.</summary>
/// <param name="Namespace">
/// The namespace of the element's children, when it is not the namespace of the element itself.
/// When null the element's own namespace is used, which covers an element inside a larger document
/// (it has inherited the namespace of its parent) and a fragment parsed on its own, whether it
/// declares a namespace or has none. It is needed when the element is in a wrapper namespace of
/// the caller's and the ISO members under it are in another.
/// </param>
/// <param name="PathPrefix">Put before the element's name in issue paths, so a part read out of a larger document reports where it was found.</param>
public sealed record ReadContext(XNamespace? Namespace = null, string? PathPrefix = null);
