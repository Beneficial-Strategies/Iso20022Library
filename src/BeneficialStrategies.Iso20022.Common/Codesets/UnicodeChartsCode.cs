// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codelist containing the names of the UNICODE code block name as specified on http://unicode.org/Public/UNIDATA/Blocks.txt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YghNkNp-Ed-ak6NoX_4Aeg_728068642")]
[Description(@"Codelist containing the names of the UNICODE code block name as specified on http://unicode.org/Public/UNIDATA/Blocks.txt.")]
[JsonConverter(typeof(Iso20022EnumJsonConverter<UnicodeChartsCode>))]
public enum UnicodeChartsCode
{
    // No code values are published for this code set in the current snapshot.
}
