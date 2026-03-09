// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eJokECmxEeutWNGMV2XKIQ")]
[Description(@"Specifies the roles of the parties linked to a cheque.")]
[Derivations(typeof(ChequePartyRole1Code))]
public enum ChequePartyRoleCode
{
    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// Encoded/decoded by serializers as &quot;PAYE&quot;.
    /// </summary>
    [EnumMember(Value = "PAYE")]
    [IsoId("_hn9FECmxEeutWNGMV2XKIQ")]
    [Description(@"Party that receives an amount of money as specified in the cheque.")]
    Payee,
    
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// Encoded/decoded by serializers as &quot;DWRA&quot;.
    /// </summary>
    [EnumMember(Value = "DWRA")]
    [IsoId("_htiIoCmxEeutWNGMV2XKIQ")]
    [Description(@"Specifies the agent servicing the account of the cheque payer.")]
    DrawerAgent,
    
    /// <summary>
    /// Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque.
    /// Encoded/decoded by serializers as &quot;DWEA&quot;.
    /// </summary>
    [EnumMember(Value = "DWEA")]
    [IsoId("_hxVqkCmxEeutWNGMV2XKIQ")]
    [Description(@"Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque.")]
    DraweeAgent,
    
    /// <summary>
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_j2rmcCmxEeutWNGMV2XKIQ")]
    [Description(@"Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.")]
    Payer,
    
}
