// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of terminal management action to be performed by a point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GO0LkSiyEeurkfo6MpvKDA")]
[Description(@"Types of terminal management action to be performed by a point of interaction.")]
[DerivedFrom(typeof(TerminalManagementActionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TerminalManagementAction5Code>))]
#endif
public enum TerminalManagementAction5Code
{
    /// <summary>
    /// Request to deactivate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DCTV&quot;.
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_GmJtgSiyEeurkfo6MpvKDA")]
    [Description(@"Request to deactivate the element identified inside the message exchange.")]
    Deactivate = TerminalManagementActionCode.Deactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to delete the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_GmJtgyiyEeurkfo6MpvKDA")]
    [Description(@"Request to delete the element identified inside the message exchange.")]
    Delete = TerminalManagementActionCode.Delete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to download the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;DWNL&quot;.
    /// </summary>
    [EnumMember(Value = "DWNL")]
    [IsoId("_GmJthSiyEeurkfo6MpvKDA")]
    [Description(@"Request to download the element identified inside the message exchange.")]
    Download = TerminalManagementActionCode.Download, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to install the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_GmJthyiyEeurkfo6MpvKDA")]
    [Description(@"Request to install the element identified inside the message exchange.")]
    Install = TerminalManagementActionCode.Install, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to restart the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_GmJtiSiyEeurkfo6MpvKDA")]
    [Description(@"Request to restart the element identified inside the message exchange.")]
    Restart = TerminalManagementActionCode.Restart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to upload the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPLD&quot;.
    /// </summary>
    [EnumMember(Value = "UPLD")]
    [IsoId("_GmJtiyiyEeurkfo6MpvKDA")]
    [Description(@"Request to upload the element identified inside the message exchange.")]
    Upload = TerminalManagementActionCode.Upload, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to update the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_GmKUkSiyEeurkfo6MpvKDA")]
    [Description(@"Request to update the element identified inside the message exchange.")]
    Update = TerminalManagementActionCode.Update, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request sent to a POI to bind with a server.
    /// Encoded/decoded by serializers as &quot;BIND&quot;.
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_GmKUkyiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to bind with a server.")]
    Bind = TerminalManagementActionCode.Bind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request sent to a POI to rebind with a server.
    /// Encoded/decoded by serializers as &quot;RBND&quot;.
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_GmKUlSiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to rebind with a server.")]
    Rebind = TerminalManagementActionCode.Rebind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request sent to a POI to unbind with a server.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_GmKUlyiyEeurkfo6MpvKDA")]
    [Description(@"Request sent to a POI to unbind with a server.")]
    Unbind = TerminalManagementActionCode.Unbind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to activate the element identified inside the message exchange.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_GmKUmSiyEeurkfo6MpvKDA")]
    [Description(@"Request to activate the element identified inside the message exchange.")]
    Activate = TerminalManagementActionCode.Activate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to execute a device request.
    /// Encoded/decoded by serializers as &quot;DEVR&quot;.
    /// </summary>
    [EnumMember(Value = "DEVR")]
    [IsoId("_Mam_cSiyEeurkfo6MpvKDA")]
    [Description(@"Request to execute a device request.")]
    DeviceRequest = TerminalManagementActionCode.DeviceRequest, // same ordinal as derivation source for type conversions
}
