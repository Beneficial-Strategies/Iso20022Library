// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the agent acting as main paying agent or sub paying agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bofrItp-Ed-ak6NoX_4Aeg_388156528")]
[Description(@"Identification of the agent acting as main paying agent or sub paying agent.")]
[Derivations(typeof(AgentRole1Code),typeof(AgentRole2Code))]
public enum AgentRoleCode
{
    /// <summary>
    /// The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties.
    /// Encoded/decoded by serializers as &quot;SPAY&quot;.
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_bofrI9p-Ed-ak6NoX_4Aeg_388156530")]
    [Description(@"The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties.")]
    SystemPayingAgent,
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as &quot;CODO&quot;.
    /// </summary>
    [EnumMember(Value = "CODO")]
    [IsoId("_bofrJNp-Ed-ak6NoX_4Aeg_388156683")]
    [Description(@"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    CoDomicile,
    
    /// <summary>
    /// Identification of the agent acting as main agent.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_bofrJdp-Ed-ak6NoX_4Aeg_415864347")]
    [Description(@"Identification of the agent acting as main agent.")]
    PrincipalAgent,
    
    /// <summary>
    /// Identification of the agent acting as co-domicile or sub agent.
    /// Encoded/decoded by serializers as &quot;SUBA&quot;.
    /// </summary>
    [EnumMember(Value = "SUBA")]
    [IsoId("_bofrJtp-Ed-ak6NoX_4Aeg_748333224")]
    [Description(@"Identification of the agent acting as co-domicile or sub agent.")]
    SubAgent,
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// Encoded/decoded by serializers as &quot;ISAG&quot;.
    /// </summary>
    [EnumMember(Value = "ISAG")]
    [IsoId("_bofrJ9p-Ed-ak6NoX_4Aeg_1321061383")]
    [Description(@"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.")]
    IssuerAgent,
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_bofrKNp-Ed-ak6NoX_4Aeg_-1757482460")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    Registrar,
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_bofrKdp-Ed-ak6NoX_4Aeg_-809026844")]
    [Description(@"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.")]
    PayingAgent,
    
}
