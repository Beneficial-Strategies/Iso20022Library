// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the level of an account within the account hierarchy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Uas85qlEeGSON8vddiWzQ_44836722")]
[Description(@"Defines the level of an account within the account hierarchy.")]
[DerivedFrom(typeof(AccountLevelCode))]
public enum AccountLevel1Code
{
    /// <summary>
    /// Intermediate level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;INTM&quot;.
    /// </summary>
    [EnumMember(Value = "INTM")]
    [IsoId("_6Uas9JqlEeGSON8vddiWzQ_1340728454")]
    [Description(@"Intermediate level within an account hierarchy.")]
    Intermediate = AccountLevelCode.Intermediate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Highest level within an account hierarchy.
    /// Encoded/decoded by serializers as &quot;SMRY&quot;.
    /// </summary>
    [EnumMember(Value = "SMRY")]
    [IsoId("_6Uas9ZqlEeGSON8vddiWzQ_1794815723")]
    [Description(@"Highest level within an account hierarchy.")]
    Summary = AccountLevelCode.Summary, // same ordinal as derivation source for type conversions
    
}
