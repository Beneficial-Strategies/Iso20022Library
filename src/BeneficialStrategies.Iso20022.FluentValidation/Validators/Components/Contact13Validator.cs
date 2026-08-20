// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Contact13"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _YinuxzE_Ee62xuUQ2zyZww
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the details of the contact person.
/// <list type="table">
///   <item><term>NamePrefix</term><description>NamePrefix2Code — optional (0..1)</description></item>
///   <item><term>Name</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>PhoneNumber</term><description>PhoneNumber — optional (0..1)</description></item>
///   <item><term>MobileNumber</term><description>PhoneNumber — optional (0..1)</description></item>
///   <item><term>FaxNumber</term><description>PhoneNumber — optional (0..1)</description></item>
///   <item><term>URLAddress</term><description>Max2048Text — optional (0..1)</description></item>
///   <item><term>EmailAddress</term><description>Max256Text — optional (0..1)</description></item>
///   <item><term>EmailPurpose</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>JobTitle</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Responsibility</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Department</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>Other</term><description>OtherContact1 — optional (0..∞)</description></item>
///   <item><term>PreferredMethod</term><description>PreferredContactMethod2Code — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Other</c> collection is validated per-item by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class Contact13Validator : AbstractValidator<Contact13>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Other</c> collection's item type — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="otherValidator">
    /// Validator for each item of the <c>Other</c> collection (OtherContact1, 0..∞).
    /// </param>
    public Contact13Validator(IValidator<OtherContact1> otherValidator)
    {
        // All scalar fields (NamePrefix, Name, PhoneNumber, MobileNumber, FaxNumber, URLAddress,
        // EmailAddress, EmailPurpose, JobTitle, Responsibility, Department, PreferredMethod):
        // optional, length/pattern enforced by struct constructors — no rule needed.

        RuleForEach(x => x.Other).SetValidator(otherValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Other</c> collection is
    /// validated by its own default validator (<see cref="OtherContact1Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public Contact13Validator()
        : this(new OtherContact1Validator()) { }
}
