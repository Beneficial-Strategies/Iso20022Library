// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Framework;

/// <summary>
/// Best-effort canonicalization of a <see cref="Party53Choice_"/> into a single comparable
/// string, for use as a fallback saga-correlation key.
/// </summary>
/// <remarks>
/// <see cref="Party53Choice_"/> has no single mandatory identity field — it is EITHER
/// <c>OrganisationIdentification40</c> (<c>AnyBIC</c>?, <c>LEI</c>?, <c>EmailAddress</c>?,
/// <c>Other[]</c> — all optional, any combination) OR <c>PersonIdentification20</c> (private
/// individual identification, similarly all-optional). "The" identity of a Creditor/Debtor is
/// inherently ambiguous from the ISO model alone. The priority order below
/// (LEI &gt; AnyBIC &gt; first <c>Other</c> entry &gt; email) is a pragmatic default, NOT specified
/// by ISO 20022 — it is not the deletion/EDIT candidate ordering, just this class's own choice.
/// Callers with domain knowledge of which identifier their counterparties actually populate
/// should compute their own key and use MassTransit's own correlation configuration to match on
/// it instead of relying on this default. Two <see cref="Party53Choice_"/> payloads that are "the
/// same real-world party" via different populated identifier fields will NOT canonicalize to the
/// same key by this default logic.
/// </remarks>
public static class PartyIdentityKey
{
    /// <summary>
    /// Computes a best-effort canonical key for <paramref name="party"/>, or <see langword="null"/>
    /// if none of the recognized identity fields are populated.
    /// </summary>
    public static string? From(Party53Choice_? party) =>
        party switch
        {
            Party53Choice.OrganisationIdentification { Value: var organisation } =>
                FromOrganisation(organisation),
            Party53Choice.PrivateIdentification { Value: var person } => FromPerson(person),
            _ => null,
        };

    private static string? FromOrganisation(OrganisationIdentification40 organisation)
    {
        if (organisation.LEI is { } lei)
            return $"LEI:{lei.Value}";

        if (organisation.AnyBIC is { } anyBic)
            return $"BIC:{anyBic.Value}";

        var firstOther = organisation.Other.FirstOrDefault();
        if (firstOther is not null)
            return $"OTHER:{firstOther.Identification.Value}";

        if (organisation.EmailAddress is { } email)
            return $"EMAIL:{email.Value}";

        return null;
    }

    private static string? FromPerson(PersonIdentification20 person)
    {
        var firstOther = person.Other.FirstOrDefault();
        if (firstOther is not null)
            return $"OTHER:{firstOther.Identification.Value}";

        if (person.EmailAddress is { } email)
            return $"EMAIL:{email.Value}";

        return null;
    }
}
