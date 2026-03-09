// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of user interface to display or print information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVfZ_wEcEeCQm6a_G2yO_w_1617799141")]
[Description(@"Type of user interface to display or print information.")]
[Derivations(typeof(UserInterface7Code),typeof(UserInterface2Code),typeof(UserInterface5Code),typeof(UserInterface1Code),typeof(UserInterface4Code),typeof(UserInterface6Code),typeof(UserInterface8Code),typeof(UserInterface3Code))]
public enum UserInterfaceCode
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_TVfaAAEcEeCQm6a_G2yO_w_-1891105555")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay,
    
    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_TVfaAQEcEeCQm6a_G2yO_w_-1437018286")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt,
    
    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as &quot;MDSP&quot;.
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_TVpK8AEcEeCQm6a_G2yO_w_393904883")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay,
    
    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as &quot;MRCP&quot;.
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_TVpK8QEcEeCQm6a_G2yO_w_1154670036")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt,
    
    /// <summary>
    /// Acquirer.
    /// Encoded/decoded by serializers as &quot;ACQU&quot;.
    /// </summary>
    [EnumMember(Value = "ACQU")]
    [IsoId("_9IzrQIO2EeSWSLYdc10LRg")]
    [Description(@"Acquirer.")]
    Acquirer,
    
    /// <summary>
    /// Issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_W4Ok4IO5EeSWSLYdc10LRg")]
    [Description(@"Issuer.")]
    Issuer,
    
    /// <summary>
    /// Agent.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ax3I4IO5EeSWSLYdc10LRg")]
    [Description(@"Agent.")]
    Agent,
    
    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as &quot;CRDO&quot;.
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_tfIHAIO-EeSWSLYdc10LRg")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface,
    
    /// <summary>
    /// Information dedicated to a software application related to a device belonging to the cardholder.
    /// Encoded/decoded by serializers as &quot;CHAP&quot;.
    /// </summary>
    [EnumMember(Value = "CHAP")]
    [IsoId("_6HCaAHyMEemHsOqJOzMVfg")]
    [Description(@"Information dedicated to a software application related to a device belonging to the cardholder.")]
    CardholderApplication,
    
    /// <summary>
    /// Data dedicated to an application maintained by a clearing agent.
    /// Encoded/decoded by serializers as &quot;CLRA&quot;.
    /// </summary>
    [EnumMember(Value = "CLRA")]
    [IsoId("_6HCaAXyMEemHsOqJOzMVfg")]
    [Description(@"Data dedicated to an application maintained by a clearing agent.")]
    ClearingAgentApplication,
    
    /// <summary>
    /// Data dedicated to a log maintained by the clearing agent.
    /// Encoded/decoded by serializers as &quot;CLRL&quot;.
    /// </summary>
    [EnumMember(Value = "CLRL")]
    [IsoId("_6HCaAnyMEemHsOqJOzMVfg")]
    [Description(@"Data dedicated to a log maintained by the clearing agent.")]
    ClearingAgentLog,
    
    /// <summary>
    /// Interface used in case of disputes or chargebacks.
    /// Encoded/decoded by serializers as &quot;DSPU&quot;.
    /// </summary>
    [EnumMember(Value = "DSPU")]
    [IsoId("_6HCaA3yMEemHsOqJOzMVfg")]
    [Description(@"Interface used in case of disputes or chargebacks.")]
    Dispute,
    
    /// <summary>
    /// File used to store the message.
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_6HCaBHyMEemHsOqJOzMVfg")]
    [Description(@"File used to store the message.")]
    File,
    
    /// <summary>
    /// Information dedicated to a log file.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_6HCaBXyMEemHsOqJOzMVfg")]
    [Description(@"Information dedicated to a log file.")]
    Log,
    
    /// <summary>
    /// Information dedicated to a software application related to a device belonging to the merchant.
    /// Encoded/decoded by serializers as &quot;MRAP&quot;.
    /// </summary>
    [EnumMember(Value = "MRAP")]
    [IsoId("_6HCaBnyMEemHsOqJOzMVfg")]
    [Description(@"Information dedicated to a software application related to a device belonging to the merchant.")]
    MerchantApplication,
    
    /// <summary>
    /// Other type of acquirer interface.
    /// Encoded/decoded by serializers as &quot;OTAI&quot;.
    /// </summary>
    [EnumMember(Value = "OTAI")]
    [IsoId("_6HCaB3yMEemHsOqJOzMVfg")]
    [Description(@"Other type of acquirer interface.")]
    OtherAcquirerInterface,
    
    /// <summary>
    /// Data dedicated to another interface maintained by the clearing agent.
    /// Encoded/decoded by serializers as &quot;OCAI&quot;.
    /// </summary>
    [EnumMember(Value = "OCAI")]
    [IsoId("_6HCaCHyMEemHsOqJOzMVfg")]
    [Description(@"Data dedicated to another interface maintained by the clearing agent.")]
    OtherClearingAgentInterface,
    
    /// <summary>
    /// Other type of issuer interface.
    /// Encoded/decoded by serializers as &quot;OTII&quot;.
    /// </summary>
    [EnumMember(Value = "OTII")]
    [IsoId("_6HCaCXyMEemHsOqJOzMVfg")]
    [Description(@"Other type of issuer interface.")]
    OtherIssuerInterface,
    
    /// <summary>
    /// Other interface of the merchant for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as &quot;MRIN&quot;.
    /// </summary>
    [EnumMember(Value = "MRIN")]
    [IsoId("_6HCaCnyMEemHsOqJOzMVfg")]
    [Description(@"Other interface of the merchant for instance e-mail or smartphone message.")]
    OtherMerchantInterface,
    
    /// <summary>
    /// Other type of interface defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6HCaC3yMEemHsOqJOzMVfg")]
    [Description(@"Other type of interface defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of interface defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6HCaDHyMEemHsOqJOzMVfg")]
    [Description(@"Other type of interface defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Other settlement agent interface.
    /// Encoded/decoded by serializers as &quot;OSAI&quot;.
    /// </summary>
    [EnumMember(Value = "OSAI")]
    [IsoId("_6HCaDXyMEemHsOqJOzMVfg")]
    [Description(@"Other settlement agent interface.")]
    OtherSettlementAgentInterface,
    
    /// <summary>
    /// Settlement agent interface.
    /// Encoded/decoded by serializers as &quot;STLI&quot;.
    /// </summary>
    [EnumMember(Value = "STLI")]
    [IsoId("_6HCaDnyMEemHsOqJOzMVfg")]
    [Description(@"Settlement agent interface.")]
    SettlementAgent,
    
    /// <summary>
    /// Credit information related to a top-up account.
    /// Encoded/decoded by serializers as &quot;TUCR&quot;.
    /// </summary>
    [EnumMember(Value = "TUCR")]
    [IsoId("_6HCaD3yMEemHsOqJOzMVfg")]
    [Description(@"Credit information related to a top-up account.")]
    TopUpCredit,
    
}
