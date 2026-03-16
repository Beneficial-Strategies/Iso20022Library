// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q-jNYCmyEeutWNGMV2XKIQ")]
[Description(@"Specifies the roles of the parties linked to a cheque.")]
[DerivedFrom(typeof(ChequePartyRoleCode))]
public enum ChequePartyRole1Code
{
    /// <summary>
    /// Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque.
    /// Encoded/decoded by serializers as &quot;DWEA&quot;.
    /// </summary>
    [EnumMember(Value = "DWEA")]
    [IsoId("_aLmLwSmyEeutWNGMV2XKIQ")]
    [Description(
        @"Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque."
    )]
    DraweeAgent = ChequePartyRoleCode.DraweeAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// Encoded/decoded by serializers as &quot;DWRA&quot;.
    /// </summary>
    [EnumMember(Value = "DWRA")]
    [IsoId("_aQkLUSmyEeutWNGMV2XKIQ")]
    [Description(@"Specifies the agent servicing the account of the cheque payer.")]
    DrawerAgent = ChequePartyRoleCode.DrawerAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// Encoded/decoded by serializers as &quot;PAYE&quot;.
    /// </summary>
    [EnumMember(Value = "PAYE")]
    [IsoId("_aVo4kSmyEeutWNGMV2XKIQ")]
    [Description(@"Party that receives an amount of money as specified in the cheque.")]
    Payee = ChequePartyRoleCode.Payee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_aeLwkSmyEeutWNGMV2XKIQ")]
    [Description(
        @"Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee."
    )]
    Payer = ChequePartyRoleCode.Payer, // same ordinal as derivation source for type conversions
}
