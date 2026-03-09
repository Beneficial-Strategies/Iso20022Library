// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used by the cardholder and the terminal for the choice of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IwRRkHs7EeSTS7uHCe8FPQ")]
[Description(@"Method used by the cardholder and the terminal for the choice of the account.")]
[Derivations(typeof(AccountChoiceMethod1Code))]
public enum AccountChoiceMethodCode
{
    /// <summary>
    /// Account selected in an account list.
    /// Encoded/decoded by serializers as &quot;ACSL&quot;.
    /// </summary>
    [EnumMember(Value = "ACSL")]
    [IsoId("_L62-QHs7EeSTS7uHCe8FPQ")]
    [Description(@"Account selected in an account list.")]
    AccountSelected,
    
    /// <summary>
    /// Account identification is entered by the customer.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_OzfYQHs7EeSTS7uHCe8FPQ")]
    [Description(@"Account identification is entered by the customer.")]
    Entered,
    
    /// <summary>
    /// Account is selected according to the configuration.
    /// Encoded/decoded by serializers as &quot;IMAC&quot;.
    /// </summary>
    [EnumMember(Value = "IMAC")]
    [IsoId("_Q_G7QHs7EeSTS7uHCe8FPQ")]
    [Description(@"Account is selected according to the configuration.")]
    ImplicitAccount,
    
    /// <summary>
    /// Type of account is selected according to the configuration.
    /// Encoded/decoded by serializers as &quot;IMPL&quot;.
    /// </summary>
    [EnumMember(Value = "IMPL")]
    [IsoId("_T4HvwHs7EeSTS7uHCe8FPQ")]
    [Description(@"Type of account is selected according to the configuration.")]
    ImplicitType,
    
    /// <summary>
    /// Type of account selected in a list.
    /// Encoded/decoded by serializers as &quot;TPSL&quot;.
    /// </summary>
    [EnumMember(Value = "TPSL")]
    [IsoId("_WnguMHs7EeSTS7uHCe8FPQ")]
    [Description(@"Type of account selected in a list.")]
    TypeSelected,
    
    /// <summary>
    /// Account is not selected by the customer or a profile, but by the issuer.
    /// Encoded/decoded by serializers as &quot;NOSL&quot;.
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("_aLRv4Hs7EeSTS7uHCe8FPQ")]
    [Description(@"Account is not selected by the customer or a profile, but by the issuer.")]
    NoSelection,
    
}
