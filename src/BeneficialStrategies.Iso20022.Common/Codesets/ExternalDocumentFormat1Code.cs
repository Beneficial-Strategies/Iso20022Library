// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeE27iEeKo25nLKvGr8w_969448361")]
[Description(
    @"Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalDocumentFormatCode))]
public enum ExternalDocumentFormat1Code
{
    /// <summary>
    /// Document format is PDF.
    /// Encoded/decoded by serializers as &quot;DPDF&quot;.
    /// </summary>
    [EnumMember(Value = "DPDF")]
    [IsoId("_uPIrNfRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is PDF.")]
    PDF = ExternalDocumentFormatCode.PDF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document format is XML.
    /// Encoded/decoded by serializers as &quot;DXML&quot;.
    /// </summary>
    [EnumMember(Value = "DXML")]
    [IsoId("_uPIrOPRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is XML.")]
    XML = ExternalDocumentFormatCode.XML, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document format is a spreadsheet.
    /// Encoded/decoded by serializers as &quot;SDSH&quot;.
    /// </summary>
    [EnumMember(Value = "SDSH")]
    [IsoId("_uPIrO_RYEeuLhpyIdtJzwg")]
    [Description(@"Document format is a spreadsheet.")]
    Spreadsheet = ExternalDocumentFormatCode.Spreadsheet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document format is Word.
    /// Encoded/decoded by serializers as &quot;WORD&quot;.
    /// </summary>
    [EnumMember(Value = "WORD")]
    [IsoId("_uPIrPvRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is Word.")]
    Word = ExternalDocumentFormatCode.Word, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document format is XSLT.
    /// Encoded/decoded by serializers as &quot;XSLT&quot;.
    /// </summary>
    [EnumMember(Value = "XSLT")]
    [IsoId("_uPScMvRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is XSLT.")]
    XSLT = ExternalDocumentFormatCode.XSLT, // same ordinal as derivation source for type conversions
}
