// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Thrown by <c>Iso20022XmlSerializer.Deserialize</c> when the XML cannot be read as the message: it carries <b>every</b> problem
/// found, each with the path of its element and, when the document was loaded with line information, its line and position.
/// </summary>
/// <remarks>
/// The reader that reports without throwing is <c>Iso20022XmlSerializer.TryRead</c>; this exception is what <c>Deserialize</c> makes
/// of its result. <c>TryDeserialize</c> hands it back in its <c>error</c> argument.
/// </remarks>
public sealed class Iso20022DeserializationException : InvalidOperationException
{
    /// <summary>Every problem found, in document order. Never empty.</summary>
    public IReadOnlyList<DeserializationIssue> Issues { get; }

    /// <summary>The first problem found.</summary>
    public DeserializationIssue First => Issues[0];

    /// <summary>The path of the element of the first problem, for example <c>Document/FIToFICstmrCdtTrf/GrpHdr/MsgId</c>.</summary>
    public string Path => First.Path;

    /// <summary>The line of the first problem, when the document was loaded with line information.</summary>
    public int? Line => First.Line;

    /// <summary>The position in the line of the first problem, when the document was loaded with line information.</summary>
    public int? Position => First.Position;

    /// <summary>The text that was rejected in the first problem, when there is one.</summary>
    public string? Value => First.Value;

    /// <summary>Creates the exception for the problems found in reading a <paramref name="messageType"/>.</summary>
    public Iso20022DeserializationException(Type messageType, IReadOnlyList<DeserializationIssue> issues)
        : base(Describe(messageType, issues))
    {
        Issues = issues;
    }

    private static string Describe(Type messageType, IReadOnlyList<DeserializationIssue> issues)
    {
        if (issues is null || issues.Count == 0)
            throw new ArgumentException("There is no problem to describe.", nameof(issues));
        var more = issues.Count > 1 ? $" (and {issues.Count - 1} more problem{(issues.Count > 2 ? "s" : "")})" : "";
        return $"The XML could not be read as {messageType.Name}: {issues[0]}{more}";
    }
}
