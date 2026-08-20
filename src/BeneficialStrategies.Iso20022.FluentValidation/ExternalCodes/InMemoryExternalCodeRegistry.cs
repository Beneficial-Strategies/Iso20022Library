// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Default <see cref="IExternalCodeRegistry{TCode}"/>: an in-memory set of acceptable values,
/// auto-seeded from <typeparamref name="TCode"/>'s own declared known values and freely
/// adjustable afterward.
/// </summary>
/// <remarks>
/// Two-tier default behavior, driven entirely by what <typeparamref name="TCode"/> itself
/// declares — nothing about a specific code set is known to this class:
/// <list type="bullet">
///   <item>
///     <description>
///     If <typeparamref name="TCode"/> declares no <c>public static readonly</c> known-value
///     members (a fully open code set — the ISO 20022 MCP server had nothing to offer beyond the
///     structural pattern), the registry starts empty and <see cref="IsAcceptable"/> is
///     permissive: everything satisfying the struct's own format constructor passes. There is
///     nothing to check membership against, so nothing is rejected on that basis.
///     </description>
///   </item>
///   <item>
///     <description>
///     If <typeparamref name="TCode"/> declares known-value members (the "hybrid pattern" — see
///     the main library's own CLAUDE.md), the registry auto-seeds from them at construction and
///     becomes restrictive: only those values (until adjusted) are acceptable.
///     </description>
///   </item>
/// </list>
/// The seeding is genuine reflection against <typeparamref name="TCode"/>'s current compiled
/// metadata, not a hardcoded list — a future snapshot sync that adds a new
/// <c>public static readonly</c> member to the type is picked up automatically the next time this
/// registry is constructed. No change to this class, <see cref="ExternalCodesetAbstractValidator{TCode}"/>,
/// or the per-type validator is ever needed for that.
///
/// <see cref="Add"/>/<see cref="Remove"/> let a consumer tweak the seeded set before registering
/// an instance with the DI container — e.g. adding a code newer than the snapshot, or removing one
/// a specific deployment doesn't want to allow:
/// <code>
/// var reasons = new InMemoryExternalCodeRegistry&lt;ExternalMandateSetupReason1Code&gt;(); // auto-seeded
/// reasons.Add("ZZZZ");
/// reasons.Remove("MD01");
/// services.AddSingleton&lt;IExternalCodeRegistry&lt;ExternalMandateSetupReason1Code&gt;&gt;(reasons);
/// </code>
/// </remarks>
public class InMemoryExternalCodeRegistry<TCode> : IExternalCodeRegistry<TCode>
    where TCode : IIsoExternalCode
{
    private readonly HashSet<string> _acceptableValues = new();

    /// <summary>
    /// Initializes a new instance, optionally auto-seeded from <typeparamref name="TCode"/>'s own
    /// declared known-value members.
    /// </summary>
    /// <param name="seedFromKnownMembers">
    /// When <see langword="true"/> (the default), pre-populates the registry by reflecting over
    /// every <c>public static readonly</c> field of type <typeparamref name="TCode"/> declared on
    /// <typeparamref name="TCode"/> itself. Types with no such members end up empty either way, so
    /// this only matters for hybrid-pattern types. Pass <see langword="false"/> to start from a
    /// blank slate (fully permissive) regardless of what the type declares.
    /// </param>
    public InMemoryExternalCodeRegistry(bool seedFromKnownMembers = true)
    {
        if (!seedFromKnownMembers)
        {
            return;
        }

        foreach (var field in typeof(TCode).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (field.FieldType == typeof(TCode) && field.GetValue(null) is TCode known)
            {
                _acceptableValues.Add(known.Value);
            }
        }
    }

    /// <summary>Adds a single acceptable value.</summary>
    public void Add(string value) => _acceptableValues.Add(value);

    /// <summary>Adds multiple acceptable values.</summary>
    public void AddRange(IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            Add(value);
        }
    }

    /// <summary>Removes a single value, if present. Returns whether it was present.</summary>
    public bool Remove(string value) => _acceptableValues.Remove(value);

    /// <summary>Removes multiple values, where present.</summary>
    public void RemoveRange(IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            Remove(value);
        }
    }

    /// <summary>
    /// Returns the acceptable values currently held, for a derived class that wants to layer
    /// additional logic (e.g. an extra rejection rule) on top of the base membership check
    /// without duplicating it.
    /// </summary>
    protected IReadOnlySet<string> AcceptableValues => _acceptableValues;

    /// <inheritdoc/>
    /// <remarks>
    /// Declared <see langword="virtual"/> specifically so a consumer can subclass this type and
    /// add an extra requirement on top of the base membership check — e.g. rejecting a value this
    /// registry would otherwise accept, for a reason specific to one deployment — while still
    /// getting the auto-seeding and <see cref="Add"/>/<see cref="Remove"/> behavior for free. See
    /// the FluentValidation package's own README for a worked example. Because DI always resolves
    /// this type through the <see cref="IExternalCodeRegistry{TCode}"/> interface, an
    /// <see langword="override"/> here is what actually takes effect at resolution time — a
    /// non-virtual method hidden with <see langword="new"/> would not.
    /// </remarks>
    public virtual bool IsAcceptable(TCode value) =>
        _acceptableValues.Count == 0 || _acceptableValues.Contains(value.Value);
}
