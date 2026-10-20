// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marks an <see cref="IIsoSimpleValue{T}"/> struct whose full W3C XSD lexical wire text cannot
/// be reconstructed by formatting <c>Value</c> alone — typically because <c>Value</c> is itself
/// a composite (a tuple or record, as with <c>xs:gYearMonth</c> or <c>xs:duration</c>), or
/// because extra lexical information sits alongside it (an optional timezone suffix, as with
/// <see cref="IIsoTimezoneQualifiedValue"/>), or because the lexical grammar of the ISO type is narrower than what
/// the parser of <c>T</c> accepts (<c>ISODate</c> is <c>YYYY-MM-DD</c> only; <c>DateOnly.Parse</c> also reads <c>10/18/2026</c>).
/// </summary>
/// <remarks>
/// <c>Iso20022XmlSerializer</c> (in the BeneficialStrategies.Iso20022 package) normally round-trips an
/// <see cref="IIsoSimpleValue{T}"/> leaf generically: parse wire text directly into <c>T</c>,
/// construct the struct from that native value; format by recursing into <c>Value</c> and
/// letting the switch in <c>FormatLeaf</c> handle whatever primitive <c>T</c> turns out to be.
/// That shortcut breaks for composite <c>T</c> — recursing into a tuple or record falls through
/// to its auto-generated <see cref="object.ToString"/> (e.g. <c>"(2026, 8)"</c>), not valid XSD
/// text. Implementing this marker tells the serializer to defer entirely to the struct's own
/// <c>(string)</c> constructor and <see cref="object.ToString"/> override instead, which know
/// the full lexical grammar.
/// </remarks>
public interface IIsoCompositeSimpleValue : IIsoSimpleType { }
