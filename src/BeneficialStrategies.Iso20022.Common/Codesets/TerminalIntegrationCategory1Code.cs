// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Terminal category code of the place where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OGUBUGXPEem9Y55YJ70L8g")]
[Description(
    @"Terminal category code of the place where the merchant actually performed the transaction."
)]
[DerivedFrom(typeof(TerminalIntegrationCategoryCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TerminalIntegrationCategory1Code>))]
#endif
public enum TerminalIntegrationCategory1Code
{
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;MPOI&quot;.
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_hundoWXPEem9Y55YJ70L8g")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal = TerminalIntegrationCategoryCode.MultiplePOITerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as &quot;MSLE&quot;.
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_jFUx4WXPEem9Y55YJ70L8g")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal = TerminalIntegrationCategoryCode.MultipleSaleTerminal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;SSLE&quot;.
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_jfLcUWXPEem9Y55YJ70L8g")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal = TerminalIntegrationCategoryCode.SingleSaleTerminal, // same ordinal as derivation source for type conversions
}
