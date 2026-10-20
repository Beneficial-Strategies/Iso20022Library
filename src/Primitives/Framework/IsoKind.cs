// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>The kind of an ISO 20022 model type, as <see cref="Iso.KindOf(Type)"/> reports it.</summary>
public enum IsoKind
{
    /// <summary>A message definition (<see cref="Framework.IOuterRecord"/>).</summary>
    Message,

    /// <summary>A message component (<see cref="IIsoComponent"/>).</summary>
    Component,

    /// <summary>A choice (<see cref="IIsoChoice"/>).</summary>
    Choice,

    /// <summary>One variant of a choice (<see cref="IIsoChoiceVariant"/>).</summary>
    ChoiceVariant,

    /// <summary>A simple (primitive) data type (<see cref="IIsoSimpleType"/>).</summary>
    SimpleType,

    /// <summary>An external code, a string-valued struct whose code list ISO 20022 does not own (<see cref="IIsoExternalCode"/>).</summary>
    ExternalCode,

    /// <summary>A code set: an enum that carries an <c>[IsoId]</c>. An enum cannot implement an interface, so it is recognised by its attribute.</summary>
    CodeSet,

    /// <summary>A currency-and-amount data type (<see cref="IIsoAmount"/>).</summary>
    Amount,

    /// <summary>An open-content slot (<see cref="IIsoOpenContent"/>).</summary>
    OpenContent,
}
