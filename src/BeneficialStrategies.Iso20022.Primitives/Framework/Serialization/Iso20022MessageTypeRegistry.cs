// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Process-wide registry of every <see cref="IOuterRecord"/> message type in the assemblies that hold them, keyed
/// by the identifiers that appear on (or alongside) the wire: the ISO 20022 message identifier
/// (e.g. <c>"pacs.008.001.14"</c>) and the XML document namespace (e.g.
/// <c>"urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14"</c>).
/// </summary>
/// <remarks>
/// The message records are not in this assembly. The registry reflects over the assemblies given to
/// <see cref="AddAssembly"/> and over every loaded assembly that references this one (the records' assembly
/// is one as soon as any of its types has been used), and caches the result: subsequent lookups are plain dictionary
/// reads, until another assembly is loaded or added. Call <see cref="AddAssembly"/> with the records' assembly when
/// a payload may arrive before any record type has been touched.
/// <para>
/// There is no equivalent self-describing discriminator for JSON payloads. ISO 20022's JSON
/// binding carries no root element/namespace analogous to the XML <c>&lt;Document xmlns="..."&gt;</c>
/// wrapper, so a JSON payload alone cannot say which message type it is — dispatching JSON to the
/// correct type always requires an out-of-band hint (a queue header, HTTP content-type parameter,
/// enclosing envelope, or similar) resolved via <see cref="TryGetByIsoIdentifier"/>, not sniffed
/// from the payload the way <see cref="TryGetByDocumentNamespace"/> sniffs XML.
/// </para>
/// </remarks>
public static class Iso20022MessageTypeRegistry
{
    /// <summary>
    /// Every <see cref="IOuterRecord"/> message type of the known assemblies, keyed by its
    /// <c>IsoIdentifier</c> constant (e.g. <c>"pacs.008.001.14"</c>).
    /// </summary>
    public static IReadOnlyDictionary<string, Type> ByIsoIdentifier => Registry().ByIsoIdentifier;

    /// <summary>
    /// Every <see cref="IOuterRecord"/> message type of the known assemblies, keyed by its
    /// <c>DocumentNamespace</c> constant (e.g. <c>"urn:iso:std:iso:20022:tech:xsd:pacs.008.001.14"</c>).
    /// </summary>
    public static IReadOnlyDictionary<string, Type> ByDocumentNamespace => Registry().ByDocumentNamespace;

    /// <summary>
    /// Every message <em>interface</em> of the known assemblies (one marked with <see cref="IsoMessageAttribute"/>), keyed by its
    /// <c>IsoIdentifier</c>. Present whether or not the records are: it is how a reader that has only the interfaces and a
    /// factory finds the type of a message.
    /// </summary>
    public static IReadOnlyDictionary<string, Type> InterfaceByIsoIdentifier => Registry().InterfaceById;

    /// <summary>Every message interface of the known assemblies, keyed by the namespace of its document.</summary>
    public static IReadOnlyDictionary<string, Type> InterfaceByDocumentNamespace => Registry().InterfaceByNamespace;

    /// <summary>Attempts to resolve a message interface from its XML document namespace.</summary>
    public static bool TryGetInterfaceByDocumentNamespace(string documentNamespace, [NotNullWhen(true)] out Type? messageInterface) =>
        InterfaceByDocumentNamespace.TryGetValue(documentNamespace, out messageInterface);

    /// <summary>Attempts to resolve a message interface from its ISO 20022 message identifier.</summary>
    public static bool TryGetInterfaceByIsoIdentifier(string isoIdentifier, [NotNullWhen(true)] out Type? messageInterface) =>
        InterfaceByIsoIdentifier.TryGetValue(isoIdentifier, out messageInterface);

    /// <summary>
    /// Attempts to resolve a message type from its XML document namespace — e.g. the root
    /// element's <c>xmlns</c> attribute value.
    /// </summary>
    public static bool TryGetByDocumentNamespace(
        string documentNamespace,
        [NotNullWhen(true)] out Type? messageType
    ) => ByDocumentNamespace.TryGetValue(documentNamespace, out messageType);

    /// <summary>
    /// Attempts to resolve a message type from its ISO 20022 message identifier (e.g.
    /// <c>"pacs.008.001.14"</c>).
    /// </summary>
    public static bool TryGetByIsoIdentifier(string isoIdentifier, [NotNullWhen(true)] out Type? messageType) =>
        ByIsoIdentifier.TryGetValue(isoIdentifier, out messageType);

    private static readonly object Gate = new();
    private static readonly HashSet<Assembly> Added = [];
    private sealed record Index(
        IReadOnlyDictionary<string, Type> ByIsoIdentifier,
        IReadOnlyDictionary<string, Type> ByDocumentNamespace,
        IReadOnlyDictionary<string, Type> InterfaceById,
        IReadOnlyDictionary<string, Type> InterfaceByNamespace
    );

    private static Index? _cache;

    static Iso20022MessageTypeRegistry() => AppDomain.CurrentDomain.AssemblyLoad += (_, _) => Invalidate();

    /// <summary>Makes the message records of <paramref name="assembly"/> known to the registry.</summary>
    public static void AddAssembly(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        lock (Gate)
        {
            Added.Add(assembly);
            _cache = null;
        }
    }

    private static void Invalidate()
    {
        lock (Gate)
            _cache = null;
    }

    private static Index Registry()
    {
        lock (Gate)
            return _cache ??= Build();
    }

    private static Index Build()
    {
        var byId = new Dictionary<string, Type>(StringComparer.Ordinal);
        var byNamespace = new Dictionary<string, Type>(StringComparer.Ordinal);
        var interfaceById = new Dictionary<string, Type>(StringComparer.Ordinal);
        var interfaceByNamespace = new Dictionary<string, Type>(StringComparer.Ordinal);

        var self = typeof(Iso20022MessageTypeRegistry).Assembly;
        var assemblies = new HashSet<Assembly>(Added);
        foreach (var loaded in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (loaded.IsDynamic)
                continue;
            if (loaded.GetReferencedAssemblies().Any(r => r.Name == self.GetName().Name))
                assemblies.Add(loaded);
        }

        foreach (var assembly in assemblies)
        {
            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                types = ex.Types.Where(t => t is not null).ToArray()!;
            }

            foreach (var type in types)
            {
                if (type.IsInterface && typeof(IOuterRecord).IsAssignableFrom(type))
                {
                    if (type.GetCustomAttributes(typeof(IsoMessageAttribute), false).FirstOrDefault() is IsoMessageAttribute message)
                    {
                        interfaceById[message.IsoIdentifier] = type;
                        interfaceByNamespace[message.DocumentNamespace] = type;
                    }
                    continue;
                }
                if (type.IsAbstract || !typeof(IOuterRecord).IsAssignableFrom(type))
                    continue;

                if (GetStaticStringConstant(type, "IsoIdentifier") is { } id)
                    byId[id] = type;
                if (GetStaticStringConstant(type, "DocumentNamespace") is { } ns)
                    byNamespace[ns] = type;
            }
        }

        return new Index(byId, byNamespace, interfaceById, interfaceByNamespace);
    }

    private static string? GetStaticStringConstant(Type type, string fieldName) =>
        type.GetField(fieldName, BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as string;
}
