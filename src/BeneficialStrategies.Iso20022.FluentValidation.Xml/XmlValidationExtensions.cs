// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Validate ISO 20022 XML straight from text, a document or an element: the XML is read, every problem in it is reported
/// with its path, and when it could be read, the validator's rules run on the result.
/// </summary>
/// <remarks>
/// <para>
/// The validators are written for the interfaces (<c>IValidator&lt;IFoo&gt;</c>), and an interface cannot be read into, so
/// each method names both: <c>TInterface</c> is the interface the validator is for, and
/// <c>TRecord</c> is the class the XML is read into. <c>TInterface</c> is inferred from the
/// validator, and <c>TRecord</c> from the <c>out</c> argument when it is declared with its type:
/// <c>validator.Validate(xml, out FooV01? message)</c>. <c>out var message</c> cannot say which class to read, and does not compile.
/// </para>
/// <para>
/// <b>What the result and <c>message</c> mean.</b> If the XML could not be read, the result holds only the reading problems
/// (error code <c>Xml.</c> + the problem's <see cref="IssueCode"/>, property name = the XML path), the rules do not run, and
/// <c>message</c> is <see langword="null"/>: the rules must not judge a half-built record, which would report as business
/// errors what are only effects of a missing element. If the XML could be read, <c>message</c> is the record
/// <b>whether or not the rules passed</b>, so a caller can log or inspect it, and the result holds the rule failures
/// (property name = the property path, as for any validation). <see cref="ValidationResult.IsValid"/> says whether the whole
/// thing passed. The property name of a failure is therefore an XML path for a reading problem and a property path for a rule;
/// the <c>Xml.</c> prefix of the error code tells them apart, and <see cref="ValidationFailure.CustomState"/> of a reading
/// problem is the <see cref="DeserializationIssue"/> itself, for its line and position.
/// </para>
/// <para>
/// <see cref="IValidator{T}"/> is contravariant, so a validator for an interface is also a validator for every class that
/// implements it, and code that holds an <c>IValidator&lt;TheRecord&gt;</c> can use these methods with
/// <c>TInterface</c> = the record.
/// </para>
/// </remarks>
public static class XmlValidationExtensions
{
    /// <summary>The prefix of the error code of a reading problem: <c>Xml.</c> + the <see cref="IssueCode"/>.</summary>
    public const string ErrorCodePrefix = "Xml.";

    /// <summary>Reads any part of a document, a component, a choice or a message, rooted at <paramref name="element"/>, and validates it.</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="element">The element to read. Its own name is not checked, since the same type appears under many tags.</param>
    /// <param name="message">The record that was read, or <see langword="null"/> when the XML could not be read.</param>
    /// <param name="context">The namespace and the path prefix of the element when it is a fragment of a larger document.</param>
    public static ValidationResult Validate<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        XElement element,
        out TRecord? message,
        ReadContext? context = null
    )
        where TRecord : class, TInterface
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        if (element is null)
            throw new System.ArgumentNullException(nameof(element));
        return Finish(validator, Iso20022XmlSerializer.Read<TRecord>(element, context), out message);
    }

    /// <summary>Reads a document into a message, and validates it.</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="document">The document.</param>
    /// <param name="message">The record that was read, or <see langword="null"/> when the XML could not be read.</param>
    public static ValidationResult Validate<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        XDocument document,
        out TRecord? message
    )
        where TRecord : class, TInterface, IOuterRecord
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        return Finish(validator, Iso20022XmlSerializer.TryRead<TRecord>(document), out message);
    }

    /// <summary>Reads XML text into a message, and validates it.</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="xml">The XML text. Malformed XML is reported as one problem, with its line and position.</param>
    /// <param name="message">The record that was read, or <see langword="null"/> when the XML could not be read.</param>
    public static ValidationResult Validate<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        string xml,
        out TRecord? message
    )
        where TRecord : class, TInterface, IOuterRecord
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        return Finish(validator, Iso20022XmlSerializer.TryRead<TRecord>(xml), out message);
    }

    /// <summary>Reads any part of a document rooted at <paramref name="element"/>, and validates it; the async form of the element method, returning the result and the record (<see langword="null"/> when the XML could not be read).</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="element">The element to read.</param>
    /// <param name="context">The namespace and the path prefix of the element when it is a fragment of a larger document.</param>
    /// <param name="cancellationToken">Cancels the validation.</param>
    public static Task<(ValidationResult Result, TRecord? Message)> ValidateAsync<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        XElement element,
        ReadContext? context = null,
        CancellationToken cancellationToken = default
    )
        where TRecord : class, TInterface
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        if (element is null)
            throw new System.ArgumentNullException(nameof(element));
        return FinishAsync(validator, Iso20022XmlSerializer.Read<TRecord>(element, context), cancellationToken);
    }

    /// <summary>Reads a document into a message, and validates it; the async form of the document method, returning the result and the record (<see langword="null"/> when the XML could not be read).</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="document">The document.</param>
    /// <param name="cancellationToken">Cancels the validation.</param>
    public static Task<(ValidationResult Result, TRecord? Message)> ValidateAsync<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        XDocument document,
        CancellationToken cancellationToken = default
    )
        where TRecord : class, TInterface, IOuterRecord
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        return FinishAsync(validator, Iso20022XmlSerializer.TryRead<TRecord>(document), cancellationToken);
    }

    /// <summary>Reads XML text into a message, and validates it; the async form of the text method, returning the result and the record (<see langword="null"/> when the XML could not be read).</summary>
    /// <param name="validator">The validator for the interface that <c>TRecord</c> implements.</param>
    /// <param name="xml">The XML text.</param>
    /// <param name="cancellationToken">Cancels the validation.</param>
    public static Task<(ValidationResult Result, TRecord? Message)> ValidateAsync<TInterface, TRecord>(
        this IValidator<TInterface> validator,
        string xml,
        CancellationToken cancellationToken = default
    )
        where TRecord : class, TInterface, IOuterRecord
    {
        if (validator is null)
            throw new System.ArgumentNullException(nameof(validator));
        return FinishAsync(validator, Iso20022XmlSerializer.TryRead<TRecord>(xml), cancellationToken);
    }

    /// <summary>The failure that reports one reading problem.</summary>
    public static ValidationFailure ToFailure(this DeserializationIssue issue)
    {
        if (issue is null)
            throw new System.ArgumentNullException(nameof(issue));
        return new ValidationFailure(issue.Path, issue.Reason, issue.Value)
        {
            ErrorCode = ErrorCodePrefix + issue.Code,
            CustomState = issue,
        };
    }

    private static ValidationResult Finish<TInterface, TRecord>(
        IValidator<TInterface> validator,
        DeserializationResult<TRecord> read,
        out TRecord? message
    )
        where TRecord : class, TInterface
    {
        message = read.Message;
        return read.Message is null
            ? new ValidationResult(read.Issues.Select(ToFailure).ToList())
            : validator.Validate(read.Message);
    }

    private static async Task<(ValidationResult Result, TRecord? Message)> FinishAsync<TInterface, TRecord>(
        IValidator<TInterface> validator,
        DeserializationResult<TRecord> read,
        CancellationToken cancellationToken
    )
        where TRecord : class, TInterface
    {
        if (read.Message is null)
            return (new ValidationResult(read.Issues.Select(ToFailure).ToList()), null);
        var result = await validator.ValidateAsync(read.Message, cancellationToken).ConfigureAwait(false);
        return (result, read.Message);
    }
}
