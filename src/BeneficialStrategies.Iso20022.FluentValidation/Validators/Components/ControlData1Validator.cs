// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ControlData1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RqlQiNp-Ed-ak6NoX_4Aeg_518525040
/// Spec source: ControlData1 message component.
/// <list type="table">
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1), pattern [0-9]{1,15}</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
/// </list>
/// </remarks>
public class ControlData1Validator : AbstractValidator<ControlData1>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="ControlData1"/>.
    /// </summary>
    public ControlData1Validator()
    {
        RuleFor(x => x.NumberOfTransactions)
            .NotEmpty()
            .WithMessage("ControlData1.NumberOfTransactions is required (Max15NumericText, 1..1).");
        // Pattern [0-9]{1,15} enforced by Max15NumericText constructor.
    }
}
