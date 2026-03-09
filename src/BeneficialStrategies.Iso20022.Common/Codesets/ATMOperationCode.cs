// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VNYCoOhAEeSbwP3G-MV9YA")]
[Description(@"Type of logical or physical operation on an ATM.")]
[Derivations(typeof(ATMOperation1Code))]
public enum ATMOperationCode
{
    /// <summary>
    /// Adjust logical counters of the cassette.
    /// Encoded/decoded by serializers as &quot;ADJU&quot;.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_csAXYOhAEeSbwP3G-MV9YA")]
    [Description(@"Adjust logical counters of the cassette.")]
    Adjust,
    
    /// <summary>
    /// Add physically media to cassette.
    /// Encoded/decoded by serializers as &quot;INSR&quot;.
    /// </summary>
    [EnumMember(Value = "INSR")]
    [IsoId("_jo54EOhAEeSbwP3G-MV9YA")]
    [Description(@"Add physically media to cassette.")]
    InsertMedia,
    
    /// <summary>
    /// Loading cassette.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_nZwTgOhAEeSbwP3G-MV9YA")]
    [Description(@"Loading cassette.")]
    Loading,
    
    /// <summary>
    /// Substract physically media from cassette.
    /// Encoded/decoded by serializers as &quot;REMV&quot;.
    /// </summary>
    [EnumMember(Value = "REMV")]
    [IsoId("_q0sJUOhAEeSbwP3G-MV9YA")]
    [Description(@"Substract physically media from cassette.")]
    RemoveMedia,
    
    /// <summary>
    /// Unloading cassette.
    /// Encoded/decoded by serializers as &quot;UNLD&quot;.
    /// </summary>
    [EnumMember(Value = "UNLD")]
    [IsoId("_xL_CkOhAEeSbwP3G-MV9YA")]
    [Description(@"Unloading cassette.")]
    Unloading,
    
}
