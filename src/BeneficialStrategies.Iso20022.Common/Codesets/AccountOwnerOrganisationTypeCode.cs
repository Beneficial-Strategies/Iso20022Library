// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n3YwkIbPEe-t37QnP3-RAg")]
[Description(@"Specifies the type of account ownership.")]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountOwnerOrganisationTypeCode>))]
#endif
public enum AccountOwnerOrganisationTypeCode
{
    /// <summary>
    /// An organisation owns the account. Usage: This can be any kind of organisation, for example corporate, not for profit, government.
    /// Encoded/decoded by serializers as &quot;ORGN&quot;.
    /// </summary>
    [EnumMember(Value = "ORGN")]
    [IsoId("_w6OqEIbPEe-t37QnP3-RAg")]
    [Description(@"An organisation owns the account. Usage: This can be any kind of organisation, for example corporate, not for profit, government.")]
    Organisation,

    /// <summary>
    /// A private person owns the account.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_zYajwYbPEe-t37QnP3-RAg")]
    [Description(@"A private person owns the account.")]
    Private,
}
