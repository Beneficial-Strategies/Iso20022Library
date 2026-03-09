// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action to realise on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_68vWQNuTEeiB5uLfkg9ZJA")]
[Description(@"Action to realise on a transaction.")]
[DerivedFrom(typeof(TransactionActionCode))]
public enum TransactionAction1Code
{
    /// <summary>
    /// Start a transaction by a swipe ahead mechanism, with the services which are enabled.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("__DTjAduTEeiB5uLfkg9ZJA")]
    [Description(@"Start a transaction by a swipe ahead mechanism, with the services which are enabled.")]
    StartTransaction = TransactionActionCode.StartTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Keep quite after a swipe ahead mechanism.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_L9kT0ezIEeiojesOXOKoug")]
    [Description(@"Keep quite after a swipe ahead mechanism.")]
    Stop = TransactionActionCode.Stop, // same ordinal as derivation source for type conversions
    
}
