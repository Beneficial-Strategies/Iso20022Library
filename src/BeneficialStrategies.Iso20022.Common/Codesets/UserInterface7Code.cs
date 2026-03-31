// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Clearing agent dedicated interface.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VtKV4FBAEeedyPuM0kK2EQ")]
[Description(@"Clearing agent dedicated interface.")]
[DerivedFrom(typeof(UserInterfaceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UserInterface7Code>))]
#endif
public enum UserInterface7Code
{
    /// <summary>
    /// Data dedicated to another interface maintained by the clearing agent.
    /// Encoded/decoded by serializers as &quot;OCAI&quot;.
    /// </summary>
    [EnumMember(Value = "OCAI")]
    [IsoId("_cwZIEVBAEeedyPuM0kK2EQ")]
    [Description(@"Data dedicated to another interface maintained by the clearing agent.")]
    OtherClearingAgentInterface = UserInterfaceCode.OtherClearingAgentInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data dedicated to a log maintained by the clearing agent.
    /// Encoded/decoded by serializers as &quot;CLRL&quot;.
    /// </summary>
    [EnumMember(Value = "CLRL")]
    [IsoId("_dHTzQlBAEeedyPuM0kK2EQ")]
    [Description(@"Data dedicated to a log maintained by the clearing agent.")]
    ClearingAgentLog = UserInterfaceCode.ClearingAgentLog, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data dedicated to an application maintained by a clearing agent.
    /// Encoded/decoded by serializers as &quot;CLRA&quot;.
    /// </summary>
    [EnumMember(Value = "CLRA")]
    [IsoId("_dRH2klBAEeedyPuM0kK2EQ")]
    [Description(@"Data dedicated to an application maintained by a clearing agent.")]
    ClearingAgentApplication = UserInterfaceCode.ClearingAgentApplication, // same ordinal as derivation source for type conversions
}
