// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance of transactions with a certain status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bkLL0tp-Ed-ak6NoX_4Aeg_882404778")]
[Description(@"Specifies the balance of transactions with a certain status.")]
[Derivations(typeof(BalanceStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BalanceStatusCode>))]
#endif
public enum BalanceStatusCode
{
    /// <summary>
    /// Balance corresponding to the pending transactions.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_bkLL09p-Ed-ak6NoX_4Aeg_1047073637")]
    [Description(@"Balance corresponding to the pending transactions.")]
    Pending,

    /// <summary>
    /// Final status of a transaction when the associated transfer of cash has been successfully processed.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_bkLL1Np-Ed-ak6NoX_4Aeg_1047073638")]
    [Description(
        @"Final status of a transaction when the associated transfer of cash has been successfully processed."
    )]
    Settled,

    /// <summary>
    /// Balance corresponding to transactions that have been executed, but not yet settled.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_bkLL1dp-Ed-ak6NoX_4Aeg_1423587994")]
    [Description(
        @"Balance corresponding to transactions that have been executed, but not yet settled."
    )]
    Suspended,

    /// <summary>
    /// Balance corresponding to transactions that have been executed and settled, but not yet fully registered on the books of the registrar.
    /// Encoded/decoded by serializers as &quot;SETU&quot;.
    /// </summary>
    [EnumMember(Value = "SETU")]
    [IsoId("_bkLL1tp-Ed-ak6NoX_4Aeg_1423588002")]
    [Description(
        @"Balance corresponding to transactions that have been executed and settled, but not yet fully registered on the books of the registrar."
    )]
    SettledUnregistered,

    /// <summary>
    /// Balance corresponding to transactions that have been executed, settled and fully registered.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_bkLL19p-Ed-ak6NoX_4Aeg_1423588003")]
    [Description(
        @"Balance corresponding to transactions that have been executed, settled and fully registered."
    )]
    SettledRegistered,
}
