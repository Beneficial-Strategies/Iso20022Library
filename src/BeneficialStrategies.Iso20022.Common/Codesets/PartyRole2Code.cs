// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kyRs4I6VEemzmeK8_tPygg")]
[Description(@"Specifies the role of the party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum PartyRole2Code
{
    /// <summary>
    /// Party that act as an wholesaler of funds.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_nbvCcY6VEemzmeK8_tPygg")]
    [Description(@"Party that act as an wholesaler of funds.")]
    Distributor = PartyRoleCode.Distributor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// Encoded/decoded by serializers as &quot;LGRD&quot;.
    /// </summary>
    [EnumMember(Value = "LGRD")]
    [IsoId("_nzPjgo6VEemzmeK8_tPygg")]
    [Description(
        @"Party that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated."
    )]
    LegalGuardian = PartyRoleCode.LegalGuardian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is authorised to take investment decisions on behalf of the shareholder.
    /// Encoded/decoded by serializers as &quot;DECM&quot;.
    /// </summary>
    [EnumMember(Value = "DECM")]
    [IsoId("_pQEt4o6VEemzmeK8_tPygg")]
    [Description(
        @"Party that is authorised to take investment decisions on behalf of the shareholder."
    )]
    DecisionMaker = PartyRoleCode.DecisionMaker, // same ordinal as derivation source for type conversions
}
