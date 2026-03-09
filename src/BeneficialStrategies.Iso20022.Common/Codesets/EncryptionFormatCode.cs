// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jZW04Gi3EeS87LmvcA55sg")]
[Description(@"Format of data before encryption, if the format is not plaintext or implicit.")]
[Derivations(typeof(EncryptionFormat1Code),typeof(EncryptionFormat2Code),typeof(EncryptionFormat3Code))]
public enum EncryptionFormatCode
{
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-31 standard.
    /// Encoded/decoded by serializers as &quot;TR31&quot;.
    /// </summary>
    [EnumMember(Value = "TR31")]
    [IsoId("_wFGHsGi3EeS87LmvcA55sg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-31 standard.")]
    TR31,
    
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-34 standard.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_7jHDIGi3EeS87LmvcA55sg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-34 standard.")]
    TR34,
    
    /// <summary>
    /// Format of a cryptographic key specified by the ISO20038 standard.
    /// Encoded/decoded by serializers as &quot;I238&quot;.
    /// </summary>
    [EnumMember(Value = "I238")]
    [IsoId("_1ucL8NtnEee9e6xduATmQg")]
    [Description(@"Format of a cryptographic key specified by the ISO20038 standard.")]
    ISO20038KeyWrap,
    
    /// <summary>
    /// Cipher Block Chaining mode of encryption
    /// Encoded/decoded by serializers as &quot;CBCE&quot;.
    /// </summary>
    [EnumMember(Value = "CBCE")]
    [IsoId("_zgUX4nx8EemHsOqJOzMVfg")]
    [Description(@"Cipher Block Chaining mode of encryption")]
    CBC,
    
    /// <summary>
    /// CTC encryption mode.
    /// Encoded/decoded by serializers as &quot;CTCE&quot;.
    /// </summary>
    [EnumMember(Value = "CTCE")]
    [IsoId("_zgUX43x8EemHsOqJOzMVfg")]
    [Description(@"CTC encryption mode.")]
    CTCE,
    
}
