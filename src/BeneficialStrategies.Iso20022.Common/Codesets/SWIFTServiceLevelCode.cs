// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the SWIFT service level that applies to the payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRGV99p-Ed-ak6NoX_4Aeg_1129333396")]
[Description(@"Specifies the SWIFT service level that applies to the payment instruction.")]
[Derivations(typeof(SWIFTServiceLevel2Code))]
public enum SWIFTServiceLevelCode
{
    /// <summary>
    /// Credit transfer is to be processed according to the SWIFTPay Service Level.
    /// Encoded/decoded by serializers as &quot;SPAY&quot;.
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_ZRGV-Np-Ed-ak6NoX_4Aeg_1129333404")]
    [Description(@"Credit transfer is to be processed according to the SWIFTPay Service Level.")]
    SWIFTPay,
    
    /// <summary>
    /// Credit transfer is to be processed according to the Priority Service Level.
    /// Encoded/decoded by serializers as &quot;SPRI&quot;.
    /// </summary>
    [EnumMember(Value = "SPRI")]
    [IsoId("_ZRQG8Np-Ed-ak6NoX_4Aeg_1129333405")]
    [Description(@"Credit transfer is to be processed according to the Priority Service Level.")]
    Priority,
    
    /// <summary>
    /// Credit transfer is to be processed according to the Standard Service Level.
    /// Encoded/decoded by serializers as &quot;SSTD&quot;.
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_ZRQG8dp-Ed-ak6NoX_4Aeg_1129333422")]
    [Description(@"Credit transfer is to be processed according to the Standard Service Level.")]
    Standard,
    
}
