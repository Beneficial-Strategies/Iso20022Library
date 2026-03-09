// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Ukd8pqlEeGSON8vddiWzQ_1919731713")]
[Description(@"Defines the level of an account within the account hierarchy.")]
[Derivations(typeof(AccountLevel2Code),typeof(AccountLevel1Code))]
public enum AccountLevelCode
{
    /// <summary>
    /// Intermediate level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_6Ukd85qlEeGSON8vddiWzQ_-2115419931")]
    [Description(@"Intermediate level within an account hierarchy.")]
    Intermediate,
    
    /// <summary>
    /// Highest level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;SMRY&quot;.
    /// </summary>
    [EnumMember(Value = "SMRY")]
    [IsoId("_6Ukd9JqlEeGSON8vddiWzQ_-1741194392")]
    [Description(@"Highest level within an account hierarchy.")]
    Summary,
    
    /// <summary>
    /// Account is a real deposit/current account.
    /// Encoded/decoded by serializers as &quot;DETL&quot;.
    /// </summary>
    [EnumMember(Value = "DETL")]
    [IsoId("_6Ukd9ZqlEeGSON8vddiWzQ_-1690984951")]
    [Description(@"Account is a real deposit/current account.")]
    Detail,
    
}
