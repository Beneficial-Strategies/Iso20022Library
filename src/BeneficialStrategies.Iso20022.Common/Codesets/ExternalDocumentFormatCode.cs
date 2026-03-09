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
[IsoId("_-M07BG7iEeKo25nLKvGr8w_1805570785")]
[Description(@"Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalDocumentFormat1Code))]
public enum ExternalDocumentFormatCode
{
    /// <summary>
    /// Document format is PDF.
    /// Encoded/decoded by serializers as &quot;DPDF&quot;.
    /// </summary>
    [EnumMember(Value = "DPDF")]
    [IsoId("_uPIrM_RYEeuLhpyIdtJzwg")]
    [Description(@"Document format is PDF.")]
    PDF,
    
    /// <summary>
    /// Document format is XML.
    /// Encoded/decoded by serializers as &quot;DXML&quot;.
    /// </summary>
    [EnumMember(Value = "DXML")]
    [IsoId("_uPIrNvRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is XML.")]
    XML,
    
    /// <summary>
    /// Document format is a spreadsheet.
    /// Encoded/decoded by serializers as &quot;SDSH&quot;.
    /// </summary>
    [EnumMember(Value = "SDSH")]
    [IsoId("_uPIrOfRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is a spreadsheet.")]
    Spreadsheet,
    
    /// <summary>
    /// Document format is Word.
    /// Encoded/decoded by serializers as &quot;WORD&quot;.
    /// </summary>
    [EnumMember(Value = "WORD")]
    [IsoId("_uPIrPPRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is Word.")]
    Word,
    
    /// <summary>
    /// Document format is XSLT.
    /// Encoded/decoded by serializers as &quot;XSLT&quot;.
    /// </summary>
    [EnumMember(Value = "XSLT")]
    [IsoId("_uPScMPRYEeuLhpyIdtJzwg")]
    [Description(@"Document format is XSLT.")]
    XSLT,
    
}
