// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using BeneficialStrategies.Iso20022.Samples;

namespace BeneficialStrategies.Iso20022.SamplesTests;

/// <summary>
/// The validators are the judge of the generated samples: the object <see cref="IsoSample.Minimal{T}"/> makes from an interface must pass the
/// validator of that interface. A rule the shape of the interface cannot say (one of two optional members must be present, a list of at least
/// two) refuses the generated object; each such interface is listed below with the rule, until a named sample is written for it.
/// A new rule that breaks a generated sample fails this test.
/// </summary>
public class GeneratedSamplesAreValidTests
{
    /// <summary>The interfaces whose generated <c>Minimal</c> the validator refuses, and the rule that does.</summary>
    private static readonly Dictionary<string, string> KnownRefusals = new(StringComparer.Ordinal)
    {
        ["IAccountAndBalance47"] = "SafekeepingAccountOrBlockChainAddress1Rule",
        ["IAccountNotification10"] = "MandatoryDebtorRule",
        ["IAccountNotification13"] = "MandatoryDebtorRule",
        ["IAccountNotification16"] = "MandatoryDebtorRule",
        ["IAccountNotification18"] = "MandatoryDebtorRule",
        ["IAccountNotification23"] = "MandatoryDebtorRule",
        ["IAccountNotification26"] = "MandatoryDebtorRule",
        ["IAccountNotification4"] = "MandatoryDebtorRule",
        ["IAccountNotification6"] = "MandatoryDebtorRule",
        ["IEstimatedFundCashForecast2"] = "ExceptionalCashFlowIndicatorRule",
        ["IFIToFICustomerCreditTransferV14"] = "TransactionInterbankSettlementDateRule",
        ["IFIToFICustomerDirectDebitV12"] = "TransactionInterbankSettlementDateRule",
        ["IFIToFIPaymentReversalV14"] = "TransactionInterbankSettlementDateRule",
        ["IFinancialInstitutionCreditTransferV13"] = "TransactionInterbankSettlementDateRule",
        ["IFundCashForecast2"] = "ExceptionalCashFlowIndicatorRule",
        ["IFundDetailedConfirmedCashForecastReport1"] = "ExceptionalCashFlowIndicatorRule",
        ["IIntraBalanceCancellation7"] = "CashAccountRule, CashAccountOwnerRule",
        ["IIntraBalanceModification7"] = "CashAccountRule, CashAccountOwnerRule",
        ["IIntraBalanceMovements4"] = "CashAccountRule, CashAccountOwnerRule",
        ["IIntraBalancePending5"] = "StatusAndReasonRule",
        ["IPEPISATransfer11"] = "InvestorRule, CorporateRule",
        ["IPaymentReturnV15"] = "TransactionInterbankSettlementDateRule",
    };

    private static IEnumerable<(Type Interface, Type Validator)> Validators() =>
        typeof(MultilateralSettlementRequestV02Validator)
            .Assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.IsPublic)
            .SelectMany(t => t.GetInterfaces()
                .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IValidator<>))
                .Select(i => (Interface: i.GetGenericArguments()[0], Validator: t)))
            .Where(p => p.Interface.IsInterface && Iso.KindOf(p.Interface) is not null)
            .GroupBy(p => p.Interface)
            .Select(g => g.First())
            .OrderBy(p => p.Interface.Name, StringComparer.Ordinal);

    private static string? Refusal(Type type, Type validatorType)
    {
        object sample;
        try
        {
            sample = IsoSample.Minimal(type);
        }
        catch (InvalidOperationException e)
        {
            return "cannot be made: " + e.Message;
        }
        var validator = Activator.CreateInstance(validatorType)!;
        var result = (FluentValidation.Results.ValidationResult)typeof(IValidator<>)
            .MakeGenericType(type)
            .GetMethod("Validate", [type])!
            .Invoke(validator, [sample])!;
        return result.IsValid ? null : string.Join("; ", result.Errors.Select(e => e.ErrorMessage).Take(2));
    }

    [Fact]
    public void EveryInterfaceWithAValidator_IsValidWithItsMinimalSample_ExceptTheKnownRefusals()
    {
        var refused = Validators()
            .Select(p => (p.Interface.Name, Why: Refusal(p.Interface, p.Validator)))
            .Where(r => r.Why is not null)
            .ToDictionary(r => r.Name, r => r.Why!, StringComparer.Ordinal);

        var unexpected = refused.Where(r => !KnownRefusals.ContainsKey(r.Key)).Select(r => $"{r.Key}: {r.Value}").ToList();
        var nowValid = KnownRefusals.Keys.Where(k => !refused.ContainsKey(k)).ToList();

        Assert.True(unexpected.Count == 0, $"{unexpected.Count} refused and not listed:\n" + string.Join("\n", unexpected));
        Assert.True(nowValid.Count == 0, "listed, but valid now (remove them from KnownRefusals): " + string.Join(", ", nowValid));
    }
}
