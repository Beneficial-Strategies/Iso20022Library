// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

public class ServiceCollectionExtensionsTests
{
    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
        {
            Value = new PartyIdentification272 { Name = "Acme Corp" },
        };

    private static CancelCaseAssignmentV05 ValidCancelCaseAssignment() =>
        new()
        {
            Assignment = new CaseAssignment6
            {
                Identification = "ASSIGN-001",
                Assigner = ValidParty(),
                Assignee = ValidParty(),
                CreationDateTime = DateTime.UtcNow,
            },
            Case = new Case6 { Identification = "CASE-001", Creator = ValidParty() },
        };

    // ── No filter: everything registers and resolves ──────────────────────────

    [Fact]
    public void NoFilter_RegistersEveryValidator_AcrossAreasAndSharedTypes()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        using var provider = services.BuildServiceProvider();

        // One message validator per registered business area...
        Assert.NotNull(provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<MandateCopyRequestV04>>());
        // ...and the shared component/choice validators messages in any area depend on.
        Assert.NotNull(provider.GetRequiredService<IValidator<Case6>>());
        Assert.NotNull(
            provider.GetRequiredService<IValidator<BeneficialStrategies.Iso20022.Choices.Party50Choice_>>()
        );
    }

    [Fact]
    public void NoFilter_ValidMessage_ValidatesSuccessfully()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>();
        var result = sut.Validate(ValidCancelCaseAssignment());

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    // ── DI actually wires the constructor with dependencies, not the parameterless one ────────
    //
    // This is the empirical proof requested in conversation: register a fake IValidator<Case6>
    // that rejects everything, then confirm it's the one CancelCaseAssignmentV05Validator's
    // resolved instance actually uses. If DI had silently fallen back to the parameterless
    // "default dependencies" constructor instead, that constructor builds its own internal
    // `new Case6Validator()` and this fake would never run — the otherwise-fully-valid message
    // would incorrectly validate as valid.

    private sealed class AlwaysInvalidCase6Validator : AbstractValidator<Case6>
    {
        public AlwaysInvalidCase6Validator() =>
            RuleFor(x => x).Must(_ => false).WithMessage("FAKE always-invalid Case6 validator ran");
    }

    [Fact]
    public void ResolvedValidator_UsesDIConstructor_NotParameterlessConstructor()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        // Last registration for a given service type wins when resolving a single instance —
        // this overrides the real Case6Validator registered by AddIso20022Validators() above.
        services.AddScoped<IValidator<Case6>, AlwaysInvalidCase6Validator>();
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>();
        var result = sut.Validate(ValidCancelCaseAssignment());

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.ErrorMessage == "FAKE always-invalid Case6 validator ran");
    }

    // ── Func<Type, bool> filter overload ───────────────────────────────────────

    [Fact]
    public void TypeFilter_RegistersOnlyMatchingValidators()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(filter: t => t == typeof(OtherContact1Validator));
        using var provider = services.BuildServiceProvider();

        Assert.NotNull(provider.GetRequiredService<IValidator<OtherContact1>>());
        Assert.Throws<InvalidOperationException>(() => provider.GetRequiredService<IValidator<Case6>>());
    }

    // ── Business-area overload ─────────────────────────────────────────────────

    [Fact]
    public void AreaFilter_RegistersOnlyRequestedAreas_ButAlwaysKeepsSharedTypes()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(businessAreas: ["camt"]);
        using var provider = services.BuildServiceProvider();

        // Requested area: registered.
        Assert.NotNull(provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>());

        // Non-requested area: not registered.
        Assert.Throws<InvalidOperationException>(
            () => provider.GetRequiredService<IValidator<MandateCopyRequestV04>>()
        );

        // Shared component/choice validators: always registered, regardless of area filter,
        // because camt's own message validator depends on them.
        Assert.NotNull(provider.GetRequiredService<IValidator<Case6>>());
        Assert.NotNull(
            provider.GetRequiredService<IValidator<BeneficialStrategies.Iso20022.Choices.Party50Choice_>>()
        );
    }

    [Fact]
    public void AreaFilter_RequestedAreaMessage_StillValidatesCorrectly()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(businessAreas: ["camt"]);
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>();
        var result = sut.Validate(ValidCancelCaseAssignment());

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    // ── Transitive-closure (root types) overload ───────────────────────────────

    [Fact]
    public void RootTypes_RegistersExactTransitiveClosure_NothingFromUnrelatedMessages()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(rootTypes: [typeof(CancelCaseAssignmentV05)]);
        using var provider = services.BuildServiceProvider();

        // The root itself and everything it transitively needs, several levels deep, all resolve.
        Assert.NotNull(provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<CaseAssignment6>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<Case6>>());
        Assert.NotNull(
            provider.GetRequiredService<IValidator<BeneficialStrategies.Iso20022.Choices.Party50Choice_>>()
        );
        Assert.NotNull(provider.GetRequiredService<IValidator<BranchAndFinancialInstitutionIdentification8>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<PartyIdentification272>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<Contact13>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<OtherContact1>>());

        // Nothing specific to the unrelated pain.017 (MandateCopyRequest) chain was pulled in —
        // this is the precision the namespace-based area filter can't give you: MandateCopy4
        // and GroupHeader110 live in Components too, but CancelCaseAssignmentV05 never reaches them.
        Assert.Throws<InvalidOperationException>(
            () => provider.GetRequiredService<IValidator<MandateCopyRequestV04>>()
        );
        Assert.Throws<InvalidOperationException>(() => provider.GetRequiredService<IValidator<MandateCopy4>>());
        Assert.Throws<InvalidOperationException>(
            () => provider.GetRequiredService<IValidator<GroupHeader110>>()
        );
    }

    [Fact]
    public void RootTypes_RegistersFarFewerThanFullSet()
    {
        var full = new ServiceCollection();
        full.AddIso20022Validators();

        var closure = new ServiceCollection();
        closure.AddIso20022Validators(rootTypes: [typeof(CancelCaseAssignmentV05)]);

        Assert.True(
            closure.Count < full.Count,
            $"Expected the closure ({closure.Count}) to be smaller than the full registration ({full.Count})."
        );
    }

    [Fact]
    public void RootTypes_ValidMessage_ValidatesCorrectly()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(rootTypes: [typeof(CancelCaseAssignmentV05)]);
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>();
        var result = sut.Validate(ValidCancelCaseAssignment());

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void RootTypes_MultipleRoots_UnionsBothClosures()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(
            rootTypes: [typeof(CancelCaseAssignmentV05), typeof(MandateCopyRequestV04)]
        );
        using var provider = services.BuildServiceProvider();

        Assert.NotNull(provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<MandateCopyRequestV04>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<GroupHeader110>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<Case6>>());
    }

    [Fact]
    public void RootTypes_TypeWithNoValidator_Throws()
    {
        var services = new ServiceCollection();

        var ex = Assert.Throws<ArgumentException>(
            () => services.AddIso20022Validators(rootTypes: [typeof(string)])
        );
        Assert.Contains("String", ex.Message);
    }
}
