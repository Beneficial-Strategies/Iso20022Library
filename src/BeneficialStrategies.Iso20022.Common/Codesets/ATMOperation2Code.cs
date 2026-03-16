// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMOperation2Code")]
[Description(@"Type of logical or physical operation on an ATM.")]
[DerivedFrom(typeof(ATMOperationCode))]
public enum ATMOperation2Code
{
    /// <summary>
    /// Adjust logical counters of the cassette.
    /// Encoded/decoded by serializers as &quot;ADJU&quot;.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_ATMOperation2Code_Adjust")]
    [Description(@"Adjust logical counters of the cassette.")]
    Adjust = ATMOperationCode.Adjust,

    /// <summary>
    /// Add physically media to cassette.
    /// Encoded/decoded by serializers as &quot;INSR&quot;.
    /// </summary>
    [EnumMember(Value = "INSR")]
    [IsoId("_ATMOperation2Code_InsertMedia")]
    [Description(@"Add physically media to cassette.")]
    InsertMedia = ATMOperationCode.InsertMedia,

    /// <summary>
    /// Loading cassette.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_ATMOperation2Code_Loading")]
    [Description(@"Loading cassette.")]
    Loading = ATMOperationCode.Loading,

    /// <summary>
    /// Remotely updating an ATM counter.
    /// Encoded/decoded by serializers as &quot;RCUP&quot;.
    /// </summary>
    [EnumMember(Value = "RCUP")]
    [IsoId("_ATMOperation2Code_RemoteCounterUpdate")]
    [Description(@"Remotely updating an ATM counter.")]
    RemoteCounterUpdate,

    /// <summary>
    /// Substract physically media from cassette.
    /// Encoded/decoded by serializers as &quot;REMV&quot;.
    /// </summary>
    [EnumMember(Value = "REMV")]
    [IsoId("_ATMOperation2Code_RemoveMedia")]
    [Description(@"Substract physically media from cassette.")]
    RemoveMedia = ATMOperationCode.RemoveMedia,

    /// <summary>
    /// Unload all cassettes, and load a new set of cassettes to replace these. The Cassette structures determines what was removed and what was added.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_ATMOperation2Code_Swap")]
    [Description(
        @"Unload all cassettes, and load a new set of cassettes to replace these. The Cassette structures determines what was removed and what was added."
    )]
    Swap,

    /// <summary>
    /// Unloading cassette.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_ATMOperation2Code_Unloading")]
    [Description(@"Unloading cassette.")]
    Unloading = ATMOperationCode.Unloading,
}
