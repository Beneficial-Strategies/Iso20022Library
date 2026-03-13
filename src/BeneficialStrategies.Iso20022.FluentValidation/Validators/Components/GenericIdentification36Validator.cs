// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GenericIdentification36"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _ARhDQNokEeC60axPepSq7g_-809870990
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>SchemeName</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
/// </remarks>
public sealed class GenericIdentification36Validator : AbstractValidator<GenericIdentification36>
{
    public GenericIdentification36Validator()
    {
        RuleFor(x => x.Identification)
            .NotEmpty()
            .MinimumLength(1).MaximumLength(35);

        RuleFor(x => x.Issuer)
            .NotEmpty()
            .MinimumLength(1).MaximumLength(35);

        RuleFor(x => x.SchemeName)
            .MinimumLength(1).MaximumLength(35)
            .When(x => x.SchemeName is not null);
    }
}
