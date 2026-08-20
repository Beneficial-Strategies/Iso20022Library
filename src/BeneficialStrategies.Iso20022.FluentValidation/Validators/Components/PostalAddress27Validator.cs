// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PostalAddress27"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _vvaRYTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Information that locates and identifies a specific address, as defined by postal services.
/// <list type="table">
///   <item><term>AddressType</term><description>AddressType3Choice_ — optional (0..1)</description></item>
///   <item><term>CareOf</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>Department</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>SubDepartment</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>StreetName</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>BuildingNumber</term><description>Max16Text — optional (0..1)</description></item>
///   <item><term>BuildingName</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>Floor</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>UnitNumber</term><description>Max16Text — optional (0..1)</description></item>
///   <item><term>PostBox</term><description>Max16Text — optional (0..1)</description></item>
///   <item><term>Room</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>PostCode</term><description>Max16Text — optional (0..1)</description></item>
///   <item><term>TownName</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>TownLocationName</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>DistrictName</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>CountrySubDivision</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Country</term><description>CountryCode — optional (0..1)</description></item>
///   <item><term>AddressLine</term><description>Max70Text — optional (0..7 per XSD; multiplicity not enforceable via <c>SimpleValueList&lt;T&gt;</c>, no compile-time bound)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>AddressType</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c>; <c>Country</c> — an ISO 3166
/// <see cref="CountryCode"/> — is checked against an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> (via <see cref="CountryCodeValidator"/>) — see the
/// two constructors below.
/// </remarks>
public class PostalAddress27Validator : AbstractValidator<PostalAddress27>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>AddressType</c> building block and <c>Country</c> — e.g. resolved from
    /// a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="addressTypeValidator">
    /// Validator for the optional <c>AddressType</c> building block (AddressType3Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="countryValidator">
    /// Validator for the optional <c>Country</c> (CountryCode, 0..1) — only invoked when present.
    /// </param>
    public PostalAddress27Validator(
        IValidator<AddressType3Choice_> addressTypeValidator,
        IValidator<CountryCode> countryValidator
    )
    {
        // All scalar fields (CareOf, Department, SubDepartment, StreetName, BuildingNumber,
        // BuildingName, Floor, UnitNumber, PostBox, Room, PostCode, TownName, TownLocationName,
        // DistrictName, CountrySubDivision, AddressLine): optional, length/pattern enforced by
        // struct constructors — no rule needed.

        When(
            x => x.AddressType is not null,
            () => RuleFor(x => x.AddressType).SetValidator(addressTypeValidator!)
        );

        When(
            x => x.Country is not null,
            () => RuleFor(x => x.Country!.Value).SetValidator(countryValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>AddressType</c> building
    /// block and <c>Country</c> are each validated by their own default validator
    /// (<see cref="AddressType3Choice_Validator"/>, <see cref="CountryCodeValidator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public PostalAddress27Validator()
        : this(new AddressType3Choice_Validator(), new CountryCodeValidator()) { }
}
