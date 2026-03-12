// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Computer file stored in a binary format.
/// </summary>
[IsoId("_SuAjOgEcEeCQm6a_G2yO_w_2121992872")]
[DisplayName("Binary File")]
public partial record BinaryFile1
{
    #nullable enable
    
    /// <summary>
    /// Code specifying the Multipurpose Internet Mail Extensions (MIME) type for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - MIME Media Types (www.iana.org/assignments/media-types).
    /// </summary>
    [IsoId("_SuAjOwEcEeCQm6a_G2yO_w_267897468")]
    [DisplayName("MIME Type")]
    [IsoXmlTag("MIMETp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MIMEType { get; init; } 
    
    /// <summary>
    /// Specifies the encoding algorithm used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Transfer Encodings (www.iana.org/assignments/transfer-encodings).
    /// </summary>
    [IsoId("_SuAjPAEcEeCQm6a_G2yO_w_-122688032")]
    [DisplayName("Encoding Type")]
    [IsoXmlTag("NcodgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EncodingType { get; init; } 
    
    /// <summary>
    /// Specifies a code signifying the particular character set used for this attached binary file. Reference IANA (Internet Assigned Numbers Authority) - Character Sets (www.iana.org/assignments/character-sets).
    /// </summary>
    [IsoId("_SuAjPQEcEeCQm6a_G2yO_w_-1899360630")]
    [DisplayName("Character Set")]
    [IsoXmlTag("CharSet")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CharacterSet { get; init; } 
    
    /// <summary>
    /// Binary object included in this attached binary file.
    /// </summary>
    [IsoId("_SuAjPgEcEeCQm6a_G2yO_w_-1127180314")]
    [DisplayName("Included Binary Object")]
    [IsoXmlTag("InclBinryObjct")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? IncludedBinaryObject { get; init; } 
    
    
    #nullable disable
    
}
