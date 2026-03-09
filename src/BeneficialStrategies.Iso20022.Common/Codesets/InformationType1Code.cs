// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded type of additional information provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWiUCNp-Ed-ak6NoX_4Aeg_1720047653")]
[Description(@"Specifies the coded type of additional information provided.")]
[DerivedFrom(typeof(InformationTypeCode))]
public enum InformationType1Code
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_aWsFANp-Ed-ak6NoX_4Aeg_1720047685")]
    [Description(@"Instructions used to ease automatic request processing.")]
    ProcessingInstructions = InformationTypeCode.ProcessingInstructions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// Encoded/decoded by serializers as &quot;RELY&quot;.
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_aWsFAdp-Ed-ak6NoX_4Aeg_1720047911")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RelayInstructions = InformationTypeCode.RelayInstructions, // same ordinal as derivation source for type conversions
    
}
