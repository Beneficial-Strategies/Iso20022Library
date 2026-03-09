// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method to be used in delivering a cheque to a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-oOxdp-Ed-ak6NoX_4Aeg_337061457")]
[Description(@"Specifies the method to be used in delivering a cheque to a party.")]
[Derivations(typeof(ChequeDelivery1Code),typeof(ChequeDelivery2Code))]
public enum ChequeDeliveryCode
{
    /// <summary>
    /// Cheque is to be sent through mail services to debtor.
    /// Encoded/decoded by serializers as &quot;MLDB&quot;.
    /// </summary>
    [EnumMember(Value = "MLDB")]
    [IsoId("_a-oOxtp-Ed-ak6NoX_4Aeg_369384589")]
    [Description(@"Cheque is to be sent through mail services to debtor.")]
    MailToDebtor,
    
    /// <summary>
    /// Cheque is to be sent through mail services to creditor.
    /// Encoded/decoded by serializers as &quot;MLCD&quot;.
    /// </summary>
    [EnumMember(Value = "MLCD")]
    [IsoId("_a-oOx9p-Ed-ak6NoX_4Aeg_454348891")]
    [Description(@"Cheque is to be sent through mail services to creditor.")]
    MailToCreditor,
    
    /// <summary>
    /// Cheque is to be sent through mail services to creditor agent.
    /// Encoded/decoded by serializers as &quot;MLFA&quot;.
    /// </summary>
    [EnumMember(Value = "MLFA")]
    [IsoId("_a-oOyNp-Ed-ak6NoX_4Aeg_455271423")]
    [Description(@"Cheque is to be sent through mail services to creditor agent.")]
    MailToFinalAgent,
    
    /// <summary>
    /// Cheque is to be sent through courier services to debtor.
    /// Encoded/decoded by serializers as &quot;CRDB&quot;.
    /// </summary>
    [EnumMember(Value = "CRDB")]
    [IsoId("_a-xYsNp-Ed-ak6NoX_4Aeg_456194658")]
    [Description(@"Cheque is to be sent through courier services to debtor.")]
    CourierToDebtor,
    
    /// <summary>
    /// Cheque is to be sent through courier services to creditor.
    /// Encoded/decoded by serializers as &quot;CRCD&quot;.
    /// </summary>
    [EnumMember(Value = "CRCD")]
    [IsoId("_a-xYsdp-Ed-ak6NoX_4Aeg_55718226")]
    [Description(@"Cheque is to be sent through courier services to creditor.")]
    CourierToCreditor,
    
    /// <summary>
    /// Cheque is to be sent through courier services to creditor agent.
    /// Encoded/decoded by serializers as &quot;CRFA&quot;.
    /// </summary>
    [EnumMember(Value = "CRFA")]
    [IsoId("_a-xYstp-Ed-ak6NoX_4Aeg_56641303")]
    [Description(@"Cheque is to be sent through courier services to creditor agent.")]
    CourierToFinalAgent,
    
    /// <summary>
    /// Cheque will be picked up by the debtor.
    /// Encoded/decoded by serializers as &quot;PUDB&quot;.
    /// </summary>
    [EnumMember(Value = "PUDB")]
    [IsoId("_a-xYs9p-Ed-ak6NoX_4Aeg_557187710")]
    [Description(@"Cheque will be picked up by the debtor.")]
    PickUpByDebtor,
    
    /// <summary>
    /// Cheque will be picked up by the creditor.
    /// Encoded/decoded by serializers as &quot;PUCD&quot;.
    /// </summary>
    [EnumMember(Value = "PUCD")]
    [IsoId("_a-xYtNp-Ed-ak6NoX_4Aeg_-61836275")]
    [Description(@"Cheque will be picked up by the creditor.")]
    PickUpByCreditor,
    
    /// <summary>
    /// Cheque will be picked up by the creditor agent.
    /// Encoded/decoded by serializers as &quot;PUFA&quot;.
    /// </summary>
    [EnumMember(Value = "PUFA")]
    [IsoId("_a-xYtdp-Ed-ak6NoX_4Aeg_-59989603")]
    [Description(@"Cheque will be picked up by the creditor agent.")]
    PickUpByFinalAgent,
    
    /// <summary>
    /// Cheque is to be sent through registered mail services to debtor.
    /// Encoded/decoded by serializers as &quot;RGDB&quot;.
    /// </summary>
    [EnumMember(Value = "RGDB")]
    [IsoId("_a-xYttp-Ed-ak6NoX_4Aeg_22203700")]
    [Description(@"Cheque is to be sent through registered mail services to debtor.")]
    RegisteredMailToDebtor,
    
    /// <summary>
    /// Cheque is to be sent through registered mail services to creditor.
    /// Encoded/decoded by serializers as &quot;RGCD&quot;.
    /// </summary>
    [EnumMember(Value = "RGCD")]
    [IsoId("_a-xYt9p-Ed-ak6NoX_4Aeg_337125880")]
    [Description(@"Cheque is to be sent through registered mail services to creditor.")]
    RegisteredMailToCreditor,
    
    /// <summary>
    /// Cheque is to be sent through registered mail services to creditor agent.
    /// Encoded/decoded by serializers as &quot;RGFA&quot;.
    /// </summary>
    [EnumMember(Value = "RGFA")]
    [IsoId("_a-xYuNp-Ed-ak6NoX_4Aeg_339893887")]
    [Description(@"Cheque is to be sent through registered mail services to creditor agent.")]
    RegisteredMailToFinalAgent,
    
}
