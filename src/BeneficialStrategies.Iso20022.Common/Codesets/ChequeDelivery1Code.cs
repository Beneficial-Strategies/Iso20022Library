// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method to be used in delivering a cheque to a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a-Usx9p-Ed-ak6NoX_4Aeg_681596924")]
[Description(@"Specifies the method to be used in delivering a cheque to a party.")]
[DerivedFrom(typeof(ChequeDeliveryCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChequeDelivery1Code>))]
#endif
public enum ChequeDelivery1Code
{
    /// <summary>
    /// Cheque is to be sent through mail services to debtor.
    /// Encoded/decoded by serializers as &quot;MLDB&quot;.
    /// </summary>
    [EnumMember(Value = "MLDB")]
    [IsoId("_a-UsyNp-Ed-ak6NoX_4Aeg_740702059")]
    [Description(@"Cheque is to be sent through mail services to debtor.")]
    MailToDebtor = ChequeDeliveryCode.MailToDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through mail services to creditor.
    /// Encoded/decoded by serializers as &quot;MLCD&quot;.
    /// </summary>
    [EnumMember(Value = "MLCD")]
    [IsoId("_a-edwNp-Ed-ak6NoX_4Aeg_740702112")]
    [Description(@"Cheque is to be sent through mail services to creditor.")]
    MailToCreditor = ChequeDeliveryCode.MailToCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through mail services to creditor agent.
    /// Encoded/decoded by serializers as &quot;MLFA&quot;.
    /// </summary>
    [EnumMember(Value = "MLFA")]
    [IsoId("_a-edwdp-Ed-ak6NoX_4Aeg_740702197")]
    [Description(@"Cheque is to be sent through mail services to creditor agent.")]
    MailToFinalAgent = ChequeDeliveryCode.MailToFinalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through courier services to debtor.
    /// Encoded/decoded by serializers as &quot;CRDB&quot;.
    /// </summary>
    [EnumMember(Value = "CRDB")]
    [IsoId("_a-edwtp-Ed-ak6NoX_4Aeg_740702267")]
    [Description(@"Cheque is to be sent through courier services to debtor.")]
    CourierToDebtor = ChequeDeliveryCode.CourierToDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through courier services to creditor.
    /// Encoded/decoded by serializers as &quot;CRCD&quot;.
    /// </summary>
    [EnumMember(Value = "CRCD")]
    [IsoId("_a-edw9p-Ed-ak6NoX_4Aeg_740702569")]
    [Description(@"Cheque is to be sent through courier services to creditor.")]
    CourierToCreditor = ChequeDeliveryCode.CourierToCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through courier services to creditor agent.
    /// Encoded/decoded by serializers as &quot;CRFA&quot;.
    /// </summary>
    [EnumMember(Value = "CRFA")]
    [IsoId("_a-edxNp-Ed-ak6NoX_4Aeg_740702664")]
    [Description(@"Cheque is to be sent through courier services to creditor agent.")]
    CourierToFinalAgent = ChequeDeliveryCode.CourierToFinalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque will be picked up by the debtor.
    /// Encoded/decoded by serializers as &quot;PUDB&quot;.
    /// </summary>
    [EnumMember(Value = "PUDB")]
    [IsoId("_a-edxdp-Ed-ak6NoX_4Aeg_740702989")]
    [Description(@"Cheque will be picked up by the debtor.")]
    PickUpByDebtor = ChequeDeliveryCode.PickUpByDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque will be picked up by the creditor.
    /// Encoded/decoded by serializers as &quot;PUCD&quot;.
    /// </summary>
    [EnumMember(Value = "PUCD")]
    [IsoId("_a-edxtp-Ed-ak6NoX_4Aeg_740703067")]
    [Description(@"Cheque will be picked up by the creditor.")]
    PickUpByCreditor = ChequeDeliveryCode.PickUpByCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque will be picked up by the creditor agent.
    /// Encoded/decoded by serializers as &quot;PUFA&quot;.
    /// </summary>
    [EnumMember(Value = "PUFA")]
    [IsoId("_a-edx9p-Ed-ak6NoX_4Aeg_740703144")]
    [Description(@"Cheque will be picked up by the creditor agent.")]
    PickUpByFinalAgent = ChequeDeliveryCode.PickUpByFinalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through registered mail services to debtor.
    /// Encoded/decoded by serializers as &quot;RGDB&quot;.
    /// </summary>
    [EnumMember(Value = "RGDB")]
    [IsoId("_a-edyNp-Ed-ak6NoX_4Aeg_740703222")]
    [Description(@"Cheque is to be sent through registered mail services to debtor.")]
    RegisteredMailToDebtor = ChequeDeliveryCode.RegisteredMailToDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through registered mail services to creditor.
    /// Encoded/decoded by serializers as &quot;RGCD&quot;.
    /// </summary>
    [EnumMember(Value = "RGCD")]
    [IsoId("_a-edydp-Ed-ak6NoX_4Aeg_740703534")]
    [Description(@"Cheque is to be sent through registered mail services to creditor.")]
    RegisteredMailToCreditor = ChequeDeliveryCode.RegisteredMailToCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque is to be sent through registered mail services to creditor agent.
    /// Encoded/decoded by serializers as &quot;RGFA&quot;.
    /// </summary>
    [EnumMember(Value = "RGFA")]
    [IsoId("_a-edytp-Ed-ak6NoX_4Aeg_740703629")]
    [Description(@"Cheque is to be sent through registered mail services to creditor agent.")]
    RegisteredMailToFinalAgent = ChequeDeliveryCode.RegisteredMailToFinalAgent, // same ordinal as derivation source for type conversions
}
