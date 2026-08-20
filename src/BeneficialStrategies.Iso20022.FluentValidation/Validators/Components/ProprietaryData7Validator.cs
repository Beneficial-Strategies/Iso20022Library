// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ProprietaryData7"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1UAkgYKYEee7hrXqLO3yQg
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Container for proprietary information. Business content of this element is not specified.
/// <list type="table">
///   <item><term>Type</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>Data</term><description>ProprietaryData6 — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>Data</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class ProprietaryData7Validator : AbstractValidator<ProprietaryData7>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Data</c> building block — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="dataValidator">
    /// Validator for the required <c>Data</c> building block (ProprietaryData6, 1..1).
    /// </param>
    public ProprietaryData7Validator(IValidator<ProprietaryData6> dataValidator)
    {
        // Type: required (1..1) and already a `required` C# property — format enforced by the
        // struct constructor.

        RuleFor(x => x.Data).SetValidator(dataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Data</c> is validated by its own
    /// default validator (<see cref="ProprietaryData6Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public ProprietaryData7Validator()
        : this(new ProprietaryData6Validator()) { }
}
